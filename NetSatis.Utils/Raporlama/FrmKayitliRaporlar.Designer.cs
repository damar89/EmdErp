namespace NetSatis.Utils.Raporlama
{
    partial class FrmKayitliRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitliRaporlar));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnDizaynIsmiDegistir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnCik = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grRaporlar = new DevExpress.XtraGrid.GridControl();
            this.gvRaporlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSil,
            this.btnDuzenle,
            this.btnCik,
            this.barStaticItem1,
            this.btnDizaynIsmiDegistir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDizaynIsmiDegistir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDuzenle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCik),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnDizaynIsmiDegistir
            // 
            this.btnDizaynIsmiDegistir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDizaynIsmiDegistir.Caption = "Dizayn İsmini Değiştir";
            this.btnDizaynIsmiDegistir.Id = 4;
            this.btnDizaynIsmiDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDizaynIsmiDegistir.ImageOptions.Image")));
            this.btnDizaynIsmiDegistir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDizaynIsmiDegistir.ImageOptions.LargeImage")));
            this.btnDizaynIsmiDegistir.Name = "btnDizaynIsmiDegistir";
            this.btnDizaynIsmiDegistir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDizaynIsmiDegistir_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 0;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Id = 1;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.LargeImage")));
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuzenle_ItemClick);
            // 
            // btnCik
            // 
            this.btnCik.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCik.Caption = "Çık";
            this.btnCik.Id = 2;
            this.btnCik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCik.ImageOptions.Image")));
            this.btnCik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCik.ImageOptions.LargeImage")));
            this.btnCik.Name = "btnCik";
            this.btnCik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCik_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Kayıtlı Rapor Tasarımları";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(572, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(572, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(572, 56);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // grRaporlar
            // 
            this.grRaporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grRaporlar.Location = new System.Drawing.Point(0, 56);
            this.grRaporlar.MainView = this.gvRaporlar;
            this.grRaporlar.MenuManager = this.barManager1;
            this.grRaporlar.Name = "grRaporlar";
            this.grRaporlar.Size = new System.Drawing.Size(572, 475);
            this.grRaporlar.TabIndex = 4;
            this.grRaporlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRaporlar});
            // 
            // gvRaporlar
            // 
            this.gvRaporlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvRaporlar.GridControl = this.grRaporlar;
            this.gvRaporlar.Name = "gvRaporlar";
            this.gvRaporlar.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRaporlar.OptionsBehavior.Editable = false;
            this.gvRaporlar.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Dizayn İsmi";
            this.gridColumn2.FieldName = "DizaynIsmi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // FrmKayitliRaporlar
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 554);
            this.Controls.Add(this.grRaporlar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; 
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmKayitliRaporlar";
            this.ShowIcon = false;
            this.Text = "Kayıtlı Rapor Tasarımları";
            this.Load += new System.EventHandler(this.FrmKayitliRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnSil;
        private DevExpress.XtraBars.BarLargeButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarLargeButtonItem btnCik;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grRaporlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRaporlar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarLargeButtonItem btnDizaynIsmiDegistir;
    }
}