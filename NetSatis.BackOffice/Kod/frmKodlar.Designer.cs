namespace NetSatis.BackOffice.Kod
{
    partial class frmKodlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKodlar));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContTanim = new DevExpress.XtraGrid.GridControl();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnEki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(565, 32);
            this.lblBaslik.TabIndex = 13;
            this.lblBaslik.Text = "Tanımlar";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "checkbox.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(5, "folder_out.png");
            this.ımageList1.Images.SetKeyName(6, "pencil.png");
            this.ımageList1.Images.SetKeyName(7, "içıkış.png");
            this.ımageList1.Images.SetKeyName(8, "ikaydet.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.ImageIndex = 8;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(382, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.ImageIndex = 7;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(476, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 414);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(565, 57);
            this.groupControl1.TabIndex = 12;
            // 
            // gridContTanim
            // 
            this.gridContTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContTanim.Location = new System.Drawing.Point(0, 32);
            this.gridContTanim.MainView = this.gridTanim;
            this.gridContTanim.Name = "gridContTanim";
            this.gridContTanim.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridContTanim.Size = new System.Drawing.Size(565, 382);
            this.gridContTanim.TabIndex = 14;
            this.gridContTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOnEki,
            this.colSonDeger,
            this.colSil});
            this.gridTanim.GridControl = this.gridContTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            this.gridTanim.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridTanim_ShowingEditor);
            this.gridTanim.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridTanim_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOnEki
            // 
            this.colOnEki.Caption = "Ön Eki";
            this.colOnEki.FieldName = "OnEki";
            this.colOnEki.Name = "colOnEki";
            this.colOnEki.OptionsColumn.ShowInCustomizationForm = false;
            this.colOnEki.Visible = true;
            this.colOnEki.VisibleIndex = 0;
            this.colOnEki.Width = 180;
            // 
            // colSonDeger
            // 
            this.colSonDeger.Caption = "Son Değer";
            this.colSonDeger.FieldName = "SonDeger";
            this.colSonDeger.Name = "colSonDeger";
            this.colSonDeger.OptionsColumn.ShowInCustomizationForm = false;
            this.colSonDeger.Visible = true;
            this.colSonDeger.VisibleIndex = 1;
            this.colSonDeger.Width = 447;
            // 
            // colSil
            // 
            this.colSil.Caption = "Sil";
            this.colSil.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colSil.Name = "colSil";
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // frmKodlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 471);
            this.Controls.Add(this.gridContTanim);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKodlar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kod Oluşturma Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOnEki;
        private DevExpress.XtraGrid.Columns.GridColumn colSonDeger;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}