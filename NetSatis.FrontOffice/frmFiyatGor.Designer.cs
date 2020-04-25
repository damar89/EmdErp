namespace NetSatis.FrontOffice
{
    partial class frmFiyatGor
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
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.calcSatisFiyat1 = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtKod = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMiktar = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSatisFiyat1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.EditValue = "";
            this.txtBarkod.Location = new System.Drawing.Point(115, 54);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtBarkod.Properties.Appearance.Options.UseBackColor = true;
            this.txtBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtBarkod.Properties.Appearance.Options.UseForeColor = true;
            this.txtBarkod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBarkod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBarkod.Properties.AutoHeight = false;
            this.txtBarkod.Properties.NullText = "54564";
            this.txtBarkod.Size = new System.Drawing.Size(483, 44);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(608, 39);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Aşağıdaki Kutucuğa BARKOD Okutunuz...";
            // 
            // calcSatisFiyat1
            // 
            this.calcSatisFiyat1.Location = new System.Drawing.Point(180, 183);
            this.calcSatisFiyat1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calcSatisFiyat1.Name = "calcSatisFiyat1";
            this.calcSatisFiyat1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcSatisFiyat1.Properties.Appearance.Options.UseFont = true;
            this.calcSatisFiyat1.Properties.AutoHeight = false;
            this.calcSatisFiyat1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.calcSatisFiyat1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.calcSatisFiyat1.Properties.DisplayFormat.FormatString = "c2";
            this.calcSatisFiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcSatisFiyat1.Properties.EditFormat.FormatString = "c2";
            this.calcSatisFiyat1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcSatisFiyat1.Properties.ReadOnly = true;
            this.calcSatisFiyat1.Size = new System.Drawing.Size(419, 28);
            this.calcSatisFiyat1.TabIndex = 6;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl26.Appearance.Options.UseBorderColor = true;
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Appearance.Options.UseTextOptions = true;
            this.labelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl26.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl26.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl26.Location = new System.Drawing.Point(14, 186);
            this.labelControl26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(159, 25);
            this.labelControl26.TabIndex = 7;
            this.labelControl26.Text = "Satış Fiyatı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(14, 154);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(159, 25);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "  Stok Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(14, 119);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 25);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "  Stok Kodu :";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::NetSatis.FrontOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(500, 324);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(107, 47);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtKod
            // 
            this.txtKod.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.txtKod.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Appearance.Options.UseBorderColor = true;
            this.txtKod.Appearance.Options.UseFont = true;
            this.txtKod.Appearance.Options.UseTextOptions = true;
            this.txtKod.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtKod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtKod.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtKod.Location = new System.Drawing.Point(180, 119);
            this.txtKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(414, 25);
            this.txtKod.TabIndex = 9;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.txtStokAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAdi.Appearance.Options.UseBorderColor = true;
            this.txtStokAdi.Appearance.Options.UseFont = true;
            this.txtStokAdi.Appearance.Options.UseTextOptions = true;
            this.txtStokAdi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtStokAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtStokAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStokAdi.Location = new System.Drawing.Point(180, 154);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(414, 25);
            this.txtStokAdi.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(10, 257);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(159, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Mevcut Stok Mikarı :";
            // 
            // lblMiktar
            // 
            this.lblMiktar.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.lblMiktar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Appearance.Options.UseBorderColor = true;
            this.lblMiktar.Appearance.Options.UseFont = true;
            this.lblMiktar.Appearance.Options.UseTextOptions = true;
            this.lblMiktar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblMiktar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMiktar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblMiktar.Location = new System.Drawing.Point(180, 257);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(414, 25);
            this.lblMiktar.TabIndex = 9;
            // 
            // frmFiyatGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 373);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.labelControl26);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.calcSatisFiyat1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiyatGor";
            this.Text = "Fiyat Gör";
            this.Load += new System.EventHandler(this.frmFiyatGor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFiyatGor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSatisFiyat1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit calcSatisFiyat1;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl txtKod;
        private DevExpress.XtraEditors.LabelControl txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMiktar;
    }
}