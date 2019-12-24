namespace NetSatis.BackOffice.Personel
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPersonelHareket = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnHakedis = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFltKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContPersonel = new DevExpress.XtraGrid.GridControl();
            this.gridPersonel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalisiyor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstenCikisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAylikMaasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPersonelHareket);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.btnHakedis);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 447);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(976, 57);
            this.groupControl1.TabIndex = 7;
            // 
            // btnPersonelHareket
            // 
            this.btnPersonelHareket.ImageOptions.ImageIndex = 7;
            this.btnPersonelHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnPersonelHareket.Location = new System.Drawing.Point(514, 23);
            this.btnPersonelHareket.Name = "btnPersonelHareket";
            this.btnPersonelHareket.Size = new System.Drawing.Size(85, 31);
            this.btnPersonelHareket.TabIndex = 6;
            this.btnPersonelHareket.Text = "Personel\r\nHareketi";
            this.btnPersonelHareket.Click += new System.EventHandler(this.btnPersonelHareket_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "folder_out.png");
            this.imgMenu.Images.SetKeyName(1, "funnel.png");
            this.imgMenu.Images.SetKeyName(2, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(3, "refresh.png");
            this.imgMenu.Images.SetKeyName(4, "view.png");
            this.imgMenu.Images.SetKeyName(5, "düzenle.png");
            this.imgMenu.Images.SetKeyName(6, "Ekle.png");
            this.imgMenu.Images.SetKeyName(7, "hareket.png");
            this.imgMenu.Images.SetKeyName(8, "sil.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(886, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 4;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(696, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 31);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnHakedis
            // 
            this.btnHakedis.ImageOptions.ImageIndex = 3;
            this.btnHakedis.Location = new System.Drawing.Point(787, 23);
            this.btnHakedis.Name = "btnHakedis";
            this.btnHakedis.Size = new System.Drawing.Size(85, 31);
            this.btnHakedis.TabIndex = 5;
            this.btnHakedis.Text = "Maaş - Pirim";
            this.btnHakedis.Click += new System.EventHandler(this.btnHakedis_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(605, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 6;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(239, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 8;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(421, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 5;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(330, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(85, 31);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.ImageList = this.imgMenu;
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
            this.lblBaslik.Size = new System.Drawing.Size(976, 32);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Personel Kartları";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 32);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFltKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreTemizle);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContPersonel);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(976, 415);
            this.splitContainerControl1.SplitterPosition = 41;
            this.splitContainerControl1.TabIndex = 8;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFltKapat
            // 
            this.btnFltKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFltKapat.ImageOptions.ImageIndex = 0;
            this.btnFltKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnFltKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFltKapat.Location = new System.Drawing.Point(924, 3);
            this.btnFltKapat.Name = "btnFltKapat";
            this.btnFltKapat.Size = new System.Drawing.Size(47, 33);
            this.btnFltKapat.TabIndex = 1;
            this.btnFltKapat.Click += new System.EventHandler(this.btnFltKapat_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 1;
            this.btnFiltrele.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltrele.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(824, 4);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(47, 33);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnFiltreTemizle
            // 
            this.btnFiltreTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreTemizle.ImageOptions.ImageIndex = 2;
            this.btnFiltreTemizle.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreTemizle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreTemizle.Location = new System.Drawing.Point(874, 4);
            this.btnFiltreTemizle.Name = "btnFiltreTemizle";
            this.btnFiltreTemizle.Size = new System.Drawing.Size(47, 33);
            this.btnFiltreTemizle.TabIndex = 1;
            this.btnFiltreTemizle.Click += new System.EventHandler(this.btnFiltreTemizle_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(976, 41);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContPersonel;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContPersonel
            // 
            this.gridContPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContPersonel.Location = new System.Drawing.Point(0, 0);
            this.gridContPersonel.MainView = this.gridPersonel;
            this.gridContPersonel.Name = "gridContPersonel";
            this.gridContPersonel.Size = new System.Drawing.Size(976, 368);
            this.gridContPersonel.TabIndex = 0;
            this.gridContPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPersonel});
            // 
            // gridPersonel
            // 
            this.gridPersonel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCalisiyor,
            this.colUnvani,
            this.colPersonelKodu,
            this.colPersonelAdi,
            this.colTcKimlikNo,
            this.colIseGirisTarihi,
            this.colIstenCikisTarihi,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEmail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colPrimOrani,
            this.colAylikMaasi,
            this.colAciklama,
            this.colToplamSatis,
            this.colPrimTutar});
            this.gridPersonel.GridControl = this.gridContPersonel;
            this.gridPersonel.Name = "gridPersonel";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colCalisiyor
            // 
            this.colCalisiyor.Caption = "Çalışıyor";
            this.colCalisiyor.FieldName = "Calisiyor";
            this.colCalisiyor.Name = "colCalisiyor";
            this.colCalisiyor.OptionsColumn.AllowEdit = false;
            this.colCalisiyor.Visible = true;
            this.colCalisiyor.VisibleIndex = 0;
            this.colCalisiyor.Width = 61;
            // 
            // colUnvani
            // 
            this.colUnvani.Caption = "Ünvanı";
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.OptionsColumn.AllowEdit = false;
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 1;
            this.colUnvani.Width = 61;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 2;
            this.colPersonelAdi.Width = 61;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Width = 61;
            // 
            // colIseGirisTarihi
            // 
            this.colIseGirisTarihi.Caption = "İşe Giriş Tarihi";
            this.colIseGirisTarihi.DisplayFormat.FormatString = "d";
            this.colIseGirisTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIseGirisTarihi.FieldName = "IseGirisTarihi";
            this.colIseGirisTarihi.Name = "colIseGirisTarihi";
            this.colIseGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colIseGirisTarihi.Visible = true;
            this.colIseGirisTarihi.VisibleIndex = 3;
            this.colIseGirisTarihi.Width = 85;
            // 
            // colIstenCikisTarihi
            // 
            this.colIstenCikisTarihi.Caption = "İşten Çıkış Tarihi";
            this.colIstenCikisTarihi.DisplayFormat.FormatString = "d";
            this.colIstenCikisTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIstenCikisTarihi.FieldName = "IstenCikisTarihi";
            this.colIstenCikisTarihi.Name = "colIstenCikisTarihi";
            this.colIstenCikisTarihi.OptionsColumn.AllowEdit = false;
            this.colIstenCikisTarihi.Visible = true;
            this.colIstenCikisTarihi.VisibleIndex = 4;
            this.colIstenCikisTarihi.Width = 96;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Tel.";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 5;
            this.colCepTelefonu.Width = 51;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Width = 51;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Width = 51;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Width = 51;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Width = 51;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Width = 51;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.Caption = "Prim Oranı";
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.AllowEdit = false;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 7;
            // 
            // colAylikMaasi
            // 
            this.colAylikMaasi.Caption = "Aylık Maaş";
            this.colAylikMaasi.FieldName = "AylikMaasi";
            this.colAylikMaasi.Name = "colAylikMaasi";
            this.colAylikMaasi.OptionsColumn.AllowEdit = false;
            this.colAylikMaasi.Visible = true;
            this.colAylikMaasi.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 68;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.DisplayFormat.FormatString = "C2";
            this.colToplamSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.OptionsColumn.AllowEdit = false;
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 9;
            // 
            // colPrimTutar
            // 
            this.colPrimTutar.Caption = "Prim Tutar";
            this.colPrimTutar.DisplayFormat.FormatString = "C2";
            this.colPrimTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimTutar.FieldName = "PrimTutar";
            this.colPrimTutar.Name = "colPrimTutar";
            this.colPrimTutar.OptionsColumn.AllowEdit = false;
            this.colPrimTutar.Visible = true;
            this.colPrimTutar.VisibleIndex = 10;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 504);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmPersonel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kartları";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFltKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.SimpleButton btnFiltreTemizle;
        private DevExpress.XtraGrid.GridControl gridContPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyor;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIstenCikisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAylikMaasi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimTutar;
        private DevExpress.XtraEditors.SimpleButton btnPersonelHareket;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnHakedis;
    }
}