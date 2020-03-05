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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuncelleme));
            this.btnGuncellemeyiIndir = new DevExpress.XtraEditors.SimpleButton();
            this.progressFile = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblIndirilen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncellemeyiIndir
            // 
            this.btnGuncellemeyiIndir.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncellemeyiIndir.Appearance.Options.UseFont = true;
            this.btnGuncellemeyiIndir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuncellemeyiIndir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncellemeyiIndir.ImageOptions.Image")));
            this.btnGuncellemeyiIndir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuncellemeyiIndir.ImageOptions.ImageToTextIndent = 10;
            this.btnGuncellemeyiIndir.Location = new System.Drawing.Point(0, 0);
            this.btnGuncellemeyiIndir.Name = "btnGuncellemeyiIndir";
            this.btnGuncellemeyiIndir.Size = new System.Drawing.Size(419, 64);
            this.btnGuncellemeyiIndir.TabIndex = 0;
            this.btnGuncellemeyiIndir.Text = "Güncellemeyi İndir";
            this.btnGuncellemeyiIndir.Click += new System.EventHandler(this.btnGuncellemeyiIndir_Click);
            // 
            // progressFile
            // 
            this.progressFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressFile.Location = new System.Drawing.Point(0, 64);
            this.progressFile.Name = "progressFile";
            this.progressFile.Size = new System.Drawing.Size(419, 55);
            this.progressFile.TabIndex = 1;
            // 
            // lblIndirilen
            // 
            this.lblIndirilen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIndirilen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblIndirilen.Location = new System.Drawing.Point(0, 86);
            this.lblIndirilen.Name = "lblIndirilen";
            this.lblIndirilen.Size = new System.Drawing.Size(419, 33);
            this.lblIndirilen.TabIndex = 2;
            // 
            // frmGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 119);
            this.Controls.Add(this.lblIndirilen);
            this.Controls.Add(this.progressFile);
            this.Controls.Add(this.btnGuncellemeyiIndir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellemeyi İndir";
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncellemeyiIndir;
        private DevExpress.XtraEditors.ProgressBarControl progressFile;
        private DevExpress.XtraEditors.LabelControl lblIndirilen;
    }
}

