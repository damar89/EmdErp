namespace NetSatis.BackOffice.Fiş
{
    partial class frmFaturaGonder
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
            this.gridContFisler = new DevExpress.XtraGrid.GridControl();
            this.gridFisler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVDahil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsChkKdvDahil = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridContFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsChkKdvDahil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridContFisler
            // 
            this.gridContFisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContFisler.Location = new System.Drawing.Point(0, 0);
            this.gridContFisler.MainView = this.gridFisler;
            this.gridContFisler.Name = "gridContFisler";
            this.gridContFisler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsChkKdvDahil});
            this.gridContFisler.Size = new System.Drawing.Size(933, 359);
            this.gridContFisler.TabIndex = 1;
            this.gridContFisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFisler});
            // 
            // gridFisler
            // 
            this.gridFisler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colVadeTarihi,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani1,
            this.colIskontoOrani2,
            this.colIskontoOrani3,
            this.colIskontoTutari1,
            this.colIskontoTutari2,
            this.colIskontoTutari3,
            this.colToplamTutar,
            this.colAciklama,
            this.colKDVDahil,
            this.colTipi,
            this.colSeri,
            this.colSira,
            this.colDurum});
            this.gridFisler.GridControl = this.gridContFisler;
            this.gridFisler.Name = "gridFisler";
            this.gridFisler.OptionsView.ShowAutoFilterRow = true;
            this.gridFisler.OptionsView.ShowFooter = true;
            this.gridFisler.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTarih, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colFisKodu.Width = 72;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 83;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "Cari.CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 4;
            this.colCariKodu.Width = 83;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "Cari.CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 5;
            this.colCariAdi.Width = 117;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 6;
            this.colBelgeNo.Width = 79;
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
            this.colTarih.VisibleIndex = 7;
            this.colTarih.Width = 79;
            // 
            // colVadeTarihi
            // 
            this.colVadeTarihi.Caption = "Vade Tarihi";
            this.colVadeTarihi.DisplayFormat.FormatString = "d";
            this.colVadeTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVadeTarihi.FieldName = "VadeTarihi";
            this.colVadeTarihi.Name = "colVadeTarihi";
            this.colVadeTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Width = 70;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.Caption = "Plasiyer Kodu";
            this.colPlasiyerKodu.FieldName = "Personel.PersonelKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            this.colPlasiyerKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colPlasiyerAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlasiyerAdi.Caption = "Plasiye Adı";
            this.colPlasiyerAdi.FieldName = "Personel.PersonelAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            this.colPlasiyerAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colPlasiyerAdi.Width = 80;
            // 
            // colIskontoOrani1
            // 
            this.colIskontoOrani1.Caption = "İskonto";
            this.colIskontoOrani1.FieldName = "IskontoOrani1";
            this.colIskontoOrani1.Name = "colIskontoOrani1";
            this.colIskontoOrani1.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani1.OptionsColumn.ShowInCustomizationForm = false;
            this.colIskontoOrani1.Visible = true;
            this.colIskontoOrani1.VisibleIndex = 9;
            this.colIskontoOrani1.Width = 53;
            // 
            // colIskontoOrani2
            // 
            this.colIskontoOrani2.FieldName = "IskontoOrani2";
            this.colIskontoOrani2.Name = "colIskontoOrani2";
            this.colIskontoOrani2.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoOrani3
            // 
            this.colIskontoOrani3.FieldName = "IskontoOrani3";
            this.colIskontoOrani3.Name = "colIskontoOrani3";
            this.colIskontoOrani3.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoTutari1
            // 
            this.colIskontoTutari1.Caption = "İskonto Tutar";
            this.colIskontoTutari1.DisplayFormat.FormatString = "C2";
            this.colIskontoTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoTutari1.FieldName = "IskontoTutari1";
            this.colIskontoTutari1.Name = "colIskontoTutari1";
            this.colIskontoTutari1.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari1.OptionsColumn.ShowInCustomizationForm = false;
            this.colIskontoTutari1.Visible = true;
            this.colIskontoTutari1.VisibleIndex = 10;
            this.colIskontoTutari1.Width = 85;
            // 
            // colIskontoTutari2
            // 
            this.colIskontoTutari2.FieldName = "IskontoTutari2";
            this.colIskontoTutari2.Name = "colIskontoTutari2";
            this.colIskontoTutari2.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoTutari3
            // 
            this.colIskontoTutari3.FieldName = "IskontoTutari3";
            this.colIskontoTutari3.Name = "colIskontoTutari3";
            this.colIskontoTutari3.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            this.colToplamTutar.Width = 108;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 96;
            // 
            // colKDVDahil
            // 
            this.colKDVDahil.Caption = "KDV Dahil";
            this.colKDVDahil.ColumnEdit = this.rpsChkKdvDahil;
            this.colKDVDahil.FieldName = "KDVDahil";
            this.colKDVDahil.Name = "colKDVDahil";
            this.colKDVDahil.OptionsColumn.AllowEdit = false;
            // 
            // rpsChkKdvDahil
            // 
            this.rpsChkKdvDahil.AutoHeight = false;
            this.rpsChkKdvDahil.Name = "rpsChkKdvDahil";
            // 
            // colTipi
            // 
            this.colTipi.Caption = "Tipi";
            this.colTipi.FieldName = "Tipi";
            this.colTipi.Name = "colTipi";
            this.colTipi.OptionsColumn.AllowEdit = false;
            this.colTipi.Visible = true;
            this.colTipi.VisibleIndex = 12;
            // 
            // colSeri
            // 
            this.colSeri.Caption = "Evrak Seri";
            this.colSeri.FieldName = "Seri";
            this.colSeri.Name = "colSeri";
            this.colSeri.Visible = true;
            this.colSeri.VisibleIndex = 2;
            // 
            // colSira
            // 
            this.colSira.Caption = "Evrak Sıra";
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 3;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durumu";
            this.colDurum.FieldName = "Durumu";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGonder);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 359);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(933, 57);
            this.groupControl1.TabIndex = 8;
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonder.ImageOptions.ImageIndex = 0;
            this.btnGonder.Location = new System.Drawing.Point(702, 24);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(135, 31);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Faturaları Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.Location = new System.Drawing.Point(843, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.Location = new System.Drawing.Point(843, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // frmFaturaGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 416);
            this.Controls.Add(this.gridContFisler);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmFaturaGonder";
            this.Text = "frmFaturaGonder";
            this.Load += new System.EventHandler(this.frmFaturaGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsChkKdvDahil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContFisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFisler;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani1;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani2;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani3;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari1;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari2;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari3;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVDahil;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rpsChkKdvDahil;
        private DevExpress.XtraGrid.Columns.GridColumn colTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeri;
        private DevExpress.XtraGrid.Columns.GridColumn colSira;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
    }
}