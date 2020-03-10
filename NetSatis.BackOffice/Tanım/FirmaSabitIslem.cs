using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class FirmaSabitIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.FirmaSabitleri _entity;
        private FirmaSabitDAL firmaSabitDAL=new FirmaSabitDAL();
        private NetSatisContext context=new NetSatisContext();
        public bool Kaydedildi = false;
    
        public FirmaSabitIslem(Entities.Tables.FirmaSabitleri entity)
        {
            InitializeComponent();
            _entity = entity;
            txtFirmaAdi.DataBindings.Add("Text", _entity, "FirmaAdi", false,
           DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtMail.DataBindings.Add("Text", _entity, "Mail", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtUlke.DataBindings.Add("Text", _entity, "Ulke", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false,
            DataSourceUpdateMode.OnPropertyChanged);
              txtPostaKodu.DataBindings.Add("Text", _entity, "PostaKodu", false,
            DataSourceUpdateMode.OnPropertyChanged);
              txtMersisNo.DataBindings.Add("Text", _entity, "MersisNo", false,
            DataSourceUpdateMode.OnPropertyChanged);
              txtScilNo.DataBindings.Add("Text", _entity, "TicariSicilNo", false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (firmaSabitDAL.AddOrUpdate(context, _entity))
            {
                firmaSabitDAL.Save(context);
                this.Close();
            }
        }
    }
}