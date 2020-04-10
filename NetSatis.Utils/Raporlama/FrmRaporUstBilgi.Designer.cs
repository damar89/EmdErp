namespace NetSatis.Utils.Raporlama
{
    partial class FrmRaporUstBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporUstBilgi));
            this.txtRaporIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporIsmi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRaporIsmi
            // 
            this.txtRaporIsmi.Location = new System.Drawing.Point(96, 32);
            this.txtRaporIsmi.Name = "txtRaporIsmi";
            this.txtRaporIsmi.Size = new System.Drawing.Size(213, 20);
            this.txtRaporIsmi.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Rapor İsmi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKaydet.Location = new System.Drawing.Point(323, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 55);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmRaporUstBilgi
            // 
            this.AcceptButton = this.btnKaydet;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 79);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRaporIsmi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; 
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmRaporUstBilgi";
            this.Text = "Rapor İsmi";
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporIsmi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRaporIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}