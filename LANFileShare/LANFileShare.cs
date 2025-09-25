using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

//
// LANFileShare by Tobias Kisling
//

namespace LANFileShare
{
    public partial class LANFileShare : Form
    {
        private IHost? serverHost;
        private string sharedFolderPath = Path.Combine(Application.StartupPath, "SharedFiles");
        private int port = 5000; // Todo: make changable through GUI
        private string serverUrl;

        private Dictionary<string, FileMetadata> fileMetadata = new Dictionary<string, FileMetadata>();

        private class FileMetadata
        {
            public string FileName { get; set; }
            public DateTime UploadTime { get; set; }
            public DateTime? LastDownloadTime { get; set; }
            public int DownloadCount { get; set; }
            public string UploaderIP { get; set; }
        }



        public LANFileShare()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadExistingFiles();
        }



        private void LoadExistingFiles()
        {
            if (!Directory.Exists(sharedFolderPath))
                Directory.CreateDirectory(sharedFolderPath);

            string[] files = Directory.GetFiles(sharedFolderPath);

            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);

                if (!fileMetadata.ContainsKey(fileName))
                {
                    fileMetadata[fileName] = new FileMetadata
                    {
                        FileName = fileName,
                        UploadTime = File.GetCreationTime(file),
                        LastDownloadTime = null,
                        DownloadCount = 0,
                        UploaderIP = "Saved locally"
                    };
                }
            }

            UpdateFileList(); // Refresh
        }



        private string GetLocalIPAddress()
        {
            string fallbackIP = "127.0.0.1"; // Default if no network found - if this happens, the app can't share anything
            string wifiIP = null;
            string ethernetIP = null;

            foreach (var networkInterface in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                // Check if adapter active
                if (networkInterface.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    foreach (var address in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            string ip = address.Address.ToString();

                            // Ensure valid private network IP
                            if (ip.StartsWith("192.168.") || ip.StartsWith("10.") || ip.StartsWith("172.16.") || ip.StartsWith("172.31."))
                            {
                                // Prioritize Wi-Fi (Because most people will use this over Wi-Fi)
                                if (networkInterface.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211)
                                {
                                    wifiIP = ip;
                                }
                                // Ethernet as fallback
                                else if (networkInterface.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Ethernet)
                                {
                                    ethernetIP = ip;
                                }
                            }
                        }
                    }
                }
            }

            // Use Wi-Fi first, then Ethernet, then fallback
            return wifiIP ?? ethernetIP ?? fallbackIP;
        }



        private Bitmap GenerateQRCode(string url)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(10);
            }
        }



        private void UpdateFileList()
        {
            if (lstFiles.InvokeRequired)
            {
                lstFiles.Invoke(new Action(UpdateFileList));
                return;
            }

            lstFiles.Items.Clear();
            foreach (var file in fileMetadata.Values)
            {
                string fileInfo = $"{file.FileName} | Uploaded: {file.UploadTime} | " +
                                  $"Last Download: {(file.LastDownloadTime.HasValue ? file.LastDownloadTime.Value.ToString() : "Never")} | " +
                                  $"Downloads: {file.DownloadCount} | Uploader IP: {file.UploaderIP}";
                lstFiles.Items.Add(fileInfo);
            }
        }



        private async void StartServer()
        {
            if (!Directory.Exists(sharedFolderPath))
                Directory.CreateDirectory(sharedFolderPath);

            serverUrl = $"http://{GetLocalIPAddress()}:{port}";
            txtServerUrl.Text = serverUrl;

            serverHost = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel()
                        .UseUrls(serverUrl)
                        .Configure(app =>
                        {
                            app.UseRouting();

                            app.UseEndpoints(endpoints =>
                            {
                                endpoints.MapGet("/", async context =>
                                {
                                    string htmlPage = File.ReadAllText("wwwroot/index.html");
                                    await context.Response.WriteAsync(htmlPage);
                                });

                                endpoints.MapPost("/upload", async context =>
                                {
                                    var files = context.Request.Form.Files;
                                    var uploaderIP = context.Connection.RemoteIpAddress.ToString();

                                    if (files.Count > 0)
                                    {
                                        foreach (var file in files)
                                        {
                                            string originalFileName = Path.GetFileNameWithoutExtension(file.FileName);
                                            string extension = Path.GetExtension(file.FileName);
                                            string newFileName = file.FileName;
                                            string filePath = Path.Combine(sharedFolderPath, newFileName);
                                            int counter = 1;

                                            // Prevent file overwrite
                                            while (File.Exists(filePath))
                                            {
                                                newFileName = $"{originalFileName}_{counter}{extension}";
                                                filePath = Path.Combine(sharedFolderPath, newFileName);
                                                counter++;
                                            }


                                            using var stream = new FileStream(filePath, FileMode.Create);
                                            await file.CopyToAsync(stream);

                                            fileMetadata[newFileName] = new FileMetadata
                                            {
                                                FileName = newFileName,
                                                UploadTime = DateTime.Now,
                                                LastDownloadTime = null,
                                                DownloadCount = 0,
                                                UploaderIP = uploaderIP
                                            };

                                            this.Invoke((MethodInvoker)delegate { UpdateFileList(); });
                                        }
                                    }
                                    await context.Response.WriteAsync("Upload successful!");
                                });




                                endpoints.MapGet("/files", async context =>
                                {
                                    var files = Directory.GetFiles(sharedFolderPath)
                                                         .Select(Path.GetFileName)
                                                         .ToArray();
                                    context.Response.ContentType = "application/json";
                                    await context.Response.WriteAsync(JsonConvert.SerializeObject(files));
                                });

                                endpoints.MapGet("/download/{fileName}", async context =>
                                {
                                    string fileName = context.Request.RouteValues["fileName"]?.ToString();
                                    string filePath = Path.Combine(sharedFolderPath, fileName);
                                    string downloaderIP = context.Connection.RemoteIpAddress.ToString();

                                    if (File.Exists(filePath))
                                    {
                                        if (fileMetadata.ContainsKey(fileName))
                                        {
                                            fileMetadata[fileName].LastDownloadTime = DateTime.Now;
                                            fileMetadata[fileName].DownloadCount += 1;

                                            this.Invoke((MethodInvoker)delegate { UpdateFileList(); });
                                        }

                                        context.Response.ContentType = "application/octet-stream";
                                        context.Response.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
                                        await context.Response.SendFileAsync(filePath);
                                    }
                                    else
                                    {
                                        context.Response.StatusCode = 404;
                                        await context.Response.WriteAsync("File not found");
                                    }
                                });

                                endpoints.MapGet("/file-info", async context =>
                                {
                                    context.Response.ContentType = "application/json";
                                    await context.Response.WriteAsync(JsonConvert.SerializeObject(fileMetadata.Values));
                                });


                            });
                        });
                })
                .Build();

            await serverHost.StartAsync();
            lblStatus.Text = "Server Running";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }

        private async void StopServer()
        {
            if (serverHost != null)
            {
                await serverHost.StopAsync();
                serverHost.Dispose();
                serverHost = null;
                lblStatus.Text = "Server Stopped";
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;
            }
        }



        private void btnStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }



        private void btnStopServer_Click(object sender, EventArgs e)
        {
            StopServer();
        }



        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFile = lstFiles.SelectedItem.ToString().Split('|')[0].Trim();
            string filePath = Path.Combine(sharedFolderPath, selectedFile);

            var confirm = MessageBox.Show($"Are you sure you want to delete '{selectedFile}'?", "Confirm Deletion",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        fileMetadata.Remove(selectedFile);
                        UpdateFileList();
                        MessageBox.Show("File deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            string serverUrl = $"http://{GetLocalIPAddress()}:5000";
            Clipboard.SetText(serverUrl);
            MessageBox.Show("Link copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            string serverUrl = $"http://{GetLocalIPAddress()}:5000";
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = serverUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (lstFiles.Items.Count == 0)
            {
                MessageBox.Show("No files to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete ALL files?", "Confirm Deletion",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(sharedFolderPath))
                    {
                        File.Delete(file);
                    }

                    fileMetadata.Clear();
                    UpdateFileList();

                    MessageBox.Show("All files deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnShowQR_Click(object sender, EventArgs e)
        {
            string serverUrl = $"http://{GetLocalIPAddress()}:5000";
            pbQRCode.Image = GenerateQRCode(serverUrl);
            pbQRCode.Visible = true;
        }

    }
}
