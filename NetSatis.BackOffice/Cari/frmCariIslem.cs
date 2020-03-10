using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using System;
using System.Windows.Forms;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        private CodeTool kodOlustur;
        public frmCariIslem(Entities.Tables.Cari entity, bool kopyala = false)
        {
            InitializeComponent();
            kodOlustur = new CodeTool(this, CodeTool.Table.Cari);
            kodOlustur.BarButonOlustur();
            if (kopyala)
            {
                _entity = new Entities.Tables.Cari();
                _entity.Id = -1;
                _entity.CariKodu = "";
                _entity.Aciklama = entity.Aciklama;
                _entity.CariSinif = entity.CariSinif;
                _entity.Adres = entity.Adres;
                _entity.AlisOzelFiyati = entity.AlisOzelFiyati;
                _entity.CariAdi = entity.CariAdi;
                _entity.CariAltGrubu = entity.CariAltGrubu;
                _entity.CariGrubu = entity.CariGrubu;
                _entity.CariTuru = entity.CariTuru;
                _entity.CepTelefonu = entity.CepTelefonu;
                _entity.CepTelefonu2 = entity.CepTelefonu2;
                _entity.CepTelefonu3 = entity.CepTelefonu3;
                _entity.Durum = entity.Durum;
                _entity.EMail = entity.EMail;
                _entity.FaturaUnvani = entity.FaturaUnvani;
                _entity.Fax = entity.Fax;
                _entity.Il = entity.Il;
                _entity.Ilce = entity.Ilce;
                _entity.IskontoOrani = entity.IskontoOrani;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.SatisOzelFiyati = entity.SatisOzelFiyati;
                _entity.Telefon = entity.Telefon;
                _entity.Semt = entity.Semt;
                _entity.VergiNo = entity.VergiNo;
                _entity.VergiDairesi = entity.VergiDairesi;
                _entity.YetkiliKisi = entity.YetkiliKisi;
                _entity.Web = entity.Web;
            }
            else
            {
                _entity = entity;
            }
            togDurum.DataBindings.Add("EditValue", _entity, "Durum", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "CariKodu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbSinif.DataBindings.Add("Text", _entity, "CariSinif", false,
               DataSourceUpdateMode.OnPropertyChanged);
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtCepTel.DataBindings.Add("Text", _entity, "CepTelefonu", false,
                DataSourceUpdateMode.OnPropertyChanged);
                txtCepTel2.DataBindings.Add("Text", _entity, "CepTelefonu2", false,
                DataSourceUpdateMode.OnPropertyChanged);
                txtCepTel3.DataBindings.Add("Text", _entity, "CepTelefonu3", false,
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
            txtCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtOzelkod1.DataBindings.Add("Text", _entity, "OzelKod1", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtOzelkod2.DataBindings.Add("Text", _entity, "OzelKod2", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtOzelkod3.DataBindings.Add("Text", _entity, "OzelKod3", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtOzelkod4.DataBindings.Add("Text", _entity, "OzelKod4", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcIskonto.DataBindings.Add("Text", _entity, "IskontoOrani", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcIskonto.DataBindings[0].FormattingEnabled = true;
            calcIskonto.DataBindings[0].FormatString = "N2";
            calcIskonto.DataBindings[0].DataSourceNullValue = "0";
       
          
            calcRisklimit.DataBindings.Add("Text", _entity, "RiskLimiti", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcRisklimit.DataBindings[0].FormattingEnabled = true;
            calcRisklimit.DataBindings[0].FormatString = "C2";
            calcRisklimit.DataBindings[0].DataSourceNullValue = "0";
            calcRisklimit.DataBindings[0].FormattingEnabled = true;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                kodOlustur.KodArttirma();
                cariDal.Save(context);
                saved = true;
                MessageBox.Show("Kayıt İşlemi Tamamlanmıştır.");
                this.Close();
            }
            cariDal.Save(context);
        }
        private void frmCariIslem_Load(object sender, EventArgs e)
        {
            //txtCariKodu.Text = _entity.Id==0?
            //    CodeTool.KodOlustur("CK", SettingsTool.AyarOku(SettingsTool.Ayarlar.CariAyarlari_CariKodu)):_entity.CariKodu;
            togDurum.EditValue = true;
        }
        private void txtCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtCariGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtCariGrubu.Text = null;
                    break;
            }
        }
        private void txtOzelkod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod1);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtOzelkod1.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelkod1.Text = null;
                    break;
            }
        }
        private void txtOzelkod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod2);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtOzelkod2.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelkod2.Text = null;
                    break;
            }
        }
        private void txtOzelkod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod3);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtOzelkod3.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelkod3.Text = null;
                    break;
            }
        }
        private void txtOzelkod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod4);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtOzelkod4.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtOzelkod4.Text = null;
                    break;
            }
        }
        private void txtAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariAltGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtAltGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtAltGrubu.Text = null;
                    break;
            }
        }
        private void frmCariIslem_KeyDown(object sender, KeyEventArgs e)
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
        private void txtKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.Show();
        }
        private void txtKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtCariAdi;
            }
        }
        //private void btnKod_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.ActiveControl = txtCariAdi;
        //    }
        //}
        private void txtCariAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtYetkiliKisi;
            }
        }
        private void txtYetkiliKisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtFaturaUnvani;
            }
        }
        private void txtFaturaUnvani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtVergiDairesi;
            }
        }
        private void txtVergiDairesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtVergiNo;
            }
        }
        private void txtVergiNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtAciklama;
            }
        }
        private void txtAciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtCepTel;
            }
        }
        private void txtCepTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtFax;
            }
        }
        private void txtFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtAdres;
            }
        }
        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtTelefon;
            }
        }
        private void txtTelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtEmail;
            }
        }
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtWeb;
            }
        }
        private void txtWeb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtIl;
            }
        }
        private void txtIl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtIlce;
            }
        }
        private void txtIlce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtSemt;
            }
        }
        private void txtSemt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtCariGrubu;
            }
        }
        private void txtCariGrubu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtOzelkod1;
            }
        }
        private void txtOzelkod1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtOzelkod2;
            }
        }
        private void txtAltGrubu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtOzelkod3;
            }
        }
        private void txtOzelkod3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtOzelkod4;
            }
        }
        private void txtOzelkod2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtAltGrubu;
            }
        }
        private void txtOzelkod4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcIskonto;
            }
        }
        private void calcIskonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcRisklimit;
            }
        }
        private void calcRisklimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnKaydet;
            }
        }
        private void btnKaydet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnKapat;
            }
        }
    }
}
