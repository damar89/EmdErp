namespace NetSatisAdmin
{
    partial class frmRegistration
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
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductKey = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(103, 12);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(371, 20);
            this.txtProductID.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(17, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün ID :";
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(103, 49);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(371, 20);
            this.txtProductKey.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(-2, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ürün Anahtarı :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(399, 90);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tamam";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 121);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductKey.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtProductKey;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}