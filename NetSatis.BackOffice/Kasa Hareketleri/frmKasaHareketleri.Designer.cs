namespace NetSatis.BackOffice.Kasa_Hareketleri
{
    partial class frmKasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketleri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDetayGor = new DevExpress.XtraEditors.SimpleButton();
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
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnDetayGor);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 413);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(984, 68);
            this.groupControl1.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(894, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 39);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "içıkış.png");
            this.ımageList1.Images.SetKeyName(1, "idüzenle.png");
            // 
            // btnDetayGor
            // 
            this.btnDetayGor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetayGor.ImageOptions.ImageIndex = 1;
            this.btnDetayGor.ImageOptions.ImageList = this.ımageList1;
            this.btnDetayGor.Location = new System.Drawing.Point(790, 27);
            this.btnDetayGor.Name = "btnDetayGor";
            this.btnDetayGor.Size = new System.Drawing.Size(98, 37);
            this.btnDetayGor.TabIndex = 5;
            this.btnDetayGor.Text = "Detay Gör";
            this.btnDetayGor.Click += new System.EventHandler(this.btnDetayGor_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContKasaHareket);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.splitContainerControl1.Size = new System.Drawing.Size(984, 481);
            this.splitContainerControl1.SplitterPosition = 42;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridContKasaHareket
            // 
            this.gridContKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContKasaHareket.MainView = this.gridKasaHareket;
            this.gridContKasaHareket.Name = "gridContKasaHareket";
            this.gridContKasaHareket.Size = new System.Drawing.Size(984, 413);
            this.gridContKasaHareket.TabIndex = 9;
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
            this.colTarih,
            this.colTutar,
            this.colAciklama,
            this.colVadeTarihi,
            this.colFisTuru});
            this.gridKasaHareket.GridControl = this.gridContKasaHareket;
            this.gridKasaHareket.Name = "gridKasaHareket";
            this.gridKasaHareket.OptionsView.RowAutoHeight = true;
            this.gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            this.gridKasaHareket.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridKasaHareket.OptionsView.ShowFooter = true;
            this.gridKasaHareket.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
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
            this.colFisKodu.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colFisKodu.AppearanceHeader.Options.UseBackColor = true;
            this.colFisKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colFisKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 112;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.OptionsColumn.ShowInCustomizationForm = false;
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
            this.colKasaAdi.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colKasaAdi.AppearanceHeader.Options.UseBackColor = true;
            this.colKasaAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colKasaAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "Kasa.KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaAdi.Width = 122;
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
            this.colOdemeTuruAdi.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colOdemeTuruAdi.AppearanceHeader.Options.UseBackColor = true;
            this.colOdemeTuruAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colOdemeTuruAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuru.OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 2;
            this.colOdemeTuruAdi.Width = 154;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colTarih.AppearanceHeader.Options.UseBackColor = true;
            this.colTarih.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.ShowInCustomizationForm = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            this.colTarih.Width = 140;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colTutar.AppearanceHeader.Options.UseBackColor = true;
            this.colTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 5;
            this.colTutar.Width = 118;
            // 
            // colAciklama
            // 
            this.colAciklama.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colAciklama.AppearanceHeader.Options.UseBackColor = true;
            this.colAciklama.AppearanceHeader.Options.UseTextOptions = true;
            this.colAciklama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAciklama.Caption = "Masraf Adı";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 198;
            // 
            // colVadeTarihi
            // 
            this.colVadeTarihi.Caption = "Vade Tarihi";
            this.colVadeTarihi.DisplayFormat.FormatString = "d";
            this.colVadeTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVadeTarihi.FieldName = "VadeTarihi";
            this.colVadeTarihi.Name = "colVadeTarihi";
            // 
            // colFisTuru
            // 
            this.colFisTuru.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colFisTuru.AppearanceHeader.Options.UseBackColor = true;
            this.colFisTuru.AppearanceHeader.Options.UseTextOptions = true;
            this.colFisTuru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 122;
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.splitContainerControl1);
            this.KeyPreview = true;
            this.Name = "frmKasaHareketleri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasaHareketleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnDetayGor;
        private System.Windows.Forms.ImageList ımageList1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
    }
}