using DevExpress.Data.Helpers;
using DevExpress.DataProcessing;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace NetSatis.BackOffice.Stok
{
    public partial class frmStokIslem : XtraForm
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private BarkodDAL barkodDal = new BarkodDAL();
        public NetSatisContext context;
        public bool saved = false;
        private CodeTool kodOlustur;
        private bool kaydetYeni = false;
        Control ctrl;
        bool guncelle = false;
        public frmStokIslem(Entities.Tables.Stok entity, bool kopyala = false)
        {
            InitializeComponent();
            context = new NetSatisContext();
            if (entity.Id != 0)
            {
                guncelle = true;
            }
            if (entity.StokKodu != null)
            {
                guncelle = true;
            }
            LoadComboBoxEditBindings();
            Olustur(entity, kopyala);
        }
        public frmStokIslem(ref NetSatisContext _context, Entities.Tables.Stok entity, bool kopyala = false)
        {
            InitializeComponent();
            this.context = _context;
            LoadComboBoxEditBindings();
            if (entity.Id != 0)
            {
                guncelle = true;
            }
            Olustur(entity, kopyala);

        }



        private void Olustur(Entities.Tables.Stok entity, bool kopyala = false)
        {
            kodOlustur = new CodeTool(this, CodeTool.Table.Stok);
            kodOlustur.BarButonOlustur();

            if (kopyala)
            {
                _entity = new Entities.Tables.Stok();
                _entity.Id = -1;
                _entity.StokKodu = "";
                _entity.Durumu = entity.Durumu;
                _entity.WebAcikMi = entity.WebAcikMi;
                //_entity.ResimUrl = entity.ResimUrl;
                _entity.BarkodTuru = entity.BarkodTuru;
                _entity.StokAdi = entity.StokAdi;
                _entity.Birim = entity.Birim;
                _entity.GarantiSuresi = entity.GarantiSuresi;
                _entity.MinmumStokMiktari = entity.MinmumStokMiktari;
                _entity.MaxmumStokMiktari = entity.MaxmumStokMiktari;
                _entity.Aciklama = entity.Aciklama;
                _entity.Kategori = entity.Kategori;
                var kategoriAdi = context.Kategoriler.SingleOrDefault(x => x.Kod == entity.Kategori);
                if (kategoriAdi != null)
                {
                    _entity.Kategori = entity.Kategori + " - " + kategoriAdi.KategoriAdi;
                }
                _entity.AnaGrup = entity.AnaGrup;
                var anagrupAdi = context.AnaGruplar.SingleOrDefault(x => x.Kod == entity.AnaGrup);
                if (anagrupAdi != null)
                {
                    _entity.AnaGrup = entity.AnaGrup + " - " + anagrupAdi.AnaGrupAdi;
                }
                _entity.AltGrup = entity.AltGrup;
                var altgrupAdi = context.AltGruplar.SingleOrDefault(x => x.Kod == entity.AltGrup);
                if (altgrupAdi != null)
                {
                    _entity.AltGrup = entity.AltGrup + " - " + altgrupAdi.AltGrupAdi;
                }
                _entity.Marka = entity.Marka;
                _entity.Uretici = entity.Uretici;
                _entity.Modeli = _entity.Modeli;
                _entity.Pozisyon = entity.Pozisyon;
                _entity.Proje = entity.Proje;
                _entity.SezonYil = entity.SezonYil;
                _entity.OzelKodu = entity.OzelKodu;
                _entity.AlisFiyati1 = entity.AlisFiyati1;
                _entity.AlisFiyati2 = entity.AlisFiyati2;
                _entity.AlisFiyati3 = entity.AlisFiyati3;
                _entity.AlisKdv = entity.AlisKdv;
                _entity.SatisKdv = entity.SatisKdv;
                _entity.Borsa = entity.Borsa;
                _entity.Bagkur = entity.Bagkur;
                _entity.Zirai = entity.Zirai;
                _entity.Mera = entity.Mera;
                _entity.SatisFiyati1 = entity.SatisFiyati1;
                _entity.SatisFiyati2 = entity.SatisFiyati2;
                _entity.SatisFiyati3 = entity.SatisFiyati3;
                _entity.SatisFiyati4 = entity.SatisFiyati4;
                _entity.WebSatisFiyati = entity.WebSatisFiyati;
                _entity.WebBayiSatisFiyati = entity.WebBayiSatisFiyati;
                _entity.Resim = entity.Resim;
            }
            else
            {
                _entity = entity;
                var kategoriAdi = context.Kategoriler.SingleOrDefault(x => x.Kod == entity.Kategori);
                if (kategoriAdi != null)
                {
                    _entity.Kategori = entity.Kategori + " - " + kategoriAdi.KategoriAdi;
                }
                var anagrupAdi = context.AnaGruplar.SingleOrDefault(x => x.Kod == entity.AnaGrup);
                if (anagrupAdi != null)
                {
                    _entity.AnaGrup = entity.AnaGrup + " - " + anagrupAdi.AnaGrupAdi;
                }
                var altgrupAdi = context.AltGruplar.SingleOrDefault(x => x.Kod == entity.AltGrup);
                if (altgrupAdi != null)
                {
                    _entity.AltGrup = entity.AltGrup + " - " + altgrupAdi.AltGrupAdi;
                }
            }
            //fiş işlemden gönderilen barkodu kaydet
            if (!kopyala && !string.IsNullOrEmpty(entity.Barkodu) && string.IsNullOrEmpty(_entity.Barkodu))
                _entity.Barkodu = entity.Barkodu;
            //btnYeni_Click(null, null);
            bindingSource();
            if (_entity.Resim != null)
            {
                Image img = byteArrayToImage(_entity.Resim);
                peResim.Image = img;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MakeItProperCase();

            var firstIndex = -1;

            if (btnKategori.Text != "")
            {
                firstIndex = btnKategori.Text.IndexOf(" - ");
                if (firstIndex >= 0)
                    btnKategori.Text = btnKategori.Text.Substring(0, firstIndex);
            }
            if (btnAnaGrup.Text != "")
            {
                firstIndex = btnAnaGrup.Text.IndexOf(" - ");
                if (firstIndex >= 0)
                    btnAnaGrup.Text = btnAnaGrup.Text.Substring(0, firstIndex);
            }
            if (btnAltGrup.Text != "")
            {
                firstIndex = btnAltGrup.Text.IndexOf(" - ");
                if (firstIndex >= 0)
                    btnAltGrup.Text = btnAltGrup.Text.Substring(0, firstIndex);
            }
            if (peResim.Image != null)
            {
                Image img = peResim.Image;
                _entity.Resim = imageToByteArray(img);
            }
            if (string.IsNullOrEmpty(txtKod.Text))
            {
                var kod = context.Kodlar.Where(c => c.Tablo == "Stok").First();
                txtKod.Text = CodeTool.fiskodolustur(kod.OnEki.ToString(), kod.SonDeger.ToString());
            }
            if (context.Barkodlar.Local.ToList().Count > 0)
            {
                if (string.IsNullOrEmpty(_entity.Barkodu) || string.IsNullOrWhiteSpace(_entity.Barkodu))
                    _entity.Barkodu = context.Barkodlar.Local.ToList()[0].Barkodu ?? "";
            }
            foreach (var barkod in context.Barkodlar.Local.ToList())
            {
                barkod.StokId = _entity.Id;
            }
            if (stokDal.AddOrUpdate(context, _entity))
            {
                if (calcDevirGirisi.EditValue != null && calcDevirGirisi.EditValue != "" && Convert.ToInt32(calcDevirGirisi.EditValue) != 0)
                {
                    Fis stokDevirFisi = new Fis();
                    var kod = context.Kodlar.Where(c => c.Tablo == "fis").First();
                    stokDevirFisi.FisKodu = CodeTool.fiskodolustur(kod.OnEki.ToString(), kod.SonDeger.ToString());
                    stokDevirFisi.FisTuru = "Stok Devir Fişi";
                    stokDevirFisi.Tarih = DateTime.Now;
                    stokDevirFisi.VadeTarihi = DateTime.Now;
                    context.Fisler.Add(stokDevirFisi);
                    CodeTool ct = new CodeTool();
                    ct.KodArttirma("fis");
                    StokHareket stokHar = new StokHareket();
                    stokHar.StokId = _entity.Id;
                    stokHar.Hareket = "Stok Giriş";
                    stokHar.FisKodu = stokDevirFisi.FisKodu;
                    stokHar.Miktar = Convert.ToDecimal(calcDevirGirisi.EditValue);
                    stokHar.Kdv = Convert.ToInt32(calcSatisKdv.EditValue);
                    stokHar.BirimFiyati = Convert.ToDecimal(_entity.AlisFiyati1);
                    int depoid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().DepoId);
                    stokHar.DepoId = depoid;

                    stokHar.Tarih = DateTime.Now;
                    stokHar.FisTuru = "Stok Devir Fişi";
                    decimal kdvToplam = 0, araToplam = 0, toplamTutar = 0;
                    if (stokHar.Kdv == 0)
                    {
                        araToplam = Convert.ToDecimal(stokHar.Miktar) * Convert.ToDecimal(stokHar.BirimFiyati);
                        kdvToplam = araToplam * (stokHar.Kdv / 100);
                        toplamTutar = araToplam + kdvToplam;
                    }
                    else
                    {
                        araToplam = Convert.ToDecimal(stokHar.Miktar) * Convert.ToDecimal(stokHar.BirimFiyati);
                        kdvToplam = araToplam - araToplam / ((100 + stokHar.Kdv) / 100);
                        toplamTutar = araToplam;
                    }
                    stokHar.KdvToplam = kdvToplam;
                    stokHar.AraToplam = araToplam;
                    stokHar.ToplamTutar = toplamTutar;
                    context.StokHareketleri.Add(stokHar);
                    context.SaveChanges();
                    Fis fis = context.Fisler.FirstOrDefault(x => x.Id == stokDevirFisi.Id);
                    if (fis != null)
                    {
                        stokDevirFisi.KdvToplam_ = kdvToplam;
                        stokDevirFisi.AraToplam_ = araToplam;
                        stokDevirFisi.ToplamTutar = toplamTutar;
                    }
                    context.SaveChanges();
                }
                kodOlustur.KodArttirma();
                stokDal.Save(context);
                calcDevirGirisi.Text = "";
                lblMiktar.Text = "";
                if (!kaydetYeni)
                {
                    this.Close();
                }
            }
            stokDal.Save(context);
            MessageBox.Show("Stok başarılı bir şekilde kaydedilmiştir.");
            if (!kaydetYeni)
            {
                this.Close();
            }
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmStokIslem_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi)))
            {
                layBagkur.Visibility =
                    layBorsa.Visibility =
                    layZirai.Visibility =
                    layMera.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            if (guncelle == true)
            {
                togDurum.EditValue = _entity.Durumu;
            }
            else
            {
                togDurum.EditValue = true;
            }
            //txtStokKodu.Text = _entity.Id == 0 ?
            //    CodeTool.KodOlustur("ST", SettingsTool.AyarOku(SettingsTool.Ayarlar.StokAyarlari_StokKodu)) : _entity.StokKodu;

            //togWeb.EditValue = false;
            txtKod.Focus();
        }
        private void txtBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Birim);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtBirim.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    txtBirim.Text = null;
                    break;
            }
        }
        private void btnKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmKategoriler form = new frmKategoriler(frmKategoriler.KategoriTuru.Kategori);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnKategori.Text = form._entity.Kod + " - " + form._entity.KategoriAdi;
                    }
                    break;
                case 2:
                    btnKategori.Text = null;
                    break;
            }
        }
        private void btnAnaGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    string kategori = "";
                    if (btnKategori.Text != "")
                    {
                        int firstIndex = btnKategori.Text.IndexOf(" - ");
                        if (firstIndex > -1)
                            kategori = btnKategori.Text.Substring(0, firstIndex);
                    }
                    frmAnaGruplar form = new frmAnaGruplar(kategori);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnAnaGrup.Text = form._entity.Kod + " - " + form._entity.AnaGrupAdi;
                    }
                    break;
                case 2:
                    btnAnaGrup.Text = null;
                    break;
            }
        }
        private void btnAltGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    string anagrup = "";
                    if (btnAnaGrup.Text != "")
                    {
                        int firstIndex = btnAnaGrup.Text.IndexOf(" - ");
                        if (firstIndex > -1)
                            anagrup = btnAnaGrup.Text.Substring(0, firstIndex);
                    }
                    frmAltGruplar form = new frmAltGruplar(anagrup);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnAltGrup.Text = form._entity.Kod + " - " + form._entity.AltGrupAdi;
                    }
                    break;
                case 2:
                    btnAltGrup.Text = null;
                    break;
            }
        }
        private void btnMarka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Marka);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnMarka.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnMarka.Text = null;
                    break;
            }
        }
        private void btnUretici_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Uretici);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnUretici.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnUretici.Text = null;
                    break;
            }
        }
        private void btnModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Model);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnModel.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnModel.Text = null;
                    break;
            }
        }
        private void btnProje_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Proje);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnProje.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnProje.Text = null;
                    break;
            }
        }
        private void btnPozisyon_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Pozisyon);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnPozisyon.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnPozisyon.Text = null;
                    break;
            }
        }
        private void btnSezonYil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.SezonYil);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnSezonYil.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnSezonYil.Text = null;
                    break;
            }
        }
        private void btnOzelKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.OzelKod);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod.Text = form._entity.Tanimi;
                    }
                    break;
                case 2:
                    btnOzelKod.Text = null;
                    break;
            }
        }
        private void gridBarkod_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = (Barkod)e.Row;

            if (context.Barkodlar.Count(c => c.Barkodu == row.Barkodu) != 0 || context.Barkodlar.Local.Count(c => c.Barkodu == row.Barkodu) != 0)
            {
                MessageBox.Show("Eklediğiniz Barkod Daha Önce Eklenmiş.");
                gridBarkod.CancelUpdateCurrentRow();
            }
            else if (row.Barkodu.Contains(" "))
            {
                MessageBox.Show("Barkod kullanımında özel karakterler kullanılamaz.");
                gridBarkod.CancelUpdateCurrentRow();
            }

        }
        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridBarkod.DeleteSelectedRows();
            }
        }
        private void frmStokIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btnBarkodEkle.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.L)
            {
                btnKaydetYeni.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.Y)
            {
                btnYeni.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void txtKod_KeyDown(object sender, KeyEventArgs e)
        {
            saved = true;
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok kodentity;
                //Entities.Tables.Barkod barkodEntity = context.Barkodlar.FirstOrDefault();
                kodentity = context.Stoklar.FirstOrDefault(c => c.Barkodu == txtKod.Text);
                if (kodentity == null)
                    kodentity = context.Barkodlar.FirstOrDefault(c => c.Barkodu == txtKod.Text)?.Stok;
                if (kodentity == null)
                {
                    kodentity = context.Stoklar.FirstOrDefault(c => c.StokKodu == txtKod.Text);
                }
                if (kodentity != null)
                {
                    btnYeni_Click(null, null);
                    _entity = kodentity;
                    bindingSource();
                    var kategoriAdi = context.Kategoriler.SingleOrDefault(x => x.Kod == _entity.Kategori);
                    if (kategoriAdi != null)
                    {
                        btnKategori.Text = _entity.Kategori + " - " + kategoriAdi.KategoriAdi;
                    }
                    var anagrupAdi = context.AnaGruplar.SingleOrDefault(x => x.Kod == _entity.AnaGrup);
                    if (anagrupAdi != null)
                    {
                        btnAnaGrup.Text = _entity.AnaGrup + " - " + anagrupAdi.AnaGrupAdi;
                    }
                    var altgrupAdi = context.AltGruplar.SingleOrDefault(x => x.Kod == _entity.AltGrup);
                    if (altgrupAdi != null)
                    {
                        btnAltGrup.Text = _entity.AltGrup + " - " + altgrupAdi.AltGrupAdi;
                    }
                }
                else
                {
                    MessageBox.Show("Barkod veya Stok Kodu Bulunamadı..");
                }
            }
        }
        private void bindingSource()
        {
            //context.Barkodlar.Local.Clear();
            context.Barkodlar.Where(c => c.StokId == _entity.Id).Load();
            togDurum.DataBindings.Clear();
            togWeb.DataBindings.Clear();
            txtKod.DataBindings.Clear();
            txtStokAdi.DataBindings.Clear();
            cmbBarkodTuru.DataBindings.Clear();
            txtBirim.DataBindings.Clear();
            btnKategori.DataBindings.Clear();
            //pictureBox1.DataBindings.Clear();
            btnAnaGrup.DataBindings.Clear();
            btnAltGrup.DataBindings.Clear();
            btnMarka.DataBindings.Clear();
            btnUretici.DataBindings.Clear();
            btnModel.DataBindings.Clear();
            btnProje.DataBindings.Clear();
            btnPozisyon.DataBindings.Clear();
            btnSezonYil.DataBindings.Clear();
            btnOzelKod.DataBindings.Clear();
            txtGaranti.DataBindings.Clear();
            calcAlisKdv.DataBindings.Clear();
            calcBorsa.DataBindings.Clear();
            calcBagkur.DataBindings.Clear();
            calcZirai.DataBindings.Clear();
            calcMera.DataBindings.Clear();
            calcSatisKdv.DataBindings.Clear();
            calcDevirGirisi.DataBindings.Clear();
            peResim.DataBindings.Clear();
            calcAlisFiyat1.DataBindings.Clear();
            calcAlisFiyat2.DataBindings.Clear();
            calcAlisFiyat3.DataBindings.Clear();
            calcSatisFiyat1.DataBindings.Clear();
            calcSatisFiyat2.DataBindings.Clear();
            calcSatisFiyat3.DataBindings.Clear();
            calcSatisFiyat4.DataBindings.Clear();
            calcWebSatisFiyat.DataBindings.Clear();
            calcwebBayiSatisFiyat.DataBindings.Clear();
            calcMinStokMiktari.DataBindings.Clear();
            calcMaxStokMiktari.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            togDurum.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            togWeb.DataBindings.Add("EditValue", _entity, "WebAcikMi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru", false,
                DataSourceUpdateMode.OnPropertyChanged);
            //pictureBox1.DataBindings.Add("Image", _entity, "ResimUrl", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBirim.DataBindings.Add("Text", _entity, "Birim", false, DataSourceUpdateMode.OnPropertyChanged);
            btnKategori.DataBindings.Add("Text", _entity, "Kategori", false, DataSourceUpdateMode.OnPropertyChanged);
            btnAnaGrup.DataBindings.Add("Text", _entity, "AnaGrup", false, DataSourceUpdateMode.OnPropertyChanged);
            btnAltGrup.DataBindings.Add("Text", _entity, "AltGrup", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            btnUretici.DataBindings.Add("Text", _entity, "Uretici", false, DataSourceUpdateMode.OnPropertyChanged);
            btnModel.DataBindings.Add("Text", _entity, "Modeli", false, DataSourceUpdateMode.OnPropertyChanged);
            btnProje.DataBindings.Add("Text", _entity, "Proje", false, DataSourceUpdateMode.OnPropertyChanged);
            btnPozisyon.DataBindings.Add("Text", _entity, "Pozisyon", false, DataSourceUpdateMode.OnPropertyChanged);
            btnSezonYil.DataBindings.Add("Text", _entity, "SezonYil", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod.DataBindings.Add("Text", _entity, "OzelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGaranti.DataBindings.Add("Text", _entity, "GarantiSuresi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv", false, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcBagkur.DataBindings.Add("Text", _entity, "Bagkur", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcBagkur.DataBindings[0].FormattingEnabled = true;
            calcBagkur.DataBindings[0].FormatString = "N2";
            calcBorsa.DataBindings.Add("Text", _entity, "Borsa", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcBorsa.DataBindings[0].FormattingEnabled = true;
            calcBorsa.DataBindings[0].FormatString = "N2";
            calcZirai.DataBindings.Add("Text", _entity, "Zirai", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcZirai.DataBindings[0].FormattingEnabled = true;
            calcZirai.DataBindings[0].FormatString = "N2";
            calcMera.DataBindings.Add("Text", _entity, "Mera", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            calcMera.DataBindings[0].FormattingEnabled = true;
            calcMera.DataBindings[0].FormatString = "N2";
            calcAlisFiyat1.DataBindings.Add("Text", _entity, "AlisFiyati1", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyat1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat1.DataBindings[0].FormatString = "C2";
            calcAlisFiyat2.DataBindings.Add("Text", _entity, "AlisFiyati2", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyat2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat2.DataBindings[0].FormatString = "C2";
            calcAlisFiyat3.DataBindings.Add("Text", _entity, "AlisFiyati3", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcAlisFiyat3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyat3.DataBindings[0].FormatString = "C2";
            calcSatisFiyat1.DataBindings.Add("Text", _entity, "SatisFiyati1", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat1.DataBindings[0].FormatString = "C2";
            calcSatisFiyat2.DataBindings.Add("Text", _entity, "SatisFiyati2", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat2.DataBindings[0].FormatString = "C2";
            calcSatisFiyat3.DataBindings.Add("Text", _entity, "SatisFiyati3", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat3.DataBindings[0].FormatString = "C2";
            //-------
            calcSatisFiyat4.DataBindings.Add("Text", _entity, "SatisFiyati4", false,
               DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat4.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat4.DataBindings[0].FormatString = "C2";
            calcWebSatisFiyat.DataBindings.Add("Text", _entity, "WebSatisFiyati", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcWebSatisFiyat.DataBindings[0].FormattingEnabled = true;
            calcWebSatisFiyat.DataBindings[0].FormatString = "C2";
            calcwebBayiSatisFiyat.DataBindings.Add("Text", _entity, "WebBayiSatisFiyati", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcwebBayiSatisFiyat.DataBindings[0].FormattingEnabled = true;
            calcwebBayiSatisFiyat.DataBindings[0].FormatString = "C2";
            // -------
            calcMinStokMiktari.DataBindings.Add("Text", _entity, "MinmumStokMiktari", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcMinStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMinStokMiktari.DataBindings[0].FormatString = "N";
            calcMaxStokMiktari.DataBindings.Add("Text", _entity, "MaxmumStokMiktari", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcMaxStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktari.DataBindings[0].FormatString = "N";
            gridContBarkod.DataSource = context.Barkodlar.Local.ToBindingList();
            if (guncelle == true)
            {
                _entity.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                _entity.EditUser = frmAnaMenu.UserId;
            }
            else
            {
                _entity.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                _entity.SaveUser = frmAnaMenu.UserId;
            }
            var r = stokDal.StokAdetler(context, _entity.Id);
            if (r.HasValue)
                lblMiktar.Text = r.Value.ToString("n2");
        }
        private void btnKaydetYeni_Click(object sender, EventArgs e)
        {
            kaydetYeni = true;
            btnKaydet_Click(null, null);
            kaydetYeni = false;
            btnYeni_Click(null, null);
            togDurum.EditValue = true;
            togWeb.EditValue = false;
            txtKod.Focus();
            calcDevirGirisi.Text = "";
            lblMiktar.Text = "";
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Entities.Tables.Stok s = new Entities.Tables.Stok();
            context = new NetSatisContext();
            Olustur(s, false);
            int rowCount = gridBarkod.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                gridBarkod.DeleteRow(i);
            }
            //context.Barkodlar.Local.Clear();
            calcDevirGirisi.Text = "";
            togDurum.EditValue = true;
            togWeb.EditValue = false;
            lblMiktar.Text = "";
            txtKod.Focus();
        }
        private void gridBarkod_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }
        private void btnBarkodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void frmStokIslem_Shown(object sender, EventArgs e)
        {
            txtKod.Focus();
        }
        private void txtBirim_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string UserText = txtBirim.Text;
            if (e.Button.Index == 1)
            {
                if (txtBirim.Properties.Items.Contains(UserText) == false)
                    txtBirim.Properties.Items.Add(UserText);
            }
            else if (e.Button.Index == 2)
            {
                txtBirim.Properties.Items.Remove(UserText);
                txtBirim.EditValue = null;
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void txtStokAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                txtStokAdi.PerformClick(txtStokAdi.Properties.Buttons[0]);
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtBirim;
            }

        }
        private void txtBirim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtGaranti;
            }
        }
        private void txtGaranti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcMinStokMiktari;
            }
        }
        private void calcMinStokMiktari_KeyDown(object sender, KeyEventArgs e)
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
                this.ActiveControl = calcMaxStokMiktari;
            }
        }
        private void calcMaxStokMiktari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnKategori;
            }
        }
        private void btnKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnAnaGrup;
            }
        }
        private void btnAnaGrup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnAltGrup;
            }
        }
        private void btnAltGrup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnMarka;
            }
        }
        private void btnMarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnUretici;
            }
        }
        private void btnUretici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnModel;
            }
        }
        private void btnModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnProje;
            }
        }
        private void btnProje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnPozisyon;
            }
        }
        private void btnPozisyon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnSezonYil;
            }
        }
        private void btnSezonYil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnOzelKod;
            }
        }
        private void btnOzelKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcSatisKdv;
            }
        }
        private void calcSatisKdv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcAlisFiyat1;
            }
        }
        private void calcAlisFiyat1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcAlisFiyat2;
            }
        }
        private void calcAlisFiyat2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcAlisFiyat3;
            }
        }
        private void calcAlisFiyat3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcSatisFiyat1;
            }
        }
        private void calcSatisFiyat1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcSatisFiyat2;
            }
        }
        private void calcSatisFiyat2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcSatisFiyat3;
            }
        }
        private void calcSatisFiyat3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcSatisFiyat4;
            }
        }
        private void btnYeni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnKaydetYeni;
            }
        }
        private void btnKaydetYeni_KeyDown(object sender, KeyEventArgs e)
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
        private void btnKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = cmbBarkodTuru;
            }
        }
        private void cmbBarkodTuru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtStokAdi;
            }
        }
        private void txtKod_Click(object sender, EventArgs e)
        {
            //    frmStokSec form = new frmStokSec(ref this.context, txtKod.EditValue.ToString());
            //    form.ShowDialog();
            //    if (form.secildi)
            //    {
            //        //Buradan
            //        var enti = form.secilen.First();
            //        //Buraya kadar
            //        Olustur(enti,false);
        }
        private void calcSatisFiyat4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcWebSatisFiyat;
            }
        }
        private void calcWebSatisFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = calcwebBayiSatisFiyat;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = -1;
            StokHareketDAL dal = new StokHareketDAL();
            using (Entities.Context.NetSatisContext db = new Entities.Context.NetSatisContext())
            {
                var list = db.Stoklar.Where(x => x.StokKodu == txtKod.Text).FirstOrDefault();
                secilen = list.Id;
            }
            var hareket = dal.GetAll(context, c => c.StokId == secilen);
            if (hareket.Count > 0)
            {
                MessageBox.Show("Hareket görmüş bir stok silinemez.");
                return;
            }
            barkodDal.Delete(context, c => c.StokId == secilen);
            barkodDal.Save(context); stokDal.Delete(context, c => c.Id == secilen);
            stokDal.Save(context);
            MessageBox.Show("Stok başarılı bir şekilde silinmiştir..");
            btnYeni_Click(null, null);
            togDurum.EditValue = true;
            togWeb.EditValue = false;
            txtKod.Focus();
            calcDevirGirisi.Text = "";
        }

        private void calcAlisFiyat1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }
        delegate void EditorSelectAllProc(Control c);
        void EditorSelectAll(Control c)
        {
            ((TextBox)c.Controls[0]).SelectAll();
        }

        private void calcSatisFiyat1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcSatisFiyat2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcSatisFiyat3_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcSatisFiyat4_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcWebSatisFiyat_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcwebBayiSatisFiyat_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void txtStokAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "find")
            {

                frmStokSec form = new frmStokSec(ref this.context, txtStokAdi.EditValue.ToString(), false);
                form.ShowDialog();
                if (form.secildi)
                {
                    //Buradan
                    var enti = form.secilen.First();
                    //Buraya kadar
                    Olustur(enti, false);
                }
            }
            else if (e.Button.Tag.ToString() == "clear")
            {
                txtStokAdi.Tag =
                    txtStokAdi.Text = null;
            }
        }

        private void btnBarkodEkle_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage2;
            gridContBarkod.Focus();
            gridContBarkod.Select();
            gridBarkod.Focus();
            gridBarkod.FocusedRowHandle = GridControl.NewItemRowHandle;
            gridBarkod.FocusedColumn = gridBarkod.Columns["Barkodu"];

        }

        void MakeItProperCase()
        {
            if (txtStokAdi.Text.Trim() != String.Empty)
            {
                TextInfo myTI = new CultureInfo("tr-TR", false).TextInfo;
                txtStokAdi.Text = myTI.ToTitleCase(txtStokAdi.Text);
            }
        }

        private void txtStokAdi_Leave(object sender, EventArgs e)
        {
            MakeItProperCase();
        }

        #region gruplar için combobox için kateogri ve grupların yüklenmesi işlemi 

        void ComboboxEditDataBindingTanimlar(object sender, frmTanim.TanimTuru tur)
        {
            var obj = (ComboBoxEdit)sender;

            var res = context.Tanimlar.Where(x => x.Turu == tur.ToString());

            res.ForEach(x =>
            {
                if (x.Tanimi != string.Empty)
                    obj.Properties.Items.Add(x.Tanimi);
            });

        }

        void LoadComboBoxEditBindings()
        {
            var res1 = context.Kategoriler.ToList();
            res1.ForEach(x =>
            {
                if (x.KategoriAdi != string.Empty)
                    btnKategori.Properties.Items.Add(x.KategoriAdi);

            });
            var res2 = context.AnaGruplar.ToList();
            res2.ForEach(x =>
            {
                if (x.AnaGrupAdi != string.Empty)
                    btnAnaGrup.Properties.Items.Add(x.AnaGrupAdi);

            });
            var res3 = context.AltGruplar.ToList();
            res3.ForEach(x =>
            {
                if (x.AltGrupAdi != string.Empty)
                    btnAltGrup.Properties.Items.Add(x.AltGrupAdi);

            });

            ComboboxEditDataBindingTanimlar(btnMarka, frmTanim.TanimTuru.Marka);
            ComboboxEditDataBindingTanimlar(btnUretici, frmTanim.TanimTuru.Uretici);
            ComboboxEditDataBindingTanimlar(btnModel, frmTanim.TanimTuru.Model);
            ComboboxEditDataBindingTanimlar(btnProje, frmTanim.TanimTuru.Proje);
            ComboboxEditDataBindingTanimlar(btnPozisyon, frmTanim.TanimTuru.Pozisyon);
            ComboboxEditDataBindingTanimlar(btnSezonYil, frmTanim.TanimTuru.SezonYil);
            ComboboxEditDataBindingTanimlar(btnOzelKod, frmTanim.TanimTuru.OzelKod);

        }

        #endregion

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption.Equals("Barkod Oluştur"))
            {
                //var _cBarkod = new Barkod();
                //_cBarkod.Barkodu= 
                gridBarkod.BarkodEkle(colBarkod);
                //context.Barkodlar.Local.Add(_cBarkod)

            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gridBarkod_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName.Equals("Barkodu"))
            {

                var row = (Barkod)gridBarkod.GetRow(e.RowHandle);
                if (context.Barkodlar.Any(c => c.Barkodu == row.Barkodu) || context.Barkodlar.Local.Any(c => c.Barkodu == row.Barkodu))
                {
                    MessageBox.Show("Eklediğiniz Barkod Daha Önce Eklenmiş.");
                    gridBarkod.CancelUpdateCurrentRow();
                }
                else if (row.Barkodu.Contains(" "))
                {
                    MessageBox.Show("Barkod kullanımında özel karakterler kullanılamaz.");
                    gridBarkod.CancelUpdateCurrentRow();
                }
            }
        }
    }
}
