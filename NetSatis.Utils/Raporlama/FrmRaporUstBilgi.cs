using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace NetSatis.Utils
{
    public partial class FrmRaporUstBilgi : XtraForm
    {
        private string _raporIsmi;

        public string RaporIsmi
        {
            get { return txtRaporIsmi.Text; }
            set
            {
                _raporIsmi = value;
                txtRaporIsmi.Text = _raporIsmi;
            }
        }

        public bool Vazgecildi = true;

        public FrmRaporUstBilgi()
        {
            InitializeComponent();
            txtRaporIsmi.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (RaporIsmi == string.Empty)
            {
                XtraMessageBox.Show("Rapor ismi boş olamaz!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Vazgecildi = false;

            this.Close();
        } 
    }
}
