namespace NetSatisAdmin
{
    partial class frmLisansGirisi
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
            this.txtLisansKey = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLisansKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLisansKey
            // 
            this.txtLisansKey.Location = new System.Drawing.Point(32, 33);
            this.txtLisansKey.Name = "txtLisansKey";
            this.txtLisansKey.Properties.AutoHeight = false;
            this.txtLisansKey.Size = new System.Drawing.Size(328, 27);
            this.txtLisansKey.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Lütfen lisans anahtarını girip kaydediniz.";
            // 
            // btnKaydet
            // 
            //this.btnKaydet.ImageOptions.SvgImage = global::NetSatisAdmin.Properties.Resources.save_as;
            this.btnKaydet.Location = new System.Drawing.Point(148, 65);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmLisansGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 117);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLisansKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLisansGirisi";
            this.ShowIcon = false;
            this.Text = "frmLisansGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.txtLisansKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtLisansKey;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}