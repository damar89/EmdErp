using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Personel
{
    public partial class frmPersonelIslem : Form
    {
        private Entities.Tables.Personel _entity;
        private PersonelDal personelDal = new PersonelDal();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;

        public frmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            togCalisiyor.DataBindings.Add("EditValue", _entity, "Calisiyor", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtUnvani.DataBindings.Add("Text", _entity, "Unvani", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtTcNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbGirisTarih.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged,null,"F");
            cmbCikisTarih.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged,null,"F");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtCepTel.DataBindings.Add("Text", _entity, "CepTelefonu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "EMail", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbAylikMaas.DataBindings.Add("EditValue", _entity, "AylikMaasi", true,
                DataSourceUpdateMode.OnPropertyChanged,0,"C2");
            cmbPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", true,
                DataSourceUpdateMode.OnPropertyChanged,0,"'%'0");



        }

        private void frmPersonelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDal.AddOrUpdate(context,_entity))
            {
                saved = true;
                personelDal.Save(context);
                this.Close();
            }
        }

        private void cmbGirisTarih_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                cmbGirisTarih.DateTime = DateTime.Now;
            }
        }

        private void cmbCikisTarih_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                cmbCikisTarih.DateTime = DateTime.Now;
            }
        }

        private void txtUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.PersonelUnvan);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtUnvani.Text = form._entity.Tanimi; 
                    }
                   
                    break;
                case 1:
                    txtUnvani.Text = null;
                    break;

            }
        }

        private void frmPersonelIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
