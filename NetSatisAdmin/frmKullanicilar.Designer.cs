namespace NetSatisAdmin
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(943, 35);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Kullanıcılar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 423);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(943, 57);
            this.groupControl1.TabIndex = 8;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(853, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "folder_out.png");
            this.imgMenu.Images.SetKeyName(1, "refresh.png");
            this.imgMenu.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(367, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 31);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(276, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.ImageOptions.ImageIndex = 1;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(5, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(187, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.ImageOptions.ImageIndex = 0;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(96, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(85, 31);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(943, 388);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullaniciAdi,
            this.colAdi,
            this.colSoyAdi,
            this.colGorevi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colCevap,
            this.colKayitTarihi,
            this.colSonGirisTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı Adı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
            this.colKullaniciAdi.Width = 154;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 163;
            // 
            // colSoyAdi
            // 
            this.colSoyAdi.Caption = "Soy Adı";
            this.colSoyAdi.FieldName = "SoyAdi";
            this.colSoyAdi.Name = "colSoyAdi";
            this.colSoyAdi.OptionsColumn.AllowEdit = false;
            this.colSoyAdi.Visible = true;
            this.colSoyAdi.VisibleIndex = 2;
            this.colSoyAdi.Width = 163;
            // 
            // colGorevi
            // 
            this.colGorevi.Caption = "Görevi";
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.OptionsColumn.AllowEdit = false;
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 3;
            this.colGorevi.Width = 124;
            // 
            // colParola
            // 
            this.colParola.Caption = "Parola";
            this.colParola.FieldName = "Parola";
            this.colParola.Name = "colParola";
            this.colParola.OptionsColumn.AllowEdit = false;
            // 
            // colHatirlatmaSorusu
            // 
            this.colHatirlatmaSorusu.Caption = "Hatırlatma Sorusu";
            this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
            this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
            this.colHatirlatmaSorusu.OptionsColumn.AllowEdit = false;
            // 
            // colCevap
            // 
            this.colCevap.Caption = "Cevap";
            this.colCevap.FieldName = "Cevap";
            this.colCevap.Name = "colCevap";
            this.colCevap.OptionsColumn.AllowEdit = false;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 4;
            this.colKayitTarihi.Width = 163;
            // 
            // colSonGirisTarihi
            // 
            this.colSonGirisTarihi.Caption = "Son Giriş Tarihi";
            this.colSonGirisTarihi.FieldName = "SonGirisTarihi";
            this.colSonGirisTarihi.Name = "colSonGirisTarihi";
            this.colSonGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colSonGirisTarihi.Visible = true;
            this.colSonGirisTarihi.VisibleIndex = 5;
            this.colSonGirisTarihi.Width = 170;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.Location = new System.Drawing.Point(458, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 31);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Alanlar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 480);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullanicilar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonGirisTarihi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

