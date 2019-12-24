namespace NetSatisAdmin
{
    partial class frmGenerate
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtExperience = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductKey = new DevExpress.XtraEditors.TextEdit();
            this.cboLicenseType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExperience.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(31, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün ID :";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 10);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(371, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(31, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Lisans Tipi :";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(380, 129);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(93, 34);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Kod Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(31, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Deneme Gün :";
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(117, 76);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(133, 20);
            this.txtExperience.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(12, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ürün Anahtarı :";
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(117, 103);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Properties.ReadOnly = true;
            this.txtProductKey.Size = new System.Drawing.Size(371, 20);
            this.txtProductKey.TabIndex = 1;
            // 
            // cboLicenseType
            // 
            this.cboLicenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicenseType.FormattingEnabled = true;
            this.cboLicenseType.Items.AddRange(new object[] {
            "Full",
            "Trial"});
            this.cboLicenseType.Location = new System.Drawing.Point(117, 42);
            this.cboLicenseType.Name = "cboLicenseType";
            this.cboLicenseType.Size = new System.Drawing.Size(133, 21);
            this.cboLicenseType.TabIndex = 4;
            // 
            // frmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 169);
            this.Controls.Add(this.cboLicenseType);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.frmGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExperience.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductKey.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtExperience;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtProductKey;
        private System.Windows.Forms.ComboBox cboLicenseType;
    }
}