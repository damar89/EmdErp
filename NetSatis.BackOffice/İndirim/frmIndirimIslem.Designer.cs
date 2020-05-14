namespace NetSatis.BackOffice.İndirim
{
    partial class frmIndirimIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndirimIslem));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateBitis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.dateBaslangic = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnTarihli = new DevExpress.XtraEditors.CheckButton();
            this.btnSuresiz = new DevExpress.XtraEditors.CheckButton();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.gridContIndirimler = new DevExpress.XtraGrid.GridControl();
            this.gridIndirimler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnTopluGiris = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContIndirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "Çıkış";
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&İleri >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Geri";
            this.wizardControl1.Size = new System.Drawing.Size(1019, 645);
            this.wizardControl1.Tag = "";
            this.wizardControl1.Text = "İndirim Sihirbazı";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(959, 478);
            this.welcomeWizardPage1.Text = "İndirim Sihirbazına Hoşgeldiniz";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.splitContainerControl1);
            this.wizardPage1.Controls.Add(this.btnTarihli);
            this.wizardPage1.Controls.Add(this.btnSuresiz);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(959, 478);
            this.wizardPage1.Text = "İndirim Türünü Seçiniz";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 206);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(959, 272);
            this.splitContainerControl1.SplitterPosition = 468;
            this.splitContainerControl1.TabIndex = 16;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateBitis);
            this.groupControl1.Controls.Add(this.dateBaslangic);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(468, 272);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tarih Bilgisi";
            // 
            // dateBitis
            // 
            this.dateBitis.AutoSize = false;
            this.dateBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Location = new System.Drawing.Point(244, 49);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(214, 218);
            this.dateBitis.TabIndex = 32;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.AutoSize = false;
            this.dateBaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Location = new System.Drawing.Point(5, 49);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(214, 218);
            this.dateBaslangic.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(244, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 20);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Bitiş Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(52, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 20);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Başlangıç Tarihi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(481, 272);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(2, 23);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(477, 247);
            this.txtAciklama.TabIndex = 32;
            // 
            // btnTarihli
            // 
            this.btnTarihli.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihli.Appearance.Options.UseFont = true;
            this.btnTarihli.GroupIndex = 1;
            this.btnTarihli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTarihli.ImageOptions.Image")));
            this.btnTarihli.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnTarihli.Location = new System.Drawing.Point(480, 14);
            this.btnTarihli.Name = "btnTarihli";
            this.btnTarihli.Size = new System.Drawing.Size(227, 158);
            this.btnTarihli.TabIndex = 0;
            this.btnTarihli.TabStop = false;
            this.btnTarihli.Text = "Belirli Tarihler Arasında";
            // 
            // btnSuresiz
            // 
            this.btnSuresiz.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuresiz.Appearance.Options.UseFont = true;
            this.btnSuresiz.GroupIndex = 1;
            this.btnSuresiz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuresiz.ImageOptions.Image")));
            this.btnSuresiz.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSuresiz.Location = new System.Drawing.Point(247, 14);
            this.btnSuresiz.Name = "btnSuresiz";
            this.btnSuresiz.Size = new System.Drawing.Size(227, 158);
            this.btnSuresiz.TabIndex = 0;
            this.btnSuresiz.TabStop = false;
            this.btnSuresiz.Text = "Süresiz";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(959, 478);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.gridContIndirimler);
            this.wizardPage2.Controls.Add(this.groupControl3);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(959, 478);
            this.wizardPage2.Text = "Lütfen İndirim Yapılacak Ürünleri Seçiniz";
            // 
            // gridContIndirimler
            // 
            this.gridContIndirimler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContIndirimler.Location = new System.Drawing.Point(0, 0);
            this.gridContIndirimler.MainView = this.gridIndirimler;
            this.gridContIndirimler.Name = "gridContIndirimler";
            this.gridContIndirimler.Size = new System.Drawing.Size(959, 416);
            this.gridContIndirimler.TabIndex = 15;
            this.gridContIndirimler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIndirimler});
            // 
            // gridIndirimler
            // 
            this.gridIndirimler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodu,
            this.colIndirimTuru,
            this.colBaslangicTarihi,
            this.colBitisTarihi,
            this.colIndirimOrani,
            this.colAciklama});
            this.gridIndirimler.GridControl = this.gridContIndirimler;
            this.gridIndirimler.Name = "gridIndirimler";
            this.gridIndirimler.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridIndirimler_PopupMenuShowing);
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
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 131;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 442;
            // 
            // colBarkodu
            // 
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.OptionsColumn.AllowEdit = false;
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 1;
            this.colBarkodu.Width = 166;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.FieldName = "IndirimTuru";
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslangicTarihi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 3;
            this.colIndirimOrani.Width = 197;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnAra);
            this.groupControl3.Controls.Add(this.btnEkle);
            this.groupControl3.Controls.Add(this.btnGuncelle);
            this.groupControl3.Controls.Add(this.btnCikar);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 416);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(959, 62);
            this.groupControl3.TabIndex = 16;
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.ImageOptions.ImageIndex = 5;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(776, 22);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 36);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "stok çıkar.png");
            this.ımageList1.Images.SetKeyName(1, "Stok Ekle.png");
            this.ımageList1.Images.SetKeyName(2, "içıkış.png");
            this.ımageList1.Images.SetKeyName(3, "idüzenle.png");
            this.ımageList1.Images.SetKeyName(4, "iekle.png");
            this.ımageList1.Images.SetKeyName(5, "igüncelle.png");
            this.ımageList1.Images.SetKeyName(6, "ikaydet.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 4;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(595, 21);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 2;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(867, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 36);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // btnCikar
            // 
            this.btnCikar.ImageOptions.ImageIndex = 0;
            this.btnCikar.ImageOptions.ImageList = this.ımageList1;
            this.btnCikar.Location = new System.Drawing.Point(686, 21);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(85, 36);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTopluGiris)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnTopluGiris
            // 
            this.btnTopluGiris.Caption = "Toplu İskonto Girişi";
            this.btnTopluGiris.Id = 0;
            this.btnTopluGiris.Name = "btnTopluGiris";
            this.btnTopluGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTopluGiris_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTopluGiris});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1019, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1019, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 645);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1019, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 645);
            // 
            // frmIndirimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 645);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIndirimIslem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIndirimIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContIndirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.CheckButton btnTarihli;
        private DevExpress.XtraEditors.CheckButton btnSuresiz;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraGrid.GridControl gridContIndirimler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIndirimler;
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
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikar;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBitis;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBaslangic;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnTopluGiris;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}