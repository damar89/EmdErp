namespace NetSatis.BackOffice.Döviz_Kurları
{
    partial class frmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDovizKurlari));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNotBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNotSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblUyari);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 551);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(680, 57);
            this.groupControl1.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(590, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = " Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(499, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(680, 551);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsim,
            this.colSembol,
            this.colForexBuying,
            this.colForexSelling,
            this.colBankNotBuying,
            this.colBankNotSelling});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIsim
            // 
            this.colIsim.Caption = "İsim";
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 0;
            // 
            // colSembol
            // 
            this.colSembol.Caption = "Sembol";
            this.colSembol.FieldName = "CurrencyCode";
            this.colSembol.Name = "colSembol";
            this.colSembol.Visible = true;
            this.colSembol.VisibleIndex = 1;
            // 
            // colForexBuying
            // 
            this.colForexBuying.Caption = "Forex Alış";
            this.colForexBuying.FieldName = "ForexBuying";
            this.colForexBuying.Name = "colForexBuying";
            this.colForexBuying.Visible = true;
            this.colForexBuying.VisibleIndex = 2;
            // 
            // colForexSelling
            // 
            this.colForexSelling.Caption = "Forex Satış";
            this.colForexSelling.FieldName = "ForexSelling";
            this.colForexSelling.Name = "colForexSelling";
            this.colForexSelling.Visible = true;
            this.colForexSelling.VisibleIndex = 3;
            // 
            // colBankNotBuying
            // 
            this.colBankNotBuying.Caption = "Banknot Alış";
            this.colBankNotBuying.FieldName = "BanknoteBuying";
            this.colBankNotBuying.Name = "colBankNotBuying";
            this.colBankNotBuying.Visible = true;
            this.colBankNotBuying.VisibleIndex = 4;
            // 
            // colBankNotSelling
            // 
            this.colBankNotSelling.Caption = "Banknot Satış";
            this.colBankNotSelling.FieldName = "BanknoteSelling";
            this.colBankNotSelling.Name = "colBankNotSelling";
            this.colBankNotSelling.Visible = true;
            this.colBankNotSelling.VisibleIndex = 5;
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUyari.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.Appearance.ImageIndex = 2;
            this.lblUyari.Appearance.ImageList = this.ımageList1;
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.Appearance.Options.UseImageAlign = true;
            this.lblUyari.Appearance.Options.UseImageIndex = true;
            this.lblUyari.Appearance.Options.UseImageList = true;
            this.lblUyari.Appearance.Options.UseTextOptions = true;
            this.lblUyari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.Location = new System.Drawing.Point(5, 25);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(323, 27);
            this.lblUyari.TabIndex = 7;
            this.lblUyari.UseMnemonic = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "information.png");
            this.ımageList1.Images.SetKeyName(3, "içıkış.png");
            // 
            // frmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 608);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDovizKurlari";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Kurları";
            this.Load += new System.EventHandler(this.frmDovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSembol;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNotBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNotSelling;
        private DevExpress.XtraEditors.LabelControl lblUyari;
        private System.Windows.Forms.ImageList ımageList1;
    }
}