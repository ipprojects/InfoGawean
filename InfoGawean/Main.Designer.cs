namespace InfoGawean
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBodyBackground = new System.Windows.Forms.Panel();
            this.pnlBodyContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLowongan = new System.Windows.Forms.TabPage();
            this.lbLowongan = new System.Windows.Forms.ListBox();
            this.tabLowonganFavorit = new System.Windows.Forms.TabPage();
            this.lbLowonganFavorit = new System.Windows.Forms.ListBox();
            this.pnlBodyTopMenu = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblTotalLowongan = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFavorit = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnCopyLink = new System.Windows.Forms.ToolStripButton();
            this.btnShareFB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBodyBackground.SuspendLayout();
            this.pnlBodyContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLowongan.SuspendLayout();
            this.tabLowonganFavorit.SuspendLayout();
            this.pnlBodyTopMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.textBox1);
            this.pnlHeader.Controls.Add(this.btnStop);
            this.pnlHeader.Controls.Add(this.btnScan);
            this.pnlHeader.Controls.Add(this.cbJobType);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1082, 73);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kolom cari";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(792, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 24);
            this.textBox1.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(672, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(591, 18);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 34);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cbJobType
            // 
            this.cbJobType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Items.AddRange(new object[] {
            "Perusahaan premium khusus IT"});
            this.cbJobType.Location = new System.Drawing.Point(324, 22);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(258, 26);
            this.cbJobType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Info Gawean";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // pnlBodyBackground
            // 
            this.pnlBodyBackground.Controls.Add(this.pnlBodyContent);
            this.pnlBodyBackground.Controls.Add(this.pnlBodyTopMenu);
            this.pnlBodyBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyBackground.Location = new System.Drawing.Point(0, 73);
            this.pnlBodyBackground.Name = "pnlBodyBackground";
            this.pnlBodyBackground.Size = new System.Drawing.Size(1082, 327);
            this.pnlBodyBackground.TabIndex = 2;
            // 
            // pnlBodyContent
            // 
            this.pnlBodyContent.Controls.Add(this.tabControl1);
            this.pnlBodyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyContent.Location = new System.Drawing.Point(0, 27);
            this.pnlBodyContent.Name = "pnlBodyContent";
            this.pnlBodyContent.Size = new System.Drawing.Size(1082, 300);
            this.pnlBodyContent.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLowongan);
            this.tabControl1.Controls.Add(this.tabLowonganFavorit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLowongan
            // 
            this.tabLowongan.Controls.Add(this.lbLowongan);
            this.tabLowongan.Location = new System.Drawing.Point(4, 22);
            this.tabLowongan.Name = "tabLowongan";
            this.tabLowongan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLowongan.Size = new System.Drawing.Size(1074, 274);
            this.tabLowongan.TabIndex = 0;
            this.tabLowongan.Text = "Lowongan";
            this.tabLowongan.UseVisualStyleBackColor = true;
            // 
            // lbLowongan
            // 
            this.lbLowongan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLowongan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLowongan.FormattingEnabled = true;
            this.lbLowongan.ItemHeight = 16;
            this.lbLowongan.Location = new System.Drawing.Point(3, 3);
            this.lbLowongan.Name = "lbLowongan";
            this.lbLowongan.Size = new System.Drawing.Size(1068, 268);
            this.lbLowongan.TabIndex = 0;
            this.lbLowongan.DoubleClick += new System.EventHandler(this.lbLowongan_DoubleClick);
            // 
            // tabLowonganFavorit
            // 
            this.tabLowonganFavorit.Controls.Add(this.lbLowonganFavorit);
            this.tabLowonganFavorit.Location = new System.Drawing.Point(4, 22);
            this.tabLowonganFavorit.Name = "tabLowonganFavorit";
            this.tabLowonganFavorit.Padding = new System.Windows.Forms.Padding(3);
            this.tabLowonganFavorit.Size = new System.Drawing.Size(1074, 274);
            this.tabLowonganFavorit.TabIndex = 1;
            this.tabLowonganFavorit.Text = "Lowongan Favorit";
            this.tabLowonganFavorit.UseVisualStyleBackColor = true;
            // 
            // lbLowonganFavorit
            // 
            this.lbLowonganFavorit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLowonganFavorit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLowonganFavorit.FormattingEnabled = true;
            this.lbLowonganFavorit.ItemHeight = 16;
            this.lbLowonganFavorit.Location = new System.Drawing.Point(3, 3);
            this.lbLowonganFavorit.Name = "lbLowonganFavorit";
            this.lbLowonganFavorit.Size = new System.Drawing.Size(1068, 268);
            this.lbLowonganFavorit.TabIndex = 1;
            this.lbLowonganFavorit.DoubleClick += new System.EventHandler(this.lbLowonganFavorit_DoubleClick);
            // 
            // pnlBodyTopMenu
            // 
            this.pnlBodyTopMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodyTopMenu.Controls.Add(this.checkBox1);
            this.pnlBodyTopMenu.Controls.Add(this.lblTotalLowongan);
            this.pnlBodyTopMenu.Controls.Add(this.toolStrip1);
            this.pnlBodyTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBodyTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyTopMenu.Name = "pnlBodyTopMenu";
            this.pnlBodyTopMenu.Size = new System.Drawing.Size(1082, 27);
            this.pnlBodyTopMenu.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(382, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Jalankan aplikasi pada startup";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblTotalLowongan
            // 
            this.lblTotalLowongan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLowongan.AutoSize = true;
            this.lblTotalLowongan.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalLowongan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLowongan.Location = new System.Drawing.Point(949, 3);
            this.lblTotalLowongan.Name = "lblTotalLowongan";
            this.lblTotalLowongan.Size = new System.Drawing.Size(121, 18);
            this.lblTotalLowongan.TabIndex = 5;
            this.lblTotalLowongan.Text = "Total lowongan 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFavorit,
            this.btnHapus,
            this.btnCopyLink,
            this.btnShareFB,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFavorit
            // 
            this.btnFavorit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFavorit.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorit.Image")));
            this.btnFavorit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavorit.Name = "btnFavorit";
            this.btnFavorit.Size = new System.Drawing.Size(57, 24);
            this.btnFavorit.Text = "Favorit";
            this.btnFavorit.Click += new System.EventHandler(this.btnFavorit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(55, 24);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCopyLink
            // 
            this.btnCopyLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopyLink.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyLink.Image")));
            this.btnCopyLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyLink.Name = "btnCopyLink";
            this.btnCopyLink.Size = new System.Drawing.Size(77, 24);
            this.btnCopyLink.Text = "Copy Link";
            this.btnCopyLink.Click += new System.EventHandler(this.btnCopyLink_Click);
            // 
            // btnShareFB
            // 
            this.btnShareFB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShareFB.Image = ((System.Drawing.Image)(resources.GetObject("btnShareFB.Image")));
            this.btnShareFB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShareFB.Name = "btnShareFB";
            this.btnShareFB.Size = new System.Drawing.Size(70, 24);
            this.btnShareFB.Text = "Share FB";
            this.btnShareFB.Click += new System.EventHandler(this.btnShareFB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(95, 24);
            this.toolStripButton5.Text = "Refresh Jobs";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 422);
            this.Controls.Add(this.pnlBodyBackground);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBodyBackground.ResumeLayout(false);
            this.pnlBodyContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLowongan.ResumeLayout(false);
            this.tabLowonganFavorit.ResumeLayout(false);
            this.pnlBodyTopMenu.ResumeLayout(false);
            this.pnlBodyTopMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlBodyBackground;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pnlBodyContent;
        private System.Windows.Forms.Panel pnlBodyTopMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFavorit;
        private System.Windows.Forms.ToolStripButton btnHapus;
        private System.Windows.Forms.ToolStripButton btnCopyLink;
        private System.Windows.Forms.ToolStripButton btnShareFB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblTotalLowongan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLowongan;
        private System.Windows.Forms.TabPage tabLowonganFavorit;
        private System.Windows.Forms.ListBox lbLowongan;
        private System.Windows.Forms.ListBox lbLowonganFavorit;
        private System.Windows.Forms.Label label2;
    }
}

