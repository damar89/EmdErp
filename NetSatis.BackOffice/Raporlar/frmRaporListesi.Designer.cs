namespace NetSatis.BackOffice.Raporlar
{
    partial class frmRaporListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporListesi));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.imgMenu = new System.Windows.Forms.ImageList();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalistir = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkrptStokDurumu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkrptStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRaporAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtRaporGrubu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1003, 35);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Raporlar";
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "Cari Düzenle.png");
            this.imgMenu.Images.SetKeyName(1, "Cari Ekle.png");
            this.imgMenu.Images.SetKeyName(2, "Cari Hareket.png");
            this.imgMenu.Images.SetKeyName(3, "cari kpyala.png");
            this.imgMenu.Images.SetKeyName(4, "Cari Sil.png");
            this.imgMenu.Images.SetKeyName(5, "folder_out.png");
            this.imgMenu.Images.SetKeyName(6, "funnel.png");
            this.imgMenu.Images.SetKeyName(7, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(8, "refresh.png");
            this.imgMenu.Images.SetKeyName(9, "view.png");
            this.imgMenu.Images.SetKeyName(10, "görüntüle.png");
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnCalistir);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 394);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1003, 66);
            this.groupControl1.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 5;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(913, 32);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnCalistir
            // 
            this.btnCalistir.ImageOptions.ImageIndex = 10;
            this.btnCalistir.ImageOptions.ImageList = this.imgMenu;
            this.btnCalistir.Location = new System.Drawing.Point(5, 23);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(103, 38);
            this.btnCalistir.TabIndex = 2;
            this.btnCalistir.Text = "Raporu\r\nGörüntüle";
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.linkrptStokDurumu,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.linkrptStokHareketleri});
            this.navBarControl1.Location = new System.Drawing.Point(0, 35);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 228;
            this.navBarControl1.Size = new System.Drawing.Size(228, 359);
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok Raporları";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkrptStokDurumu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // linkrptStokDurumu
            // 
            this.linkrptStokDurumu.Caption = "Genel Stok Durumu";
            this.linkrptStokDurumu.Name = "linkrptStokDurumu";
            this.linkrptStokDurumu.Tag = "bu rapor stok giriş ve çıkış bilgilerini gösteirir";
            this.linkrptStokDurumu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Clicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Stok Listesi";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Kar Zarar Analizi";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari Raporları";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Cari Bakiye Raporu";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Stok Hareket Raporları";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkrptStokHareketleri)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // linkrptStokHareketleri
            // 
            this.linkrptStokHareketleri.Caption = "Stok Hareket";
            this.linkrptStokHareketleri.Name = "linkrptStokHareketleri";
            this.linkrptStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Clicked);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtRaporAdi);
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.txtRaporGrubu);
            this.groupControl2.Controls.Add(this.labelControl20);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(228, 35);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(775, 126);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Rapor Bilgileri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(105, 73);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(670, 48);
            this.txtAciklama.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(9, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Rapor Adı :";
            // 
            // txtRaporAdi
            // 
            this.txtRaporAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporAdi.Location = new System.Drawing.Point(106, 24);
            this.txtRaporAdi.Name = "txtRaporAdi";
            this.txtRaporAdi.Properties.ReadOnly = true;
            this.txtRaporAdi.Size = new System.Drawing.Size(669, 20);
            this.txtRaporAdi.TabIndex = 9;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl19.Appearance.Options.UseBorderColor = true;
            this.labelControl19.Appearance.Options.UseTextOptions = true;
            this.labelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl19.Location = new System.Drawing.Point(8, 48);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(91, 17);
            this.labelControl19.TabIndex = 8;
            this.labelControl19.Text = "Rapor Grubu :";
            // 
            // txtRaporGrubu
            // 
            this.txtRaporGrubu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporGrubu.Location = new System.Drawing.Point(105, 47);
            this.txtRaporGrubu.Name = "txtRaporGrubu";
            this.txtRaporGrubu.Properties.ReadOnly = true;
            this.txtRaporGrubu.Size = new System.Drawing.Size(670, 20);
            this.txtRaporGrubu.TabIndex = 9;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl20.Appearance.Options.UseBorderColor = true;
            this.labelControl20.Appearance.Options.UseTextOptions = true;
            this.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl20.Location = new System.Drawing.Point(6, 74);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(94, 46);
            this.labelControl20.TabIndex = 10;
            this.labelControl20.Text = "Açıklama :";
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(228, 161);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(775, 233);
            this.filterControl1.TabIndex = 10;
            this.filterControl1.Text = "filterControl1";
            // 
            // frmRaporListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 460);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmRaporListesi";
            this.ShowIcon = false;
            this.Text = "Rapor Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnCalistir;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem linkrptStokDurumu;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem linkrptStokHareketleri;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRaporAdi;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtRaporGrubu;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.FilterControl filterControl1;
    }
}