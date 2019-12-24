namespace NetSatisAdmin
{
    partial class frmEtkinlestirme
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
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistration = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbout = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(54, 34);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 34);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Anahtar Üret";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(148, 34);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(88, 34);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Kayıt";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(242, 34);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(88, 34);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "Lisans Bilgileri";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmEtkinlestirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 85);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnGenerate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEtkinlestirme";
            this.ShowIcon = false;
            this.Text = "Etkinleştirme";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.SimpleButton btnRegistration;
        private DevExpress.XtraEditors.SimpleButton btnAbout;
    }
}