using System;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmBa : DevExpress.XtraEditors.XtraForm
    {

        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();

        public frmBa()
        {
            InitializeComponent();
            var combx = eislem.HareketTipiListele();

            foreach (var i in combx)
            {
                cmbTipi.Properties.Items.Add(i.Aciklama);
            }
            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cmbTipi.EditValue != null)
            {
                frmBaRapor frm = new frmBaRapor(
              Convert.ToInt32(cmbAy.EditValue),
              Convert.ToInt32(cmbYil.EditValue),
              cmbTipi.EditValue.ToString()
              );
                frm.Show();
            }
         
            
        }
    }
}