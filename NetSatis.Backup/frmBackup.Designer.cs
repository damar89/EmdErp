namespace NetSatis.Backup
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriYukle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtYedeklemeKonumu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYedeklemeKonumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseImageList = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(502, 39);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Yedekleme ve  Geri Yükleme";
            // 
            // btnYedekle
            // 
            this.btnYedekle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.Appearance.Options.UseFont = true;
            this.btnYedekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekle.ImageOptions.Image")));
            this.btnYedekle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYedekle.Location = new System.Drawing.Point(12, 40);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(233, 168);
            this.btnYedekle.TabIndex = 5;
            this.btnYedekle.Text = "Yedekleme";
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriYukle.Appearance.Options.UseFont = true;
            this.btnGeriYukle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriYukle.ImageOptions.Image")));
            this.btnGeriYukle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGeriYukle.Location = new System.Drawing.Point(251, 40);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(233, 168);
            this.btnGeriYukle.TabIndex = 5;
            this.btnGeriYukle.Text = "Geri Yükleme";
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 19);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Yedekleme Konumu :";
            // 
            // txtYedeklemeKonumu
            // 
            this.txtYedeklemeKonumu.Location = new System.Drawing.Point(130, 213);
            this.txtYedeklemeKonumu.Name = "txtYedeklemeKonumu";
            this.txtYedeklemeKonumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYedeklemeKonumu.Size = new System.Drawing.Size(354, 20);
            this.txtYedeklemeKonumu.TabIndex = 7;
            this.txtYedeklemeKonumu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtYedeklemeKonumu_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 240);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Database Adı :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(130, 240);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(354, 20);
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 302);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtYedeklemeKonumu);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackup";
            this.ShowIcon = false;
            this.Text = "Yedekleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtYedeklemeKonumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnYedekle;
        private DevExpress.XtraEditors.SimpleButton btnGeriYukle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit txtYedeklemeKonumu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}

