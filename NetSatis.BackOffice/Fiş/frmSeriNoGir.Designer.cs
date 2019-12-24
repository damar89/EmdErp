namespace NetSatis.BackOffice.Fiş
{
    partial class frmSeriNoGir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeriNoGir));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupBilgi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.listSeriNo = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupBilgi)).BeginInit();
            this.groupBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSeriNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseImageList = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(457, 32);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Seri No Bilgileri";
            // 
            // groupBilgi
            // 
            this.groupBilgi.Controls.Add(this.labelControl6);
            this.groupBilgi.Controls.Add(this.txtSeriNo);
            this.groupBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBilgi.Enabled = false;
            this.groupBilgi.Location = new System.Drawing.Point(0, 32);
            this.groupBilgi.Name = "groupBilgi";
            this.groupBilgi.Size = new System.Drawing.Size(457, 94);
            this.groupBilgi.TabIndex = 8;
            this.groupBilgi.Text = "Seri No Bilgileri";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(5, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 22);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Seri No :";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeriNo.Location = new System.Drawing.Point(94, 26);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(358, 20);
            this.txtSeriNo.TabIndex = 21;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.btnVazgec);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Controls.Add(this.btnYeni);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 326);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(457, 57);
            this.grpMenu.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 4;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(368, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 31);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Kapat";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 3;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(278, 24);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(85, 31);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(187, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageOptions.ImageIndex = 0;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(5, 24);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 31);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 1;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(96, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listSeriNo
            // 
            this.listSeriNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listSeriNo.Appearance.Options.UseFont = true;
            this.listSeriNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listSeriNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSeriNo.Location = new System.Drawing.Point(0, 126);
            this.listSeriNo.Name = "listSeriNo";
            this.listSeriNo.Size = new System.Drawing.Size(457, 200);
            this.listSeriNo.TabIndex = 10;
            // 
            // frmSeriNoGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.listSeriNo);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.groupBilgi);
            this.Controls.Add(this.lblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeriNoGir";
            this.ShowIcon = false;
            this.Text = "Seri No";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeriNoGir_FormClosing);
            this.Load += new System.EventHandler(this.frmSeriNoGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBilgi)).EndInit();
            this.groupBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSeriNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupBilgi;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.ListBoxControl listSeriNo;
    }
}