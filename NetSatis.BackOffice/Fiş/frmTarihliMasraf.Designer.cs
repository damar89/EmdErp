namespace NetSatis.BackOffice.Raporlar
{
    partial class frmTarihliMasraf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarihliMasraf));
            this.btnGoster = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBitis = new DevExpress.XtraEditors.DateEdit();
            this.dtpBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGoster.ImageOptions.SvgImage")));
            this.btnGoster.Location = new System.Drawing.Point(141, 186);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(89, 34);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Göster";
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 25);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Başlangıç Tarihi :";
            // 
            // dtpBitis
            // 
            this.dtpBitis.EditValue = new System.DateTime(2018, 11, 2, 22, 37, 28, 478);
            this.dtpBitis.Location = new System.Drawing.Point(106, 47);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Properties.AutoHeight = false;
            this.dtpBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBitis.Properties.DisplayFormat.FormatString = "";
            this.dtpBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBitis.Properties.EditFormat.FormatString = "";
            this.dtpBitis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBitis.Properties.Mask.EditMask = "";
            this.dtpBitis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Size = new System.Drawing.Size(190, 18);
            this.dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.EditValue = new System.DateTime(2018, 11, 2, 22, 37, 17, 404);
            this.dtpBaslangic.Location = new System.Drawing.Point(106, 15);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Properties.AutoHeight = false;
            this.dtpBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBaslangic.Properties.DisplayFormat.FormatString = "";
            this.dtpBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBaslangic.Properties.EditFormat.FormatString = "";
            this.dtpBaslangic.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBaslangic.Properties.Mask.EditMask = "";
            this.dtpBaslangic.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBaslangic.Size = new System.Drawing.Size(190, 19);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 25);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Bitiş Tarihi :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(106, 74);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(190, 20);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(106, 103);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(190, 20);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(106, 132);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Size = new System.Drawing.Size(190, 20);
            this.comboBoxEdit3.TabIndex = 4;
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(106, 160);
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Size = new System.Drawing.Size(190, 20);
            this.comboBoxEdit4.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 25);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Kategori :";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(12, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 25);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Ana Grup :";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(12, 130);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 25);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Marka :";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(12, 155);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 25);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Üretici :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 220);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(424, 57);
            this.groupControl1.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(334, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmTarihliMasraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 277);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.comboBoxEdit4);
            this.Controls.Add(this.comboBoxEdit3);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.btnGoster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTarihliMasraf";
            this.ShowIcon = false;
            this.Text = "Masraf Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGoster;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpBitis;
        private DevExpress.XtraEditors.DateEdit dtpBaslangic;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}