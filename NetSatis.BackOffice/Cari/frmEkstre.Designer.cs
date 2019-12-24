namespace NetSatis.BackOffice.Cari
{
    partial class frmEkstre
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCariEkstreDokumu = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiyeDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBitis = new DevExpress.XtraEditors.DateEdit();
            this.dtpBaslangic = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCariEkstreDokumu);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 320);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 66);
            this.groupControl1.TabIndex = 4;
            // 
            // btnCariEkstreDokumu
            // 
            this.btnCariEkstreDokumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCariEkstreDokumu.ImageOptions.ImageIndex = 2;
            this.btnCariEkstreDokumu.Location = new System.Drawing.Point(513, 29);
            this.btnCariEkstreDokumu.Name = "btnCariEkstreDokumu";
            this.btnCariEkstreDokumu.Size = new System.Drawing.Size(102, 31);
            this.btnCariEkstreDokumu.TabIndex = 13;
            this.btnCariEkstreDokumu.Text = "Cari Ekstre Dökümü";
            this.btnCariEkstreDokumu.Click += new System.EventHandler(this.btnCariEkstreDokumu_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.Location = new System.Drawing.Point(621, 29);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 258);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCariKodu,
            this.colCariAdi,
            this.colIlce,
            this.colIl,
            this.colBakiye,
            this.colBakiyeDurum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 0;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 1;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 2;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 3;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 4;
            // 
            // colBakiyeDurum
            // 
            this.colBakiyeDurum.Caption = "Durumu";
            this.colBakiyeDurum.FieldName = "HesapBakiye";
            this.colBakiyeDurum.Name = "colBakiyeDurum";
            this.colBakiyeDurum.OptionsColumn.AllowEdit = false;
            this.colBakiyeDurum.Visible = true;
            this.colBakiyeDurum.VisibleIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.dtpBitis);
            this.groupControl2.Controls.Add(this.dtpBaslangic);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(711, 62);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Cari Seçim";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(381, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(282, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Lütfen Aşağıdan ekstre almak istediğiniz cari hesabı seçiniz.";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(202, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Bitiş :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Başlangıç :";
            // 
            // dtpBitis
            // 
            this.dtpBitis.EditValue = new System.DateTime(2018, 11, 5, 12, 28, 11, 118);
            this.dtpBitis.Location = new System.Drawing.Point(239, 23);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Properties.AutoHeight = false;
            this.dtpBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dtpBitis.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBitis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Size = new System.Drawing.Size(123, 29);
            this.dtpBitis.TabIndex = 14;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.EditValue = new System.DateTime(2018, 11, 5, 12, 28, 11, 118);
            this.dtpBaslangic.Location = new System.Drawing.Point(71, 24);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Properties.AutoHeight = false;
            this.dtpBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dtpBaslangic.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBaslangic.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBaslangic.Size = new System.Drawing.Size(123, 29);
            this.dtpBaslangic.TabIndex = 15;
            this.dtpBaslangic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpBaslangic_KeyDown);
            // 
            // frmEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 386);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEkstre";
            this.ShowIcon = false;
            this.Text = "Cari Ekstre";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEkstre_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpBitis;
        private DevExpress.XtraEditors.DateEdit dtpBaslangic;
        private DevExpress.XtraEditors.SimpleButton btnCariEkstreDokumu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiyeDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}