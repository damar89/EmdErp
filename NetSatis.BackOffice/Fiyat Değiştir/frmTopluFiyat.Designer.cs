namespace NetSatis.BackOffice.Fiyat_Değiştir
{
    partial class frmTopluFiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopluFiyat));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFiyatDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnaGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPozisyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSezonYil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantiSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinmumStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxmumStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyat4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebBayiSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnFiyatDegistir);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnCikar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 456);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1131, 62);
            this.groupControl1.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 7;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1041, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 36);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            this.ımageList1.Images.SetKeyName(3, "stok çıkar.png");
            this.ımageList1.Images.SetKeyName(4, "Stok Ekle.png");
            this.ımageList1.Images.SetKeyName(5, "view.png");
            this.ımageList1.Images.SetKeyName(6, "money2_edit.png");
            this.ımageList1.Images.SetKeyName(7, "içıkış.png");
            this.ımageList1.Images.SetKeyName(8, "igüncelle.png");
            this.ımageList1.Images.SetKeyName(9, "ikaydet.png");
            this.ımageList1.Images.SetKeyName(10, "iekle.png");
            // 
            // btnFiyatDegistir
            // 
            this.btnFiyatDegistir.ImageOptions.ImageIndex = 6;
            this.btnFiyatDegistir.ImageOptions.ImageList = this.ımageList1;
            this.btnFiyatDegistir.Location = new System.Drawing.Point(188, 24);
            this.btnFiyatDegistir.Name = "btnFiyatDegistir";
            this.btnFiyatDegistir.Size = new System.Drawing.Size(105, 36);
            this.btnFiyatDegistir.TabIndex = 5;
            this.btnFiyatDegistir.Text = "Fiyat \r\nDeğiştir";
            this.btnFiyatDegistir.Click += new System.EventHandler(this.btnFiyatDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.ImageIndex = 9;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(299, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Değişiklikleri\r\nKaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 10;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(5, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 8;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(410, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 36);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.ImageOptions.ImageIndex = 3;
            this.btnCikar.ImageOptions.ImageList = this.ımageList1;
            this.btnCikar.Location = new System.Drawing.Point(96, 23);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(85, 36);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1131, 456);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodu,
            this.colBarkodTuru,
            this.colBirim,
            this.colKategori,
            this.colAnaGrup,
            this.colAltGrup,
            this.colMarka,
            this.colUretici,
            this.colModeli,
            this.colProje,
            this.colPozisyon,
            this.colSezonYil,
            this.colOzelKodu,
            this.colGarantiSuresi,
            this.colAlisKdv,
            this.colSatisKdv,
            this.colAlisFiyati1,
            this.colAlisFiyati2,
            this.colAlisFiyati3,
            this.colSatisFiyati1,
            this.colSatisFiyati2,
            this.colSatisFiyati3,
            this.colMinmumStokMiktari,
            this.colMaxmumStokMiktari,
            this.colAciklama,
            this.colSatisFiyat4,
            this.colWebSatisFiyati,
            this.colWebBayiSatisFiyati});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Width = 65;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 108;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 219;
            // 
            // colBarkodu
            // 
            this.colBarkodu.Caption = "Barkodu";
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.OptionsColumn.AllowEdit = false;
            this.colBarkodu.Width = 105;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Width = 57;
            // 
            // colKategori
            // 
            this.colKategori.Caption = "Kategori";
            this.colKategori.FieldName = "Kategori";
            this.colKategori.Name = "colKategori";
            this.colKategori.OptionsColumn.AllowEdit = false;
            this.colKategori.Width = 59;
            // 
            // colAnaGrup
            // 
            this.colAnaGrup.Caption = "Ana Grup";
            this.colAnaGrup.FieldName = "AnaGrup";
            this.colAnaGrup.Name = "colAnaGrup";
            this.colAnaGrup.OptionsColumn.AllowEdit = false;
            this.colAnaGrup.Width = 83;
            // 
            // colAltGrup
            // 
            this.colAltGrup.Caption = "Alt Grup";
            this.colAltGrup.FieldName = "AltGrup";
            this.colAltGrup.Name = "colAltGrup";
            this.colAltGrup.OptionsColumn.AllowEdit = false;
            this.colAltGrup.Width = 82;
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            this.colMarka.Width = 84;
            // 
            // colUretici
            // 
            this.colUretici.Caption = "Uretici";
            this.colUretici.FieldName = "Uretici";
            this.colUretici.Name = "colUretici";
            this.colUretici.OptionsColumn.AllowEdit = false;
            this.colUretici.Width = 67;
            // 
            // colModeli
            // 
            this.colModeli.Caption = "Model";
            this.colModeli.FieldName = "Modeli";
            this.colModeli.Name = "colModeli";
            this.colModeli.OptionsColumn.AllowEdit = false;
            this.colModeli.Width = 67;
            // 
            // colProje
            // 
            this.colProje.Caption = "Proje Kodu";
            this.colProje.FieldName = "Proje";
            this.colProje.Name = "colProje";
            this.colProje.OptionsColumn.AllowEdit = false;
            this.colProje.Width = 85;
            // 
            // colPozisyon
            // 
            this.colPozisyon.Caption = "Pozisyon";
            this.colPozisyon.FieldName = "Pozisyon";
            this.colPozisyon.Name = "colPozisyon";
            this.colPozisyon.OptionsColumn.AllowEdit = false;
            // 
            // colSezonYil
            // 
            this.colSezonYil.Caption = "Sezon Yıl";
            this.colSezonYil.FieldName = "SezonYil";
            this.colSezonYil.Name = "colSezonYil";
            this.colSezonYil.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKodu
            // 
            this.colOzelKodu.Caption = "Özel Kod";
            this.colOzelKodu.FieldName = "OzelKodu";
            this.colOzelKodu.Name = "colOzelKodu";
            this.colOzelKodu.OptionsColumn.AllowEdit = false;
            // 
            // colGarantiSuresi
            // 
            this.colGarantiSuresi.Caption = "G.Süresi";
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            this.colGarantiSuresi.OptionsColumn.AllowEdit = false;
            // 
            // colAlisKdv
            // 
            this.colAlisKdv.Caption = "Alış Kdv";
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            this.colAlisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.Caption = "Kdv";
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            this.colSatisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyati1
            // 
            this.colAlisFiyati1.Caption = "Alış Fiyatı-1";
            this.colAlisFiyati1.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati1.FieldName = "AlisFiyati1";
            this.colAlisFiyati1.Name = "colAlisFiyati1";
            this.colAlisFiyati1.Visible = true;
            this.colAlisFiyati1.VisibleIndex = 2;
            this.colAlisFiyati1.Width = 85;
            // 
            // colAlisFiyati2
            // 
            this.colAlisFiyati2.Caption = "Alış Fiyatı-2";
            this.colAlisFiyati2.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati2.FieldName = "AlisFiyati2";
            this.colAlisFiyati2.Name = "colAlisFiyati2";
            this.colAlisFiyati2.Width = 70;
            // 
            // colAlisFiyati3
            // 
            this.colAlisFiyati3.Caption = "Alış Fiyatı-3";
            this.colAlisFiyati3.DisplayFormat.FormatString = "C2";
            this.colAlisFiyati3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati3.FieldName = "AlisFiyati3";
            this.colAlisFiyati3.Name = "colAlisFiyati3";
            this.colAlisFiyati3.Width = 70;
            // 
            // colSatisFiyati1
            // 
            this.colSatisFiyati1.Caption = "Satış Fiyatı-1";
            this.colSatisFiyati1.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati1.FieldName = "SatisFiyati1";
            this.colSatisFiyati1.Name = "colSatisFiyati1";
            this.colSatisFiyati1.Visible = true;
            this.colSatisFiyati1.VisibleIndex = 3;
            this.colSatisFiyati1.Width = 106;
            // 
            // colSatisFiyati2
            // 
            this.colSatisFiyati2.Caption = "Satış Fiyatı-2";
            this.colSatisFiyati2.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati2.FieldName = "SatisFiyati2";
            this.colSatisFiyati2.Name = "colSatisFiyati2";
            this.colSatisFiyati2.Visible = true;
            this.colSatisFiyati2.VisibleIndex = 4;
            this.colSatisFiyati2.Width = 85;
            // 
            // colSatisFiyati3
            // 
            this.colSatisFiyati3.Caption = "Satış Fiyatı-3";
            this.colSatisFiyati3.DisplayFormat.FormatString = "C2";
            this.colSatisFiyati3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati3.FieldName = "SatisFiyati3";
            this.colSatisFiyati3.Name = "colSatisFiyati3";
            this.colSatisFiyati3.Visible = true;
            this.colSatisFiyati3.VisibleIndex = 5;
            this.colSatisFiyati3.Width = 100;
            // 
            // colMinmumStokMiktari
            // 
            this.colMinmumStokMiktari.Caption = "Min. Miktar";
            this.colMinmumStokMiktari.FieldName = "MinmumStokMiktari";
            this.colMinmumStokMiktari.Name = "colMinmumStokMiktari";
            this.colMinmumStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colMaxmumStokMiktari
            // 
            this.colMaxmumStokMiktari.Caption = "Max.Miktar";
            this.colMaxmumStokMiktari.FieldName = "MaxmumStokMiktari";
            this.colMaxmumStokMiktari.Name = "colMaxmumStokMiktari";
            this.colMaxmumStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyat4
            // 
            this.colSatisFiyat4.Caption = "Satış Fiyat-4";
            this.colSatisFiyat4.DisplayFormat.FormatString = "C2";
            this.colSatisFiyat4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyat4.FieldName = "SatisFiyati4";
            this.colSatisFiyat4.Name = "colSatisFiyat4";
            this.colSatisFiyat4.Visible = true;
            this.colSatisFiyat4.VisibleIndex = 6;
            this.colSatisFiyat4.Width = 91;
            // 
            // colWebSatisFiyati
            // 
            this.colWebSatisFiyati.Caption = "Web Satiş Fiyati";
            this.colWebSatisFiyati.DisplayFormat.FormatString = "C2";
            this.colWebSatisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWebSatisFiyati.FieldName = "WebSatisFiyati";
            this.colWebSatisFiyati.Name = "colWebSatisFiyati";
            this.colWebSatisFiyati.Visible = true;
            this.colWebSatisFiyati.VisibleIndex = 7;
            this.colWebSatisFiyati.Width = 91;
            // 
            // colWebBayiSatisFiyati
            // 
            this.colWebBayiSatisFiyati.Caption = "Web Bayi Satiş Fiyati";
            this.colWebBayiSatisFiyati.DisplayFormat.FormatString = "C2";
            this.colWebBayiSatisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWebBayiSatisFiyati.FieldName = "WebBayiSatisFiyati";
            this.colWebBayiSatisFiyati.Name = "colWebBayiSatisFiyati";
            this.colWebBayiSatisFiyati.Visible = true;
            this.colWebBayiSatisFiyati.VisibleIndex = 8;
            this.colWebBayiSatisFiyati.Width = 102;
            // 
            // frmTopluFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 518);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmTopluFiyat";
            this.ShowIcon = false;
            this.Text = "Toplu Fiyat Değişikliği";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTopluFiyat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colAnaGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colAltGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colUretici;
        private DevExpress.XtraGrid.Columns.GridColumn colModeli;
        private DevExpress.XtraGrid.Columns.GridColumn colProje;
        private DevExpress.XtraGrid.Columns.GridColumn colPozisyon;
        private DevExpress.XtraGrid.Columns.GridColumn colSezonYil;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantiSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinmumStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxmumStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.SimpleButton btnFiyatDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyat4;
        private DevExpress.XtraGrid.Columns.GridColumn colWebSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colWebBayiSatisFiyati;
    }
}