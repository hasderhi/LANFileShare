namespace LANFileShare
{
    partial class LANFileShare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LANFileShare));
            lblStatus = new Label();
            btnStartServer = new Button();
            btnStopServer = new Button();
            txtServerUrl = new TextBox();
            lstFiles = new ListBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnDeleteFile = new Button();
            btnCopyLink = new Button();
            btnOpenBrowser = new Button();
            btnDeleteAll = new Button();
            btnShowQR = new Button();
            pbQRCode = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(219, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Server Status: Stopped";
            // 
            // btnStartServer
            // 
            btnStartServer.Image = (Image)resources.GetObject("btnStartServer.Image");
            btnStartServer.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartServer.Location = new Point(12, 41);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(93, 23);
            btnStartServer.TabIndex = 1;
            btnStartServer.Text = "Start Server";
            btnStartServer.TextAlign = ContentAlignment.MiddleRight;
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.Enabled = false;
            btnStopServer.Image = (Image)resources.GetObject("btnStopServer.Image");
            btnStopServer.ImageAlign = ContentAlignment.MiddleLeft;
            btnStopServer.Location = new Point(111, 41);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(93, 23);
            btnStopServer.TabIndex = 2;
            btnStopServer.Text = "Stop Server";
            btnStopServer.TextAlign = ContentAlignment.MiddleRight;
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // txtServerUrl
            // 
            txtServerUrl.Location = new Point(210, 41);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.ReadOnly = true;
            txtServerUrl.Size = new Size(191, 23);
            txtServerUrl.TabIndex = 3;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.HorizontalScrollbar = true;
            lstFiles.Location = new Point(12, 71);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(389, 214);
            lstFiles.TabIndex = 4;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Image = (Image)resources.GetObject("btnDeleteFile.Image");
            btnDeleteFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteFile.Location = new Point(12, 292);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(93, 23);
            btnDeleteFile.TabIndex = 5;
            btnDeleteFile.Text = "Delete File";
            btnDeleteFile.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnCopyLink
            // 
            btnCopyLink.Image = (Image)resources.GetObject("btnCopyLink.Image");
            btnCopyLink.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopyLink.Location = new Point(488, 40);
            btnCopyLink.Name = "btnCopyLink";
            btnCopyLink.Size = new Size(75, 23);
            btnCopyLink.TabIndex = 6;
            btnCopyLink.Text = "Copy";
            btnCopyLink.TextAlign = ContentAlignment.MiddleRight;
            btnCopyLink.UseVisualStyleBackColor = true;
            btnCopyLink.Click += btnCopyLink_Click;
            // 
            // btnOpenBrowser
            // 
            btnOpenBrowser.Image = (Image)resources.GetObject("btnOpenBrowser.Image");
            btnOpenBrowser.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenBrowser.Location = new Point(569, 40);
            btnOpenBrowser.Name = "btnOpenBrowser";
            btnOpenBrowser.Size = new Size(75, 23);
            btnOpenBrowser.TabIndex = 7;
            btnOpenBrowser.Text = "Open";
            btnOpenBrowser.TextAlign = ContentAlignment.MiddleRight;
            btnOpenBrowser.UseVisualStyleBackColor = true;
            btnOpenBrowser.Click += btnOpenBrowser_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Image = (Image)resources.GetObject("btnDeleteAll.Image");
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(111, 292);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(93, 23);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "Delete all";
            btnDeleteAll.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnShowQR
            // 
            btnShowQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowQR.Location = new Point(407, 40);
            btnShowQR.Name = "btnShowQR";
            btnShowQR.Size = new Size(75, 23);
            btnShowQR.TabIndex = 9;
            btnShowQR.Text = "Show QR";
            btnShowQR.UseVisualStyleBackColor = true;
            btnShowQR.Click += btnShowQR_Click;
            // 
            // pbQRCode
            // 
            pbQRCode.Location = new Point(0, 0);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(237, 214);
            pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQRCode.TabIndex = 10;
            pbQRCode.TabStop = false;
            pbQRCode.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pbQRCode);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(407, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 214);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 119);
            label1.TabIndex = 12;
            label1.Text = "QR will appear here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(470, 297);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 12;
            label2.Text = "LANFileShare by tk_dev";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(72, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 92);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // LANFileShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 327);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnShowQR);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnOpenBrowser);
            Controls.Add(btnCopyLink);
            Controls.Add(btnDeleteFile);
            Controls.Add(lstFiles);
            Controls.Add(txtServerUrl);
            Controls.Add(btnStopServer);
            Controls.Add(btnStartServer);
            Controls.Add(lblStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LANFileShare";
            Text = "LANFileShare";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnStartServer;
        private Button btnStopServer;
        private TextBox txtServerUrl;
        private ListBox lstFiles;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnDeleteFile;
        private Button btnCopyLink;
        private Button btnOpenBrowser;
        private Button btnDeleteAll;
        private Button btnShowQR;
        private PictureBox pbQRCode;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
