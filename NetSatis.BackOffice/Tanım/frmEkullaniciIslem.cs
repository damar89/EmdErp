using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmEkullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.eKullaniciBilgileri _entity;
        private EkullaniciBilgileriDAL ekullaniciDal = new EkullaniciBilgileriDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;

        public frmEkullaniciIslem(Entities.Tables.eKullaniciBilgileri entity)
        {
            InitializeComponent();
            _entity=entity;
              txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false,
           DataSourceUpdateMode.OnPropertyChanged);
            txtSifre.DataBindings.Add("Text", _entity, "Sifre", false,
              DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ekullaniciDal.AddOrUpdate(context, _entity))
            {
                ekullaniciDal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}