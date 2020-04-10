using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Personel
{

    public partial class frmPersonelHareket : Form
    {
        NetSatisContext context=new NetSatisContext();
        PersonelDal personelDal=new PersonelDal();
        FisDAL fisDal=new FisDAL();
        private int _personelId;
        public frmPersonelHareket(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            var personelBilgi = context.Personeller.SingleOrDefault(c => c.Id == personelId);
            lblBaslik.Text = personelBilgi.PersonelKodu + " - " + personelBilgi.PersonelAdi;

        }

        private void frmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridContPersonelHareket.DataSource = fisDal.GetAll(context, c => c.PlasiyerId == _personelId);
            gridContFisToplam.DataSource = personelDal.PersonelFisToplam(context, _personelId);


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridPersonelHareket.OptionsView.ShowAutoFilterRow = true ? gridPersonelHareket.OptionsView.ShowAutoFilterRow = false : gridPersonelHareket.OptionsView.ShowAutoFilterRow = true;
        }
    }
}
