using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmFisTransfer : XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisAyarlari ayarlar = new FisAyarlari();
        FisDAL fisDal = new FisDAL();

        MasrafHareketDAL masrafHareketDal = new MasrafHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();
        CariDAL cariDal = new CariDAL();
        DepoDAL depoDal = new DepoDAL();
        private int? _cariId;
        Fis _fisentity = new Fis();
        CariBakiye _entityBakiye = new CariBakiye();
        private CodeTool kodOlustur;

        CariBakiye entityBakiye = new CariBakiye();
        private Entities.Tables.Cari _entity;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\FisIslemSavedLayout.xml";

        public frmFisTransfer(string fisKodu = null, string fisTuru = null, bool cariGetir = false,
            Entities.Tables.Cari entity = null)
        {
            InitializeComponent();
            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            lookDepoGiris.Properties.DataSource = depoDal.GetAll(context);
            lookdDepoCikis.Properties.DataSource = depoDal.GetAll(context);
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            kodOlustur.BarButonOlustur();


            //context.Configuration.AutoDetectChangesEnabled = true;


            cmbTarih.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;



            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();

            }


            _fisentity.FisTuru = fisTuru;
            _fisentity.Tarih = DateTime.Now;
            _fisentity.VadeTarihi = DateTime.Now;


            //_fisentity.FisKodu =
            //    CodeTool.KodOlustur("FS", SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu));


            if (fisTuru == "Toptan Satış Faturası" || fisTuru == "Perakende Satış Faturası" ||
                fisTuru == "Satış İade Faturası" || fisTuru == "Alış İade Faturası" || fisTuru == "Alış Faturası" ||
                fisTuru == "Satış İrsaliyesi" || fisTuru == "Alış İrsaliyesi" || fisTuru == "Alınan Sipariş Fişi" ||
                fisTuru == "Verilen Sipariş Fişi" || fisTuru == "Alınan Teklif Fişi" ||
                fisTuru == "Verilen Teklif Fişi" || fisTuru == "Sayım Fazlası Fişi" || fisTuru == "Sayım Eksiği Fişi" ||
                fisTuru == "Stok Devir Fişi" || fisTuru == null)
            {
                context.Stoklar.Load();
                context.Depolar.Load();
                context.Kasalar.Load();
            }
            else
            {
                context.Kasalar.Load();
                context.Depolar.Load();
            }
            //cari getirme alanı
            if (cariGetir)
            {
                entityBakiye = this.cariDal.cariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisentity.CariId = entity.Id;

            }

            txtKod.DataBindings.Add("Text", _fisentity, "FisKodu", false,
            DataSourceUpdateMode.OnPropertyChanged);
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", true,
                DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);





            FisAyar();
            Toplamlar();
            OdenenTutarGuncelle();
            ButonlariYukle();
            MustahsilPanel();
            //OdenenTutarGuncelle();
            //cari getirme alanı


        }

        private void MustahsilPanel()
        {

            labelkdvToplam.Text = "Kdv Toplam :";


            if (context.StokHareketleri.Local.ToBindingList().Count > 0)
                foreach (var hareket in context.StokHareketleri.Local.ToBindingList())
                {
                    var s = context.Stoklar.FirstOrDefault(x => x.Id == hareket.StokId);
                    if (s != null) hareket.Kdv = s.SatisKdv;
                }


            //gridStokHareket.RefreshData();
            Toplamlar();

        }

        //personel ve ödeme türü eklemek için buton oluşturma
        private void ButonlariYukle()
        {
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 35,
                    Width = 92
                };
                buton.Click += OdemeEkle_Click;
            }

            var PersonelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 35,
                Width = 92,
                Checked = _fisentity.PlasiyerId == null
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;

            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 35,
                    Width = 92,
                    Checked = item.Id == _fisentity.PlasiyerId
                };
                buton.Click += PersonelYukle_Click;

            }
        }

        private void PersonelYukle_Click(object sender, EventArgs e)
        {
            var buton = sender as CheckButton;
            if (buton.Name == "Yok")
            {
                _fisentity.PlasiyerId = null;
            }
            else
            {
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Name);
            }

        }


        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            //if (txtFisTuru.Text == "Masraf Fişi")
            //{
            //    frmMasrafEkrani frm = new frmMasrafEkrani(Convert.ToInt32(buton.Tag));
            //    frm.ShowDialog();
            //    if (frm.entity != null)
            //    {
            //        kasaHareketDal.AddOrUpdate(context, frm.entity);

            //    }
            //    else
            //    {
            if (ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi" && txtFisTuru.Text != "Masraf Fişi")
            {
                frmOdemeEkrani form = new frmOdemeEkrani(Convert.ToInt32(buton.Tag));
                form.ShowDialog();
                if (form.entity != null)
                {
                    kasaHareketDal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }


            }
            else if (txtFisTuru.Text == "Masraf Fişi")
            {
                frmMasrafEkrani form = new frmMasrafEkrani(Convert.ToInt32(buton.Tag));
                form.ShowDialog();
                if (form.entity != null)
                {
                    kasaHareketDal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }
            }

            else
            {





                if (txtFisTuru.Text != "Hakediş Fişi")
                {
                    int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().KasaId);
                    KasaHareket entityKasaHareket = new KasaHareket
                    {
                        OdemeTuruId = Convert.ToInt32(buton.Tag),

                        KasaId = kasaid,

                        Tarih = Convert.ToDateTime(cmbTarih.DateTime),

                    };
                    kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                    OdenenTutarGuncelle();
                }



            }
        }

        private void FisAyar()
        {

            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";

                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.SatisEkrani = true;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProformaFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 0;
                    lblBaslik.Text = "Alış Faturası";

                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProformaFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Perakende Satış Faturası";

                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi)))
                    {
                        btnMuhtahsil.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    else
                    {
                        btnMuhtahsil.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProformaFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Toptan Satış Faturası";
                    lblBaslik.Appearance.ImageIndex = 2;


                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProformaFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Alış İade Faturası";
                    lblBaslik.Appearance.ImageIndex = 3;

                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProformaFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Satış İade Faturası";
                    lblBaslik.Appearance.ImageIndex = 4;

                    break;
                case "Satış İrsaliyesi":
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblBaslik.Text = "Satış İrsaliyesi";

                    break;
                case "Alış İrsaliyesi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    lblBaslik.Text = "Alış İrsaliyesi";

                    break;
                case "Alınan Sipariş Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    lblBaslik.Text = "Alınan Sipariş Fişi";
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    break;
                case "Verilen Sipariş Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.SatisEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    lblBaslik.Text = "Verilen Sipariş Fişi";

                    break;
                case "Alınan Teklif Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.SatisEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblBaslik.Text = "Alınan Teklif Fişi";

                    break;
                case "Verilen Teklif Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.SatisEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblBaslik.Text = "Verilen Teklif Fişi";

                    break;

                case "Sayım Eksiği Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Giriş";
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    ayarlar.OdemeEkrani = false;

                    ayarlar.SatisEkrani = true;

                    lblBaslik.Text = "Sayım Eksiği Fişi";
                    lblBaslik.Appearance.ImageIndex = 5;

                    break;
                case "Sayım Fazlası Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Çıkış";
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 6;
                    lblBaslik.Text = "Sayım Fazlası Fişi";

                    break;
                case "Stok Devir Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Giriş";
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnIrsaliyeYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturaYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSiparisYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnBilgiFisiYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnTeklifYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 7;
                    lblBaslik.Text = "Stok Devir Fişi";
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = false;
                    btnOdemeFisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navSatisEkrani.Dispose();
                    panelControl3.Visible = false;
                    panelkdv.Visible = false;
                    lblBaslik.Text = "Tahsilat Fişi";
                    break;
                case "Masraf Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = false;
                    btnOdemeFisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navSatisEkrani.Dispose();

                    panelkdv.Visible = false;
                    lblBaslik.Text = "Masraf Fişi";
                    break;

            }
        }

        private void OdenenTutarGuncelle()
        {

        }

        private void frmFisTransfer_Load(object sender, EventArgs e)
        {

            OdenenTutarGuncelle();
            Toplamlar();
        }


        private StokHareket StokSec(Entities.Tables.Stok entity)
        {



            StokHareket stokHareket = new StokHareket();
            IndirimDal indirimDal = new IndirimDal();
            var Barkod = context.Barkodlar.FirstOrDefault(c => c.StokId == entity.Id);
            stokHareket.StokId = entity.Id;
            int depoid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().DepoId);
            stokHareket.DepoId = depoid;


            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);


            stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;


            stokHareket.Mera = txtFisTuru.Text == "Toptan Satış Faturası" && entity.Mera != null ? entity.Mera : 0;
            stokHareket.Borsa = txtFisTuru.Text == "Toptan Satış Faturası" && entity.Borsa != null ? entity.Borsa : 0;
            stokHareket.Bagkur = txtFisTuru.Text == "Toptan Satış Faturası" && entity.Bagkur != null ? entity.Bagkur : 0;
            stokHareket.Zirai = txtFisTuru.Text == "Toptan Satış Faturası" && entity.Zirai != null ? entity.Zirai : 0;

            stokHareket.Mera = txtFisTuru.Text == "Alış Faturası" && entity.Mera != null ? entity.Mera : 0;
            stokHareket.Borsa = txtFisTuru.Text == "Alış Faturası" && entity.Borsa != null ? entity.Borsa : 0;
            stokHareket.Bagkur = txtFisTuru.Text == "Alış Faturası" && entity.Bagkur != null ? entity.Bagkur : 0;
            stokHareket.Zirai = txtFisTuru.Text == "Alış Faturası" && entity.Zirai != null ? entity.Zirai : 0;

            stokHareket.Miktar = calcMiktar.Value;
            stokHareket.Tarih = Convert.ToDateTime(cmbTarih.DateTime);
            return stokHareket;
        }
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            //int kalemSayisi = context.StokHareketleri.Local.ToBindingList().Count;
            //if (kalemSayisi == 36 && _fisentity.FisTuru == "Toptan Satış Faturası")
            //{
            //    MessageBox.Show(
            //        "Bir fatura için kullanılabilecek maksimum kalem sayısına ulaştınız. Başka bir ürün eklemesi yapamazsınız. Ürün eklemeye devam etmek için ikinci bir fatura oluşturmanız gerekmektedir.");
            //    return;

            //}

            txtBarkod.Text = null;

            frmStokSec form = new frmStokSec(ref this.context, false);
            form.ShowDialog();
            if (form.secildi)
            {
                //Buradan
                var enti = form.secilen.First();
                if (MinStokAltinda(enti)) return;
                //Buraya kadar

                StokHareket s = StokSec(enti);
                if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                {
                    s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                    s.Miktar = s.Miktar + calcMiktar.Value;

                }
                stokHareketDal.AddOrUpdate(context, s);
                Toplamlar();
                calcMiktar.Value = 1;
            }



        }

        //Buradan
        private decimal MevcutStokAdedi(Entities.Tables.Stok entity)

        {
            decimal MevcutStok = (context.StokHareketleri.Where(c => c.StokId == entity.Id && c.Hareket == "Stok Giriş")
                                      .Sum(c => c.Miktar) ?? 0) -
                                 (context.StokHareketleri.Where(c => c.StokId == entity.Id && c.Hareket == "Stok Çıkış")
                                      .Sum(c => c.Miktar) ?? 0);
            return MevcutStok;

        }

        private bool MinStokAltinda(Entities.Tables.Stok entity)
        {
            decimal adet = MevcutStokAdedi(entity);
            decimal minAdet = Convert.ToDecimal(entity.MinmumStokMiktari);
            var EksiKontrol = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisStok_EksiyeDusme));
            var MinKontrol = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisStok_MinMiktar));
            if (entity.MinmumStokMiktari != null && adet == minAdet && MinKontrol)
            {
                //Eğer minimum stok miktarına ulaşmışsa
                if (StokMinimumKontrolMesaj(
                        "Seçtiğiniz Stok Zaten Minimum Stok Miktarına Ulaşmış. İşleme Devam Etmek İstiyor musunuz?") !=
                    DialogResult.Yes) return true;

            }
            else if (adet < 0 && EksiKontrol)
            {//Eğer stok eksiye düşmüş ise
                if (StokMinimumKontrolMesaj(
                        "Seçtiğiniz Stok Zaten Eksi Miktara Düşmüştür.İşleme Devam Etmek İstiyor musunuz?") !=
                    DialogResult.Yes) return true;
            }
            else if (entity.MinmumStokMiktari != null && adet < minAdet && MinKontrol)
            {
                //eğer stok minimum stok miktarının altına düşmüş ise
                if (StokMinimumKontrolMesaj(
                        "Seçtiğiniz Stok Zaten Minimum Stok Miktarının Altındadır. İşleme Devam Etmek İstiyor musunuz?") !=
                    DialogResult.Yes) return true;
            }

            return false;
        }

        public DialogResult StokMinimumKontrolMesaj(string mesaj)
        {
            return XtraMessageBox.Show(mesaj, "Minimum Stok Kontrolü", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
        }
        //Buraya Kadar

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            //int kalemSayisi = context.StokHareketleri.Local.ToBindingList().Count;
            //if (kalemSayisi == 35 && _fisentity.FisTuru == "Toptan Satış Faturası")
            //{
            //    MessageBox.Show(
            //        "Bir fatura için kullanılabilecek maksimum kalem sayısına ulaştınız. Başka bir ürün eklemesi yapamazsınız. Ürün eklemeye devam etmek için ikinci bir fatura oluşturmanız gerekmektedir.");
            //    return;

            //}


            if (e.KeyCode == Keys.Enter)
            {
                Barkod entity;
                var entityStok = context.Stoklar.FirstOrDefault(x => x.Barkodu == txtBarkod.Text);

                if (entityStok != null)
                {

                    if (MinStokAltinda(entityStok)) return;
                    StokHareket s = StokSec(entityStok);
                    if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                    {
                        s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                        s.Miktar = s.Miktar + calcMiktar.Value;
                    }
                    stokHareketDal.AddOrUpdate(context, s);
                    Toplamlar();
                }
                else
                {
                    entity = context.Barkodlar.Where(c => c.Barkodu == txtBarkod.Text).SingleOrDefault();
                    if (entity != null)
                    {
                        if (MinStokAltinda(entity.Stok)) return; StokHareket s = StokSec(entity.Stok);
                        if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                        {
                            s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                            s.Miktar = s.Miktar + calcMiktar.Value;
                        }
                        stokHareketDal.AddOrUpdate(context, s);
                        Toplamlar();


                    }
                    else
                    {
                        MessageBox.Show("Barkod Bulunamadı..");
                    }
                }

                txtBarkod.Text = "";
                calcMiktar.Value = 1;
            }
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                _entity = form.secilen.FirstOrDefault();

            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            Temizle();

        }

        private void Temizle()
        {
            _cariId = null;

        }

        private void gridStokHareket_CellValueChanged(object sender,
                DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            Toplamlar();


        }


        private void Toplamlar()
        {
            //gridStokHareket.UpdateTotalSummary();


            gridStokHareket.UpdateSummary();
            calcKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            calcGenelToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue) +
                                    (calcKdvToplam.Value);





        }



        private void calcIndirimOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void repoDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec form = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoId, form.entity.Id);
                context.ChangeTracker.DetectChanges();
            }
        }

        private void repoFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity =
                context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati1 ?? 0
                : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati2 ?? 0
                : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati3 ?? 0
                : fiyatEntity.SatisFiyati3 ?? 0;

            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);

            radialFiyat.ShowPopup(MousePosition);

        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            //if (gridStokHareket.RowCount != 0)
            //{
            //    if (MessageBox.Show(
            //            "Satış Ekranında Ürünler Var. İşlemi İptal Edip Çıkmak İstediğinize Emin Misiniz?",
            //            "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            this.Close();
            //    }
            //}

        }

        private void repoSeri_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Satırı Silmek İstediğinize Emin Misiniz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();


            }
        }

        
        private void btnSatisBitir_Click(object sender, EventArgs e)
        {
                        //Stok Kontrol

            string message = null;
            int hata = 0;
            if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += "- Satış Ekranında eklenmiş bir ürün bulunamadı.." + System.Environment.NewLine;
                hata++;
            }


            if (txtKod.Text == "")
            {
                message += "- Fiş Kodu Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }


            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            List<StokHareket> cikisList = new List<StokHareket>();
            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(cmbTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                //  stokVeri.Hareket = ayarlar.StokHareketi;
                for (int i = 0; i < gridStokHareket.RowCount; i++)
                {
                    string stokkodu = gridStokHareket.GetRowCellValue(i, "Stok.StokKodu").ToString();
                    string stokAdi = gridStokHareket.GetRowCellValue(i, "Stok.StokAdi").ToString();
                    if (stokVeri.Stok.StokKodu.Equals(stokkodu) && stokVeri.Stok.StokAdi.Equals(stokAdi))
                    {
                        //stokVeri.ToplamTutar =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "colToplamTutar").ToString());
                        //stokVeri.KdvToplam =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "colKdvToplam").ToString());
                        //stokVeri.KdvHaric_ =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "colKsizTutar").ToString());
                        //stokVeri.IndirimTutar =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "colIndirimTutar").ToString());
                        stokVeri.Hareket = "Stok Giriş";
                        stokVeri.DepoId = Convert.ToInt32(lookDepoGiris.EditValue);

                        StokHareket sh = new StokHareket()
                        {
                            FisKodu = stokVeri.FisKodu,
                            Tarih = stokVeri.Tarih,
                            Hareket = "Stok Çıkış",
                            Miktar = stokVeri.Miktar,
                            StokId = stokVeri.StokId,
                            DepoId = Convert.ToInt32(lookdDepoCikis.EditValue),
                        };

                        cikisList.Add(sh);
                    }


                }
            }

            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
            }

            _fisentity.FisKodu = txtKod.Text;
            _fisentity.FisTuru = "Stok Transfer Fişi";
            // _fisentity.FisTuru = txtFisTuru.Text;
            _fisentity.Aciklama = txtAciklama.Text;
            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.AraToplam_ = calcAraToplam.Value;
            _fisentity.KdvToplam_ = calcKdvToplam.Value;
            kodOlustur.KodArttirma();
            fisDal.AddOrUpdate(context, _fisentity);

            foreach (var item in cikisList)
            {
                stokHareketDal.AddOrUpdate(context, item);
            }
            context.SaveChanges();

            if (_fisentity.FisTuru == "Toptan Satış Faturası" || _fisentity.FisTuru == "Alış Faturası" ||
                _fisentity.FisTuru == "Alış İade Faturası" || _fisentity.FisTuru == "Satış İade Faturası")
            {
                MessageBox.Show("Fatura Başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Tahsilat Fişi")
            {
                MessageBox.Show("Tahsilat Fişi başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Alınan Sipariş Fişi" || _fisentity.FisTuru == "Verilen Sipariş Fişi")
            {
                MessageBox.Show("Sipariş Fişi başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Alınan Teklif Fişi" || _fisentity.FisTuru == "Verilen Teklif Fişi")
            {
                MessageBox.Show("Teklif Fişi başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Satış İrsaliyesi" || _fisentity.FisTuru == "Alış İrsaliyesi")
            {
                MessageBox.Show("İrsaliye başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Ödeme Fişi")
            {
                MessageBox.Show("Ödeme Fişi başarılı bir şekilde kaydedildi.");
            }
            if (_fisentity.FisTuru == "Cari Devir Fişi")
            {
                MessageBox.Show("Cari Devir Fişi başarılı bir şekilde kaydedildi.");
            }
            if (_fisentity.FisTuru == "Stok Devir Fişi")
            {
                MessageBox.Show("Stok Devir Fişi başarılı bir şekilde kaydedildi.");
            }
            if (_fisentity.FisTuru == "Sayım Fazlası Fişi")
            {
                MessageBox.Show("Sayım Fazlası Fişi başarılı bir şekilde kaydedildi.");
            }
            if (_fisentity.FisTuru == "Sayım Eksiği Fişi")
            {
                MessageBox.Show("Sayım Eksiği Fişi başarılı bir şekilde kaydedildi.");
            }

            if (_fisentity.FisTuru == "Toptan Satış Faturası" && MessageBox.Show("Faturayı Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                FaturaHazirla f = new FaturaHazirla();
                f.FaturaHazirlama(txtKod.Text);
            }
            else
            {
                this.Close();
            }
            if (_fisentity.FisTuru == "Tahsilat Fişi" && MessageBox.Show("Tahsilat Fişi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                ReportsPrintTool yazdir = new ReportsPrintTool();
                rptTahsilat tahsilat = new rptTahsilat(txtKod.Text);
                yazdir.RaporYazdir(tahsilat, ReportsPrintTool.Belge.Tahsilat);

                tahsilat.ShowPreview();
            }
            else
            {
                this.Close();
            }


            if (_fisentity.FisTuru == "Satış İrsaliyesi" && MessageBox.Show("İrsaliyeyi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                FaturaHazirla f = new FaturaHazirla();
                f.IrsaliyeHazirlama(txtKod.Text);
            }
            else
            {
                this.Close();
            }
            if (_fisentity.FisTuru == "Alınan Sipariş Fişi" && MessageBox.Show("Siparişi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {
                FaturaHazirla f = new FaturaHazirla();
                f.SiparisHazirlama(txtKod.Text);
            }
            else
            {
                this.Close();
            }
            if (_fisentity.FisTuru == "Verilen Teklif Fişi" && MessageBox.Show("Teklifi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {
                FaturaHazirla f = new FaturaHazirla();
                f.TeklifHazirlama(txtKod.Text);
            }
            else
            {
                this.Close();
            }
        }




        private void cmbTarih_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                cmbTarih.DateTime = Convert.ToDateTime(DateTime.Now);
            }
        }

        private void toggleCariDevir_Toggled(object sender, EventArgs e)
        {



        }

        private void btnPersonelBul_Click(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void frmFisTransfer_Shown(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }

        private void labelControl36_Click(object sender, EventArgs e)
        {

        }

        #region Güncellenen Toggle Event Alanı

        private void toggleKDVDahil_Toggled(object sender, EventArgs e)
        {


            //colToplamTutar.UnboundExpression =
            //    "[BirimFiyati] * [Miktar] - [BirimFiyati] * [Miktar] * ([IndirimOrani] / 100)";
            //colAraToplam.UnboundExpression = "[BirimFiyati] * [Miktar]";



            Toplamlar();
        }

        #endregion
        //kdv burasımı acaba
        private void gridStokHareket_CustomUnboundColumnData(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

        }



        private void gridKasaHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            OdenenTutarGuncelle();
            Toplamlar();

        }

        private void frmFisTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
            if (e.KeyCode == Keys.F6)
            {
                btnUrunBul.PerformClick();
            }
        }

        //private void btnKaydetYeni_Click(object sender, EventArgs e)
        //{
        //    if (_fisentity.FisTuru == "Cari Devir Fişi")
        //    {
        //        if (toggleCariDevir.IsOn)
        //        {
        //            ayarlar.KasaHareketi = "Kasa Çıkış";
        //        }
        //        else
        //        {
        //            ayarlar.KasaHareketi = "Kasa Giriş";
        //        }
        //    }


        //    string message = null;
        //    int hata = 0;
        //    if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
        //    {
        //        message += "- Satış Ekranında eklenmiş bir ürün bulunamadı.." + System.Environment.NewLine;
        //        hata++;
        //    }


        //    if (txtKod.Text == "")
        //    {
        //        message += "- Fiş Kodu Alanı Boş Geçilemez." + System.Environment.NewLine;
        //        hata++;
        //    }



        //    if (_fisentity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
        //    {
        //        message += txtFisTuru.Text + " Türünde Cari Seçim Zorunludur. " + System.Environment.NewLine;
        //        hata++;
        //    }

        //    if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
        //    {
        //        message += " - Herhangi bir Ödeme Bulunamadı. " + System.Environment.NewLine;
        //        hata++;
        //    }

        //    if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true &&
        //        string.IsNullOrEmpty(lblCariKod.Text) && txtFisTuru.Text != "Hakediş Fişi")
        //    {
        //        message +=
        //            "- Ödenmesi Gereken Tutar Ödenmemiş Görünüyor.Açık hesap satış yapabilmek için lütfen cari seçiniz." +
        //            System.Environment.NewLine;
        //        hata++;
        //    }

        //    if (hata != 0)
        //    {
        //        MessageBox.Show(message);
        //        return;
        //    }

        //    if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
        //    {
        //        if (MessageBox.Show(
        //                $"Ödemenin # {calcOdenemesiGereken.Value.ToString("C2")} # tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. devam etmek isitor musunuz?",
        //                "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
        //        {
        //            MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
        //            return;
        //        }
        //    }


        //    foreach (var stokVeri in context.StokHareketleri.Local.ToList())
        //    {
        //        stokVeri.Tarih = stokVeri.Tarih == null
        //            ? Convert.ToDateTime(cmbTarih.DateTime)
        //            : Convert.ToDateTime(stokVeri.Tarih);
        //        stokVeri.FisKodu = txtKod.Text;
        //        stokVeri.Hareket = ayarlar.StokHareketi;

        //    }

        //    foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
        //    {
        //        itemHareket.FisKodu = txtKod.Text;
        //    }

        //    if (ayarlar.OdemeEkrani)
        //    {

        //        foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
        //        {
        //            kasaVeri.Tarih = kasaVeri.Tarih == null
        //                ? Convert.ToDateTime(cmbTarih.DateTime)
        //                : Convert.ToDateTime(kasaVeri.Tarih);
        //            kasaVeri.VadeTarihi = kasaVeri.VadeTarihi == null
        //                ? Convert.ToDateTime(cmbVadeTarihi.DateTime)
        //                : Convert.ToDateTime(kasaVeri.VadeTarihi);

        //            kasaVeri.FisKodu = txtKod.Text;
        //            kasaVeri.FisTuru = txtFisTuru.Text;
        //            kasaVeri.Hareket = ayarlar.KasaHareketi;
        //            if (txtFisTuru.Text != "Hakediş Fişi")
        //            {
        //                kasaVeri.CariId = _cariId;
        //            }


        //        }
        //    }

        //    _fisentity.ToplamTutar = calcGenelToplam.Value;
        //    _fisentity.IskontoOrani1 = calcIndirimOrani.Value;
        //    _fisentity.IskontoTutari1 = calcIndirimTutari.Value;
        //    kodOlustur.KodArttirma();
        //    fisDal.AddOrUpdate(context, _fisentity);
        //    context.SaveChanges();
        //    //ReportsPrintTool yazdir = new ReportsPrintTool();

        //    //yazdir.RaporYazdir(fatura, belge);
        //    //int sonFisKodu = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu)) + 1;
        //    ////SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, sonFisKodu.ToString());
        //    //SettingsTool.Save();
        //    MessageBox.Show("Fatura Başarılı bir şekilde kaydedildi.");
        //    if (gridStokHareket.RowCount != 0)
        //    {
        //        Temizle();
        //        _fisentity.CariId = null;
        //        _fisentity.BelgeNo = null;
        //        _fisentity.FisKodu = null;
        //        _fisentity.Aciklama = null;

        //        calcAraToplam.Text = null;
        //        calcGenelToplam.Text = null;
        //        calcIndirimOrani.Text = null;
        //        calcIndirimTutari.Text = null;
        //        calcKdvToplam.Text = null;
        //        calcMiktar.Text = "1";
        //        calcOdenemesiGereken.Text = null;
        //        calcOdenenTutar.Text = null;
        //        txtKod.Text = "";
        //        context.StokHareketleri.Local.Clear();
        //        context.KasaHareketleri.Local.Clear();
        //        context.PersonelHareketleri.Local.Clear();
        //        context.Kodlar.Local.Clear();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Mevcutta bir fatura bulunmadı");
        //    }


        //}

        private void gridKasaHareket_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void btnTahsilatFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportsPrintTool yazdir = new ReportsPrintTool();
            rptTahsilat tahsilat = new rptTahsilat(txtKod.Text);
            yazdir.RaporYazdir(tahsilat, ReportsPrintTool.Belge.Tahsilat);

            tahsilat.ShowPreview();
        }

        private void labelControl38_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbVadeTarihi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                cmbTarih.DateTime = Convert.ToDateTime(DateTime.Now);
            }
        }

        private void gridStokHareket_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu2.ShowPopup(p2);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.IrsaliyeHazirlama(txtKod.Text);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.SiparisHazirlama(txtKod.Text);

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.TeklifHazirlama(txtKod.Text);
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFaturalandir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Bu Evrağı Faturalandırmak İstediğinize Emin Misiniz ? ",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    _fisentity.FisTuru = "Toptan Satış Faturası";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.StokHareketi = "Stok Çıkış";
                    _fisentity.Tarih = DateTime.Now;
                    _fisentity.VadeTarihi = DateTime.Now;
                    MessageBox.Show("Faturaya Dönüştürme işlemi gerçekleşti.");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnBarkodluFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //rptFaturaBarkodlu fatura = new rptFaturaBarkodlu(txtKod.Text);
            //fatura.ShowPreview();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(txtKod.Text);
        }

        private void btnAlisFaturalandir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Bu Evrağı Faturalandırmak İstediğinize Emin Misiniz ? ",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    _fisentity.FisTuru = "Alış Faturası";
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    _fisentity.Tarih = DateTime.Now;
                    _fisentity.VadeTarihi = DateTime.Now;
                    MessageBox.Show("Faturaya Dönüştürme işlemi gerçekleşti.");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnProformaFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.ProformaFaturaHazirlama(txtKod.Text);
        }

        private void Cikis(object sender, FormClosingEventArgs e)
        {

        }

        private void calcMiktar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void toggleMuhtasilmi_Toggled(object sender, EventArgs e)
        {
            MustahsilPanel();
        }

        private void gridStokHareket_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridStokHareket.RowCount);
            lblSatirSayisi.Text = kayitsayisi.ToString();
        }

        private void btnGorunum_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fisentity.FisTuru == "Toptan Satış Faturası" || _fisentity.FisTuru == "Stok Devir Fişi" || _fisentity.FisTuru == "Sayım Fazlası Fişi" || _fisentity.FisTuru == "Sayım Eksiği Fişi" || _fisentity.FisTuru == "Alış Faturası")
            {
                gridStokHareket.ClearColumnsFilter();
                //if (!File.Exists(DosyaYolu)) File.Create(DosyaYolu);
                gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
            }
        }



        private void frmFisTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Satış Ekranında Ürünler Var. İşlemi İptal Edip Çıkmak İstediğinize Emin Misiniz?",
                        "DİKKAT", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void navFisBilgi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

