namespace NetSatis.BackOffice.İndirim
{
    partial class frmIndirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndirim));
            this.gridContIndirim = new DevExpress.XtraGrid.GridControl();
            this.gridIndirim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repobaslangic = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBitis = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPasif = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridContIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repobaslangic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repobaslangic.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridContIndirim
            // 
            this.gridContIndirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContIndirim.Location = new System.Drawing.Point(0, 0);
            this.gridContIndirim.MainView = this.gridIndirim;
            this.gridContIndirim.Name = "gridContIndirim";
            this.gridContIndirim.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repobaslangic,
            this.repoBitis});
            this.gridContIndirim.Size = new System.Drawing.Size(942, 412);
            this.gridContIndirim.TabIndex = 14;
            this.gridContIndirim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIndirim});
            // 
            // gridIndirim
            // 
            this.gridIndirim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodu,
            this.colIndirimTuru,
            this.colBaslangicTarihi,
            this.colBitisTarihi,
            this.colIndirimOrani,
            this.colAciklama,
            this.colIndirimAktif});
            this.gridIndirim.GridControl = this.gridContIndirim;
            this.gridIndirim.Name = "gridIndirim";
            this.gridIndirim.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridIndirim_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 1;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 2;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            // 
            // colBarkodu
            // 
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.OptionsColumn.AllowEdit = false;
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 4;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.Caption = "İndirim Türü";
            this.colIndirimTuru.FieldName = "IndirimTuru";
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.Visible = true;
            this.colIndirimTuru.VisibleIndex = 5;
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.Caption = "Başlangıç Tarihi";
            this.colBaslangicTarihi.ColumnEdit = this.repobaslangic;
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslangicTarihi.Visible = true;
            this.colBaslangicTarihi.VisibleIndex = 6;
            // 
            // repobaslangic
            // 
            this.repobaslangic.AutoHeight = false;
            this.repobaslangic.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repobaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repobaslangic.Name = "repobaslangic";
            this.repobaslangic.NullText = "Süresiz İndirim";
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.Caption = "BitişTarihi";
            this.colBitisTarihi.ColumnEdit = this.repoBitis;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 7;
            // 
            // repoBitis
            // 
            this.repoBitis.AutoHeight = false;
            this.repoBitis.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBitis.Name = "repoBitis";
            this.repoBitis.NullText = "Süresiz İndirim";
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İndirim Oranı";
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // colIndirimAktif
            // 
            this.colIndirimAktif.Caption = "İndirim Aktif Mi?";
            this.colIndirimAktif.FieldName = "IndirimAktif";
            this.colIndirimAktif.Name = "colIndirimAktif";
            this.colIndirimAktif.Visible = true;
            this.colIndirimAktif.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnPasif);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 412);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(942, 62);
            this.groupControl1.TabIndex = 13;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(852, 23);
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
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            this.ımageList1.Images.SetKeyName(3, "düzenle.png");
            this.ımageList1.Images.SetKeyName(4, "ekle.png");
            this.ımageList1.Images.SetKeyName(5, "sil.png");
            this.ımageList1.Images.SetKeyName(6, "if_check_173176.png");
            this.ımageList1.Images.SetKeyName(7, "aktif1.png");
            this.ımageList1.Images.SetKeyName(8, "pasif.png");
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 5;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(96, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 36);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 4;
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
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(283, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 36);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.ImageOptions.ImageIndex = 6;
            this.btnPasif.ImageOptions.ImageList = this.ımageList1;
            this.btnPasif.Location = new System.Drawing.Point(188, 25);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(89, 36);
            this.btnPasif.TabIndex = 3;
            this.btnPasif.Text = "Pasif Yap";
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // frmIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 474);
            this.Controls.Add(this.gridContIndirim);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmIndirim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirimler";
            this.Load += new System.EventHandler(this.frmIndirim_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIndirim_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridContIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repobaslangic.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repobaslangic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBitis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridContIndirim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIndirim;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPasif;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimAktif;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repobaslangic;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repoBitis;
    }
}