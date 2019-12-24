namespace NetSatis.BackOffice.Hızlı_Satış
{
    partial class frmHizliSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHizliSatis));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContGrupEkle = new DevExpress.XtraGrid.GridControl();
            this.gridGrupEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.grupBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridContUrunEkle = new DevExpress.XtraGrid.GridControl();
            this.gridUrunEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupBilgi)).BeginInit();
            this.grupBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 32);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContGrupEkle);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.grupBilgi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContUrunEkle);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(790, 485);
            this.splitContainerControl1.SplitterPosition = 367;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridContGrupEkle
            // 
            this.gridContGrupEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContGrupEkle.Location = new System.Drawing.Point(0, 121);
            this.gridContGrupEkle.MainView = this.gridGrupEkle;
            this.gridContGrupEkle.Name = "gridContGrupEkle";
            this.gridContGrupEkle.Size = new System.Drawing.Size(367, 302);
            this.gridContGrupEkle.TabIndex = 12;
            this.gridContGrupEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGrupEkle});
            // 
            // gridGrupEkle
            // 
            this.gridGrupEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGrupAdi,
            this.colAciklama});
            this.gridGrupEkle.GridControl = this.gridContGrupEkle;
            this.gridGrupEkle.Name = "gridGrupEkle";
            this.gridGrupEkle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridGrupEkle_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 0;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.btnVazgec);
            this.groupControl2.Controls.Add(this.btnYeni);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 423);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(367, 62);
            this.groupControl2.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.ImageIndex = 8;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(103, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 34);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.ımageList1.Images.SetKeyName(5, "içıkış.png");
            this.ımageList1.Images.SetKeyName(6, "iekle.png");
            this.ımageList1.Images.SetKeyName(7, "ikaydet.png");
            this.ımageList1.Images.SetKeyName(8, "isil.png");
            // 
            // btnVazgec
            // 
            this.btnVazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 3;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(263, 25);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(81, 34);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.ImageOptions.ImageIndex = 0;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(17, 25);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(83, 34);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 7;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(182, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 34);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grupBilgi
            // 
            this.grupBilgi.Controls.Add(this.txtAciklama);
            this.grupBilgi.Controls.Add(this.txtGrupAdi);
            this.grupBilgi.Controls.Add(this.labelControl2);
            this.grupBilgi.Controls.Add(this.labelControl1);
            this.grupBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupBilgi.Enabled = false;
            this.grupBilgi.Location = new System.Drawing.Point(0, 0);
            this.grupBilgi.Name = "grupBilgi";
            this.grupBilgi.Size = new System.Drawing.Size(367, 121);
            this.grupBilgi.TabIndex = 0;
            this.grupBilgi.Text = "Grup İşlemleri";
            this.grupBilgi.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(71, 61);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(291, 46);
            this.txtAciklama.TabIndex = 2;
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupAdi.Location = new System.Drawing.Point(71, 34);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Properties.AutoHeight = false;
            this.txtGrupAdi.Size = new System.Drawing.Size(291, 20);
            this.txtGrupAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(7, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 46);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Açıklama :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(7, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Grup Adi :";
            // 
            // gridContUrunEkle
            // 
            this.gridContUrunEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.gridContUrunEkle.MainView = this.gridUrunEkle;
            this.gridContUrunEkle.Name = "gridContUrunEkle";
            this.gridContUrunEkle.Size = new System.Drawing.Size(417, 423);
            this.gridContUrunEkle.TabIndex = 13;
            this.gridContUrunEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunEkle});
            // 
            // gridUrunEkle
            // 
            this.gridUrunEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrupId,
            this.colStokKodu,
            this.colUrunAdi});
            this.gridUrunEkle.GridControl = this.gridContUrunEkle;
            this.gridUrunEkle.Name = "gridUrunEkle";
            this.gridUrunEkle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colGrupId
            // 
            this.colGrupId.FieldName = "GrupId";
            this.colGrupId.Name = "colGrupId";
            this.colGrupId.OptionsColumn.AllowEdit = false;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 118;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 282;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnUrunEkle);
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Controls.Add(this.btnUrunSil);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 423);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(417, 62);
            this.groupControl3.TabIndex = 12;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunEkle.ImageOptions.ImageIndex = 6;
            this.btnUrunEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnUrunEkle.Location = new System.Drawing.Point(12, 25);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(74, 34);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 5;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(338, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(74, 34);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = " Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunSil.ImageOptions.ImageIndex = 8;
            this.btnUrunSil.ImageOptions.ImageList = this.ımageList1;
            this.btnUrunSil.Location = new System.Drawing.Point(93, 25);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(74, 34);
            this.btnUrunSil.TabIndex = 0;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(790, 32);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Hızlı Satış İşlemleri";
            // 
            // frmHizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 517);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHizliSatis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış Tanımlaması";
            this.Load += new System.EventHandler(this.frmHizliSatis_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHizliSatis_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupBilgi)).EndInit();
            this.grupBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl grupBilgi;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraGrid.GridControl gridContGrupEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGrupEkle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridContUrunEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunEkle;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupId;
    }
}