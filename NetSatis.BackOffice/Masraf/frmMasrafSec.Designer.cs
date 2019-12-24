namespace NetSatis.BackOffice.Masraf
{
    partial class frmMasrafSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasrafSec));
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasrafKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasrafAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasrafHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridContStoklar = new DevExpress.XtraGrid.GridControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.ImageOptions.ImageList = this.ımageList1;
            this.btnSec.Location = new System.Drawing.Point(548, 25);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(85, 31);
            this.btnSec.TabIndex = 5;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "information.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(639, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 427);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(729, 57);
            this.groupControl1.TabIndex = 7;
            // 
            // gridStoklar
            // 
            this.gridStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colMasrafKodu,
            this.colMasrafAdi,
            this.colAciklama,
            this.colGrubu,
            this.colMasrafHareket});
            this.gridStoklar.GridControl = this.gridContStoklar;
            this.gridStoklar.Name = "gridStoklar";
            this.gridStoklar.OptionsView.ShowAutoFilterRow = true;
            this.gridStoklar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridStoklar_KeyDown);
            this.gridStoklar.DoubleClick += new System.EventHandler(this.gridStoklar_DoubleClick);
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
            this.colDurumu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMasrafKodu
            // 
            this.colMasrafKodu.FieldName = "MasrafKodu";
            this.colMasrafKodu.Name = "colMasrafKodu";
            this.colMasrafKodu.OptionsColumn.AllowEdit = false;
            this.colMasrafKodu.Visible = true;
            this.colMasrafKodu.VisibleIndex = 0;
            // 
            // colMasrafAdi
            // 
            this.colMasrafAdi.FieldName = "MasrafAdi";
            this.colMasrafAdi.Name = "colMasrafAdi";
            this.colMasrafAdi.OptionsColumn.AllowEdit = false;
            this.colMasrafAdi.Visible = true;
            this.colMasrafAdi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colGrubu
            // 
            this.colGrubu.FieldName = "Grubu";
            this.colGrubu.Name = "colGrubu";
            this.colGrubu.OptionsColumn.AllowEdit = false;
            this.colGrubu.Visible = true;
            this.colGrubu.VisibleIndex = 2;
            // 
            // colMasrafHareket
            // 
            this.colMasrafHareket.FieldName = "MasrafHareket";
            this.colMasrafHareket.Name = "colMasrafHareket";
            this.colMasrafHareket.OptionsColumn.AllowEdit = false;
            this.colMasrafHareket.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridContStoklar
            // 
            this.gridContStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContStoklar.Location = new System.Drawing.Point(0, 35);
            this.gridContStoklar.MainView = this.gridStoklar;
            this.gridContStoklar.Name = "gridContStoklar";
            this.gridContStoklar.Size = new System.Drawing.Size(729, 392);
            this.gridContStoklar.TabIndex = 8;
            this.gridContStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStoklar});
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
            this.lblBaslik.Size = new System.Drawing.Size(729, 35);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Masraf Seçim Ekranı";
            // 
            // frmMasrafSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 484);
            this.Controls.Add(this.gridContStoklar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasrafSec";
            this.ShowIcon = false;
            this.Text = "Masraf Seç";
            this.Load += new System.EventHandler(this.frmMasrafSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSec;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStoklar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasrafKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasrafAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasrafHareket;
        private DevExpress.XtraGrid.GridControl gridContStoklar;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
    }
}