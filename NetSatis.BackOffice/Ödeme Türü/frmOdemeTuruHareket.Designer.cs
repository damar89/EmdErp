﻿namespace NetSatis.BackOffice.Ödeme_Türü
{
    partial class frmOdemeTuruHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeTuruHareket));
            this.gridContKasaBakiye = new DevExpress.XtraGrid.GridControl();
            this.gridKasaBakiye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKasaKodu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridContGenelToplam = new DevExpress.XtraGrid.GridControl();
            this.gridGenelToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitSsyisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridKasaHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridContKasaBakiye
            // 
            this.gridContKasaBakiye.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridContKasaBakiye.Location = new System.Drawing.Point(2, 20);
            this.gridContKasaBakiye.MainView = this.gridKasaBakiye;
            this.gridContKasaBakiye.Name = "gridContKasaBakiye";
            this.gridContKasaBakiye.Size = new System.Drawing.Size(455, 191);
            this.gridContKasaBakiye.TabIndex = 2;
            this.gridContKasaBakiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaBakiye});
            // 
            // gridKasaBakiye
            // 
            this.gridKasaBakiye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKasaKodu1,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye,
            this.colKasaAdi1});
            this.gridKasaBakiye.GridControl = this.gridContKasaBakiye;
            this.gridKasaBakiye.Name = "gridKasaBakiye";
            this.gridKasaBakiye.OptionsView.ShowGroupPanel = false;
            // 
            // colKasaKodu1
            // 
            this.colKasaKodu1.Caption = "Kasa Kodu";
            this.colKasaKodu1.FieldName = "KasaKodu";
            this.colKasaKodu1.Name = "colKasaKodu1";
            this.colKasaKodu1.OptionsColumn.AllowEdit = false;
            this.colKasaKodu1.Visible = true;
            this.colKasaKodu1.VisibleIndex = 0;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 2;
            this.colKasaGiris.Width = 78;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 3;
            this.colKasaCikis.Width = 111;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 4;
            this.colBakiye.Width = 70;
            // 
            // colKasaAdi1
            // 
            this.colKasaAdi1.Caption = "Kasa Adı";
            this.colKasaAdi1.FieldName = "KasaAdi";
            this.colKasaAdi1.Name = "colKasaAdi1";
            this.colKasaAdi1.Visible = true;
            this.colKasaAdi1.VisibleIndex = 1;
            this.colKasaAdi1.Width = 105;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridContGenelToplam);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(369, 189);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Genel Toplamlar";
            // 
            // gridContGenelToplam
            // 
            this.gridContGenelToplam.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridContGenelToplam.Location = new System.Drawing.Point(2, 20);
            this.gridContGenelToplam.MainView = this.gridGenelToplam;
            this.gridContGenelToplam.Name = "gridContGenelToplam";
            this.gridContGenelToplam.Size = new System.Drawing.Size(365, 191);
            this.gridContGenelToplam.TabIndex = 2;
            this.gridContGenelToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelToplam});
            // 
            // gridGenelToplam
            // 
            this.gridGenelToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilgi,
            this.colKayitSsyisi,
            this.colToplam});
            this.gridGenelToplam.GridControl = this.gridContGenelToplam;
            this.gridGenelToplam.Name = "gridGenelToplam";
            this.gridGenelToplam.OptionsView.ShowGroupPanel = false;
            // 
            // colBilgi
            // 
            this.colBilgi.Caption = "Bilgi";
            this.colBilgi.FieldName = "Bilgi";
            this.colBilgi.Name = "colBilgi";
            this.colBilgi.OptionsColumn.AllowEdit = false;
            this.colBilgi.Visible = true;
            this.colBilgi.VisibleIndex = 0;
            this.colBilgi.Width = 199;
            // 
            // colKayitSsyisi
            // 
            this.colKayitSsyisi.Caption = "Kayıt Sayısı";
            this.colKayitSsyisi.FieldName = "KayitSayisi";
            this.colKayitSsyisi.Name = "colKayitSsyisi";
            this.colKayitSsyisi.Visible = true;
            this.colKayitSsyisi.VisibleIndex = 1;
            this.colKayitSsyisi.Width = 84;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.DisplayFormat.FormatString = "C2";
            this.colToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplam.FieldName = "Tutar";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 2;
            this.colToplam.Width = 155;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 32);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContKasaHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(833, 424);
            this.splitContainerControl1.SplitterPosition = 230;
            this.splitContainerControl1.TabIndex = 13;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridContKasaHareket
            // 
            this.gridContKasaHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridContKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContKasaHareket.MainView = this.gridKasaHareket;
            this.gridContKasaHareket.Name = "gridContKasaHareket";
            this.gridContKasaHareket.Size = new System.Drawing.Size(833, 230);
            this.gridContKasaHareket.TabIndex = 1;
            this.gridContKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaHareket});
            // 
            // gridKasaHareket
            // 
            this.gridKasaHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colCariKodu,
            this.colCariAdi,
            this.colTarih,
            this.colSaat,
            this.colTutar,
            this.colAciklama});
            this.gridKasaHareket.GridControl = this.gridContKasaHareket;
            this.gridKasaHareket.Name = "gridKasaHareket";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 95;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.OptionsColumn.ShowInCustomizationForm = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            this.colHareket.Width = 95;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "Kasa.KasaKodu";
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "Kasa.KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme Türü Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuru.OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuru.OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 2;
            this.colOdemeTuruAdi.Width = 95;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "Cari.CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 3;
            this.colCariKodu.Width = 95;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "Cari.CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 4;
            this.colCariAdi.Width = 127;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.ShowInCustomizationForm = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 87;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 6;
            this.colSaat.Width = 83;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 8;
            this.colTutar.Width = 70;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 122;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(833, 189);
            this.splitContainerControl2.SplitterPosition = 459;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContKasaBakiye);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(459, 189);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Ödeme Türlerine Göre Toplamlar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 456);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(833, 57);
            this.groupControl1.TabIndex = 12;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(743, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(101, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 31);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(9, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.BackColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseBackColor = true;
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
            this.lblBaslik.Size = new System.Drawing.Size(833, 32);
            this.lblBaslik.TabIndex = 11;
            this.lblBaslik.Text = "Ödeme Türü Hareketleri";
            // 
            // frmOdemeTuruHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 513);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmOdemeTuruHareket";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Hareketleri";
            this.Load += new System.EventHandler(this.frmOdemeTuruHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContKasaBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu1;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridContGenelToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitSsyisi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi1;
    }
}