using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmFaturaGonder : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        public frmFaturaGonder()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

        }

        private void frmFaturaGonder_Load(object sender, EventArgs e)
        {
            context = new NetSatisContext();
            gridContFisler.DataSource = fisDal.StokListele(context);
        }
        public void FaturaGonder()
        {
            //foreach (var item in gridContFisler)
            //{

            //}
            //EDonusum.Models.Donusum.MasterView m=new EDonusum.Models.Donusum.MasterView
            //{
            //    master=new EDonusum.Models.Donusum.Master
            //    {
                    
            //        Aciklama=colAciklama,
            //        AlisVerisNo="",
            //        FisKodu="",
            //        FisTuru=""

            //    },
            //    Username=,
            //    Password="",
            //    VergiNumarasi="",
            //    MusteriAdi="",
                
            //};
        }
    }
}