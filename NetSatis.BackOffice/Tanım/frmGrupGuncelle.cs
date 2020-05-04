using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmGrupGuncelle : DevExpress.XtraEditors.XtraForm
    {
        HizliSatisGrupDAL grupdal = new HizliSatisGrupDAL();
        NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;
        private Entities.Tables.HizliSatisGrup _entity;
        bool guncelle = false;
        public frmGrupGuncelle(Entities.Tables.HizliSatisGrup entity)
        {
            InitializeComponent();
            _entity = entity;
            txtGrupAdi.DataBindings.Add("Text", _entity, "GrupAdi");
            txtGrupAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (grupdal.AddOrUpdate(context, _entity))
            {
                grupdal.Save(context);
                Kaydedildi = true;

                this.Close();
            }
       
      
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}