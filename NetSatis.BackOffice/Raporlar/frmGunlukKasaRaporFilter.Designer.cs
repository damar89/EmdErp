﻿namespace NetSatis.BackOffice.Raporlar
{
    partial class frmGunlukKasaRaporFilter
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dtpBitis = new DevExpress.XtraEditors.DateEdit();
            this.dtpBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGoster = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBitis
            // 
            this.dtpBitis.EditValue = new System.DateTime(2018, 11, 2, 22, 37, 28, 478);
            this.dtpBitis.Location = new System.Drawing.Point(94, 54);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = global::NetSatis.BackOffice.Properties.Resources.today_16x163;
            this.dtpBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Bugünün Tarihi", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.dtpBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBitis.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBitis.Properties.Mask.EditMask = "";
            this.dtpBitis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtpBitis.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpBitis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Size = new System.Drawing.Size(190, 18);
            this.dtpBitis.TabIndex = 23;
            this.dtpBitis.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dtpBitis_ButtonClick);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.EditValue = new System.DateTime(2018, 11, 2, 22, 37, 17, 404);
            this.dtpBaslangic.Location = new System.Drawing.Point(94, 22);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Properties.AutoHeight = false;
            editorButtonImageOptions2.Image = global::NetSatis.BackOffice.Properties.Resources.today_16x162;
            this.dtpBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Bugünün Tarihi", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.dtpBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBaslangic.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBaslangic.Properties.Mask.EditMask = "";
            this.dtpBaslangic.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtpBaslangic.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpBaslangic.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBaslangic.Size = new System.Drawing.Size(190, 19);
            this.dtpBaslangic.TabIndex = 22;
            this.dtpBaslangic.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dtpBaslangic_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(10, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 25);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Bitiş Tarihi :";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(10, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 25);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Başlangıç Tarihi :";
            // 
            // btnGoster
            // 
            this.btnGoster.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.Göster1;
            this.btnGoster.Location = new System.Drawing.Point(134, 88);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(89, 40);
            this.btnGoster.TabIndex = 24;
            this.btnGoster.Text = "Göster";
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 143);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 57);
            this.groupControl1.TabIndex = 27;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(246, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmGunlukKasaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 200);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGoster);
            this.Name = "frmGunlukKasaRapor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Sonu Göster";
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpBitis;
        private DevExpress.XtraEditors.DateEdit dtpBaslangic;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGoster;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}