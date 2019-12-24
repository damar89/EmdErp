namespace NetSatis.BackOffice.Tanım
{
    partial class frmAnaGruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaGruplar));
            this.gridContAnaGruplar = new DevExpress.XtraGrid.GridControl();
            this.gridAnaGruplar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnaGrupKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnaGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridContAnaGruplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaGruplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridContAnaGruplar
            // 
            this.gridContAnaGruplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContAnaGruplar.Location = new System.Drawing.Point(0, 0);
            this.gridContAnaGruplar.MainView = this.gridAnaGruplar;
            this.gridContAnaGruplar.Name = "gridContAnaGruplar";
            this.gridContAnaGruplar.Size = new System.Drawing.Size(893, 424);
            this.gridContAnaGruplar.TabIndex = 0;
            this.gridContAnaGruplar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAnaGruplar});
            // 
            // gridAnaGruplar
            // 
            this.gridAnaGruplar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAnaGrupKodu,
            this.colAnaGrupAdi});
            this.gridAnaGruplar.GridControl = this.gridContAnaGruplar;
            this.gridAnaGruplar.Name = "gridAnaGruplar";
            this.gridAnaGruplar.DoubleClick += new System.EventHandler(this.gridAnaGruplar_DoubleClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colAnaGrupKodu
            // 
            this.colAnaGrupKodu.Caption = "AnaGrup Kodu";
            this.colAnaGrupKodu.FieldName = "Kod";
            this.colAnaGrupKodu.Name = "colAnaGrupKodu";
            this.colAnaGrupKodu.OptionsColumn.AllowEdit = false;
            this.colAnaGrupKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colAnaGrupKodu.Visible = true;
            this.colAnaGrupKodu.VisibleIndex = 0;
            // 
            // colAnaGrupAdi
            // 
            this.colAnaGrupAdi.Caption = "AnaGrup Adı";
            this.colAnaGrupAdi.FieldName = "AnaGrupAdi";
            this.colAnaGrupAdi.Name = "colAnaGrupAdi";
            this.colAnaGrupAdi.OptionsColumn.AllowEdit = false;
            this.colAnaGrupAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colAnaGrupAdi.Visible = true;
            this.colAnaGrupAdi.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 424);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(893, 57);
            this.groupControl1.TabIndex = 10;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 2;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(803, 23);
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
            this.imgMenu.Images.SetKeyName(0, "düzenle.png");
            this.imgMenu.Images.SetKeyName(1, "ekle.png");
            this.imgMenu.Images.SetKeyName(2, "folder_out.png");
            this.imgMenu.Images.SetKeyName(3, "hareket.png");
            this.imgMenu.Images.SetKeyName(4, "refresh.png");
            this.imgMenu.Images.SetKeyName(5, "sil.png");
            this.imgMenu.Images.SetKeyName(6, "view.png");
            this.imgMenu.Images.SetKeyName(7, "funnel.png");
            this.imgMenu.Images.SetKeyName(8, "funnel_delete.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 4;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(711, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 1;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(442, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 5;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(624, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 0;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(533, 24);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(85, 31);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContAnaGruplar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.splitContainerControl1.Size = new System.Drawing.Size(893, 424);
            this.splitContainerControl1.SplitterPosition = 107;
            this.splitContainerControl1.TabIndex = 11;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmAnaGruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 481);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAnaGruplar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaGruplar";
            this.Load += new System.EventHandler(this.frmAnaGruplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContAnaGruplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaGruplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContAnaGruplar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAnaGruplar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAnaGrupKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colAnaGrupAdi;
    }
}