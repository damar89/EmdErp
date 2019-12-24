namespace NetSatis.Update
{
    partial class frmGuncelleme
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
            this.btnGuncellemeyiIndir = new DevExpress.XtraEditors.SimpleButton();
            this.progressFile = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblIndirilen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncellemeyiIndir
            // 
            this.btnGuncellemeyiIndir.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncellemeyiIndir.Appearance.Options.UseFont = true;
            this.btnGuncellemeyiIndir.Location = new System.Drawing.Point(102, 21);
            this.btnGuncellemeyiIndir.Name = "btnGuncellemeyiIndir";
            this.btnGuncellemeyiIndir.Size = new System.Drawing.Size(208, 101);
            this.btnGuncellemeyiIndir.TabIndex = 0;
            this.btnGuncellemeyiIndir.Text = "Güncellemeyi İndir";
            this.btnGuncellemeyiIndir.Click += new System.EventHandler(this.btnGuncellemeyiIndir_Click);
            // 
            // progressFile
            // 
            this.progressFile.Location = new System.Drawing.Point(12, 128);
            this.progressFile.Name = "progressFile";
            this.progressFile.Size = new System.Drawing.Size(397, 40);
            this.progressFile.TabIndex = 1;
            // 
            // lblIndirilen
            // 
            this.lblIndirilen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIndirilen.Location = new System.Drawing.Point(12, 174);
            this.lblIndirilen.Name = "lblIndirilen";
            this.lblIndirilen.Size = new System.Drawing.Size(397, 19);
            this.lblIndirilen.TabIndex = 2;
            // 
            // frmGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 186);
            this.Controls.Add(this.lblIndirilen);
            this.Controls.Add(this.progressFile);
            this.Controls.Add(this.btnGuncellemeyiIndir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuncelleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme";
            this.Load += new System.EventHandler(this.frmGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncellemeyiIndir;
        private DevExpress.XtraEditors.ProgressBarControl progressFile;
        private DevExpress.XtraEditors.LabelControl lblIndirilen;
    }
}

