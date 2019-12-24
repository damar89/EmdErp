using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmSeriNoGir : Form
    {
        public string veriSeriNo;
       
        public frmSeriNoGir(string veri,bool kilitli = true)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] verilistesi =
                  veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in verilistesi)
                {
                    listSeriNo.Items.Add(item);

                }
            }

            if (kilitli)
            {
                grpMenu.Enabled = false;
            }

        }

        void KayitAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            groupBilgi.Enabled = true;
            txtSeriNo.Focus();
        }

        void KayitKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            groupBilgi.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void frmSeriNoGir_Load(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Remove(listSeriNo.SelectedItem);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeriNoGir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listSeriNo.Items.Count != 0)
            {
                foreach (var item in listSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;

                }
            }

        }
    }
}
