namespace NetSatis.BackOffice.Ödeme_Türü
{
    partial class frmOdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeTuru));
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnKasaHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridContOdemeTuru = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "Hareketler.png");
            this.imgMenu.Images.SetKeyName(1, "replace2.png");
            this.imgMenu.Images.SetKeyName(2, "wallet_closed.png");
            this.imgMenu.Images.SetKeyName(3, "wallet_closed_add.png");
            this.imgMenu.Images.SetKeyName(4, "wallet_closed_delete.png");
            this.imgMenu.Images.SetKeyName(5, "wallet_closed_edit.png");
            this.imgMenu.Images.SetKeyName(6, "funnel.png");
            this.imgMenu.Images.SetKeyName(7, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(8, "view.png");
            this.imgMenu.Images.SetKeyName(9, "folder_out.png");
            // 
            // btnKasaHareket
            // 
            this.btnKasaHareket.ImageOptions.ImageIndex = 0;
            this.btnKasaHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnKasaHareket.Location = new System.Drawing.Point(533, 24);
            this.btnKasaHareket.Name = "btnKasaHareket";
            this.btnKasaHareket.Size = new System.Drawing.Size(111, 31);
            this.btnKasaHareket.TabIndex = 5;
            this.btnKasaHareket.Text = "Ödeme Türü \r\nHareketi";
            this.btnKasaHareket.Click += new System.EventHandler(this.btnKasaHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(650, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(261, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(443, 24);
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
            this.btnDuzenle.Location = new System.Drawing.Point(352, 24);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(85, 31);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 9;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(741, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKasaHareket);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 442);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 57);
            this.groupControl1.TabIndex = 13;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridContOdemeTuru;
            this.gridView1.Name = "gridView1";
            // 
            // gridContOdemeTuru
            // 
            this.gridContOdemeTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContOdemeTuru.Location = new System.Drawing.Point(0, 0);
            this.gridContOdemeTuru.MainView = this.gridOdemeTuru;
            this.gridContOdemeTuru.Name = "gridContOdemeTuru";
            this.gridContOdemeTuru.Size = new System.Drawing.Size(831, 442);
            this.gridContOdemeTuru.TabIndex = 0;
            this.gridContOdemeTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuru,
            this.gridView1,
            this.gridView2});
            // 
            // gridOdemeTuru
            // 
            this.gridOdemeTuru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridOdemeTuru.GridControl = this.gridContOdemeTuru;
            this.gridOdemeTuru.Name = "gridOdemeTuru";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme Türü Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            this.colOdemeTuruKodu.Width = 107;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü Adı";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            this.colOdemeTuruAdi.Width = 145;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 211;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 3;
            this.colKasaGiris.Width = 100;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 4;
            this.colKasaCikis.Width = 106;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 5;
            this.colBakiye.Width = 144;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridContOdemeTuru;
            this.gridView2.Name = "gridView2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContOdemeTuru);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.splitContainerControl1.Size = new System.Drawing.Size(831, 442);
            this.splitContainerControl1.SplitterPosition = 107;
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 499);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmOdemeTuru";
            this.ShowIcon = false;
            this.Text = "Ödeme Türü";
            this.Load += new System.EventHandler(this.frmOdemeTuru_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOdemeTuru_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnKasaHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridContOdemeTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}