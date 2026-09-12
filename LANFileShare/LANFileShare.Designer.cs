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
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(64, 64, 64);
            lblStatus.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(428, 32);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(167, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Server Stopped";
            // 
            // btnStartServer
            // 
            btnStartServer.BackColor = Color.FromArgb(0, 192, 0);
            btnStartServer.Cursor = Cursors.Hand;
            btnStartServer.FlatAppearance.BorderColor = Color.Black;
            btnStartServer.FlatStyle = FlatStyle.Flat;
            btnStartServer.Font = new Font("Inter", 9F);
            btnStartServer.ForeColor = SystemColors.ButtonHighlight;
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
            btnStopServer.BackColor = Color.Red;
            btnStopServer.Cursor = Cursors.Hand;
            btnStopServer.Enabled = false;
            btnStopServer.FlatAppearance.BorderColor = Color.Black;
            btnStopServer.FlatStyle = FlatStyle.Flat;
            btnStopServer.Font = new Font("Inter", 9F);
            btnStopServer.ForeColor = SystemColors.ButtonHighlight;
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
            txtServerUrl.BackColor = Color.FromArgb(64, 64, 64);
            txtServerUrl.BorderStyle = BorderStyle.FixedSingle;
            txtServerUrl.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServerUrl.ForeColor = SystemColors.Info;
            txtServerUrl.Location = new Point(13, 85);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.ReadOnly = true;
            txtServerUrl.Size = new Size(603, 27);
            txtServerUrl.TabIndex = 3;
            // 
            // lstFiles
            // 
            lstFiles.BackColor = Color.FromArgb(64, 64, 64);
            lstFiles.BorderStyle = BorderStyle.FixedSingle;
            lstFiles.Font = new Font("Inter", 12F);
            lstFiles.ForeColor = SystemColors.InactiveBorder;
            lstFiles.FormattingEnabled = true;
            lstFiles.HorizontalScrollbar = true;
            lstFiles.Location = new Point(13, 123);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(603, 302);
            lstFiles.TabIndex = 4;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.BackColor = Color.FromArgb(64, 64, 64);
            btnDeleteFile.Cursor = Cursors.Hand;
            btnDeleteFile.FlatStyle = FlatStyle.Flat;
            btnDeleteFile.Font = new Font("Inter", 9F);
            btnDeleteFile.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteFile.Location = new Point(210, 12);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(93, 33);
            btnDeleteFile.TabIndex = 5;
            btnDeleteFile.Text = "Delete File";
            btnDeleteFile.UseVisualStyleBackColor = false;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnCopyLink
            // 
            btnCopyLink.BackColor = Color.FromArgb(64, 64, 64);
            btnCopyLink.Cursor = Cursors.Hand;
            btnCopyLink.FlatStyle = FlatStyle.Flat;
            btnCopyLink.Font = new Font("Inter", 9F);
            btnCopyLink.ForeColor = SystemColors.ButtonHighlight;
            btnCopyLink.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopyLink.Location = new Point(111, 51);
            btnCopyLink.Name = "btnCopyLink";
            btnCopyLink.Size = new Size(93, 23);
            btnCopyLink.TabIndex = 6;
            btnCopyLink.Text = "Copy";
            btnCopyLink.UseVisualStyleBackColor = false;
            btnCopyLink.Click += btnCopyLink_Click;
            // 
            // btnOpenBrowser
            // 
            btnOpenBrowser.BackColor = Color.FromArgb(64, 64, 64);
            btnOpenBrowser.Cursor = Cursors.Hand;
            btnOpenBrowser.FlatStyle = FlatStyle.Flat;
            btnOpenBrowser.Font = new Font("Inter", 9F);
            btnOpenBrowser.ForeColor = SystemColors.ButtonHighlight;
            btnOpenBrowser.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenBrowser.Location = new Point(13, 51);
            btnOpenBrowser.Name = "btnOpenBrowser";
            btnOpenBrowser.Size = new Size(92, 23);
            btnOpenBrowser.TabIndex = 7;
            btnOpenBrowser.Text = "Open";
            btnOpenBrowser.UseVisualStyleBackColor = false;
            btnOpenBrowser.Click += btnOpenBrowser_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(64, 64, 64);
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Inter", 9F);
            btnDeleteAll.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(309, 12);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(93, 33);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "Delete all";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnShowQR
            // 
            btnShowQR.BackColor = Color.FromArgb(64, 64, 64);
            btnShowQR.Cursor = Cursors.Hand;
            btnShowQR.FlatStyle = FlatStyle.Flat;
            btnShowQR.Font = new Font("Inter", 9F);
            btnShowQR.ForeColor = SystemColors.ButtonHighlight;
            btnShowQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowQR.Location = new Point(212, 51);
            btnShowQR.Name = "btnShowQR";
            btnShowQR.Size = new Size(91, 23);
            btnShowQR.TabIndex = 9;
            btnShowQR.Text = "Show QR";
            btnShowQR.UseVisualStyleBackColor = false;
            btnShowQR.Click += btnShowQR_Click;
            // 
            // pbQRCode
            // 
            pbQRCode.BorderStyle = BorderStyle.FixedSingle;
            pbQRCode.Location = new Point(0, -1);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(294, 302);
            pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQRCode.TabIndex = 10;
            pbQRCode.TabStop = false;
            pbQRCode.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pbQRCode);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(638, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 302);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(106, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 88);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Inter", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 183);
            label1.Margin = new Padding(100, 0, 100, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15);
            label1.Size = new Size(294, 116);
            label1.TabIndex = 12;
            label1.Text = "QR will appear here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(639, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter", 9F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(309, 51);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 18;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 20F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(745, 32);
            label3.Name = "label3";
            label3.Size = new Size(189, 33);
            label3.TabIndex = 16;
            label3.Text = "LANFileShare";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 15F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(757, 65);
            label5.Name = "label5";
            label5.Size = new Size(192, 24);
            label5.TabIndex = 17;
            label5.Text = "by tk_dev Software";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 428);
            label2.Name = "label2";
            label2.Size = new Size(438, 20);
            label2.TabIndex = 19;
            label2.Text = "LANFileShare V2.0, Copyright (c) 2026 Annabeth Kisling";
            // 
            // LANFileShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(960, 457);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label3);
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
            MaximumSize = new Size(980, 500);
            MinimumSize = new Size(980, 500);
            Name = "LANFileShare";
            RightToLeft = RightToLeft.No;
            Text = "LANFileShare";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
        private Button button1;
        private Label label3;
        private Label label5;
        private Label label2;
    }
}
