namespace NetSatisAdmin
{
    partial class frmLisansBilgileri
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblProductID = new DevExpress.XtraEditors.LabelControl();
            this.lblProductKey = new DevExpress.XtraEditors.LabelControl();
            this.lblLicenceType = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(27, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(27, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün Adı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ürün Anhatarı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(12, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Lisans Tipi :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProductName.Location = new System.Drawing.Point(102, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(395, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "?";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProductID.Location = new System.Drawing.Point(102, 54);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(395, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "?";
            // 
            // lblProductKey
            // 
            this.lblProductKey.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProductKey.Location = new System.Drawing.Point(102, 80);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(395, 13);
            this.lblProductKey.TabIndex = 2;
            this.lblProductKey.Text = "?";
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLicenceType.Location = new System.Drawing.Point(102, 106);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(395, 13);
            this.lblLicenceType.TabIndex = 2;
            this.lblLicenceType.Text = "?";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(201, 125);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Tamam";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmLisansBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 154);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.lblProductKey);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLisansBilgileri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans Bilgileri";
            this.Load += new System.EventHandler(this.frmLisansBilgileri_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblProductID;
        private DevExpress.XtraEditors.LabelControl lblProductKey;
        private DevExpress.XtraEditors.LabelControl lblLicenceType;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}