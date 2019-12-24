namespace NetSatis.BackOffice.Raporlar
{
    partial class frmBs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBs));
            this.btnGoster = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAy = new DevExpress.XtraScheduler.UI.MonthEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGoster.ImageOptions.SvgImage")));
            this.btnGoster.Location = new System.Drawing.Point(230, 114);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(106, 36);
            this.btnGoster.TabIndex = 10;
            this.btnGoster.Text = "Göster";
            // 
            // cmbTipi
            // 
            this.cmbTipi.Location = new System.Drawing.Point(414, 59);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTipi.Properties.Appearance.Options.UseFont = true;
            this.cmbTipi.Properties.AutoHeight = false;
            this.cmbTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipi.Properties.NullText = "Hareket Tipi Seçiniz";
            this.cmbTipi.Size = new System.Drawing.Size(102, 36);
            this.cmbTipi.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(423, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 27);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Hareket Tipi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(311, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 27);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Yıl";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(119, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 27);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Ay";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(200, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 16);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Ba Raporlaması için Yıl ve Ay Seçiniz.";
            // 
            // cmbYil
            // 
            this.cmbYil.Location = new System.Drawing.Point(257, 60);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYil.Properties.Appearance.Options.UseFont = true;
            this.cmbYil.Properties.AutoHeight = false;
            this.cmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbYil.Size = new System.Drawing.Size(141, 34);
            this.cmbYil.TabIndex = 21;
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(41, 61);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.Properties.Appearance.Options.UseFont = true;
            this.cmbAy.Properties.AutoHeight = false;
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Size = new System.Drawing.Size(205, 33);
            this.cmbAy.TabIndex = 20;
            // 
            // frmBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 162);
            this.Controls.Add(this.cmbTipi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.btnGoster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBs";
            this.ShowIcon = false;
            this.Text = "Bs Raporla";
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnGoster;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYil;
        private DevExpress.XtraScheduler.UI.MonthEdit cmbAy;
    }
}