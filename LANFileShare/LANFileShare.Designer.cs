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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ControlDarkDark;
            lblStatus.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(13, 88);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(167, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Server Stopped";
            // 
            // btnStartServer
            // 
            btnStartServer.BackColor = Color.PaleGreen;
            btnStartServer.FlatAppearance.BorderColor = Color.Black;
            btnStartServer.Font = new Font("Inter", 9F);
            btnStartServer.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartServer.Location = new Point(12, 12);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(93, 33);
            btnStartServer.TabIndex = 1;
            btnStartServer.Text = "Start Server";
            btnStartServer.UseVisualStyleBackColor = false;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.BackColor = Color.Salmon;
            btnStopServer.Enabled = false;
            btnStopServer.FlatAppearance.BorderColor = Color.Black;
            btnStopServer.Font = new Font("Inter", 9F);
            btnStopServer.ImageAlign = ContentAlignment.MiddleLeft;
            btnStopServer.Location = new Point(111, 12);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(93, 33);
            btnStopServer.TabIndex = 2;
            btnStopServer.Text = "Stop Server";
            btnStopServer.UseVisualStyleBackColor = false;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // txtServerUrl
            // 
            txtServerUrl.BorderStyle = BorderStyle.FixedSingle;
            txtServerUrl.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServerUrl.Location = new Point(186, 88);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.ReadOnly = true;
            txtServerUrl.Size = new Size(295, 27);
            txtServerUrl.TabIndex = 3;
            // 
            // lstFiles
            // 
            lstFiles.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFiles.FormattingEnabled = true;
            lstFiles.HorizontalScrollbar = true;
            lstFiles.Location = new Point(13, 123);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(468, 244);
            lstFiles.TabIndex = 4;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Font = new Font("Inter", 9F);
            btnDeleteFile.Location = new Point(210, 12);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(93, 33);
            btnDeleteFile.TabIndex = 5;
            btnDeleteFile.Text = "Delete File";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnCopyLink
            // 
            btnCopyLink.Font = new Font("Inter", 9F);
            btnCopyLink.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopyLink.Location = new Point(111, 51);
            btnCopyLink.Name = "btnCopyLink";
            btnCopyLink.Size = new Size(93, 23);
            btnCopyLink.TabIndex = 6;
            btnCopyLink.Text = "Copy";
            btnCopyLink.UseVisualStyleBackColor = true;
            btnCopyLink.Click += btnCopyLink_Click;
            // 
            // btnOpenBrowser
            // 
            btnOpenBrowser.Font = new Font("Inter", 9F);
            btnOpenBrowser.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenBrowser.Location = new Point(13, 51);
            btnOpenBrowser.Name = "btnOpenBrowser";
            btnOpenBrowser.Size = new Size(92, 23);
            btnOpenBrowser.TabIndex = 7;
            btnOpenBrowser.Text = "Open";
            btnOpenBrowser.UseVisualStyleBackColor = true;
            btnOpenBrowser.Click += btnOpenBrowser_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Font = new Font("Inter", 9F);
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(309, 12);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(93, 33);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "Delete all";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnShowQR
            // 
            btnShowQR.Font = new Font("Inter", 9F);
            btnShowQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowQR.Location = new Point(212, 51);
            btnShowQR.Name = "btnShowQR";
            btnShowQR.Size = new Size(91, 23);
            btnShowQR.TabIndex = 9;
            btnShowQR.Text = "Show QR";
            btnShowQR.UseVisualStyleBackColor = true;
            btnShowQR.Click += btnShowQR_Click;
            // 
            // pbQRCode
            // 
            pbQRCode.Location = new Point(0, 0);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(243, 243);
            pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQRCode.TabIndex = 10;
            pbQRCode.TabStop = false;
            pbQRCode.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pbQRCode);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(487, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 243);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Inter", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 62);
            label1.Name = "label1";
            label1.Size = new Size(243, 119);
            label1.TabIndex = 12;
            label1.Text = "QR will appear here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(665, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LANFileShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(740, 378);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(760, 421);
            MinimumSize = new Size(760, 421);
            Name = "LANFileShare";
            RightToLeft = RightToLeft.No;
            Text = "LANFileShare";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
