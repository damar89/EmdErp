﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.Personel;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using System.IO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Mask;
using System.Threading;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.OleDb;
using NetSatis.BackOffice.Extensions;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmFisIslem : XtraForm
    {
        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
        List<NetSatis.EDonusum.Models.Donusum.Details> dlist = new List<EDonusum.Models.Donusum.Details>();
        private int sec;
        NetSatisContext context = new NetSatisContext();
        FisAyarlari ayarlar = new FisAyarlari();
        FisDAL fisDal = new FisDAL();
        bool stoklarYuklendi = false;
        MasrafHareketDAL masrafHareketDal = new MasrafHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();
        CariDAL cariDal = new CariDAL();
        private int? _cariId;
        Fis _fisentity = new Fis();
        CariBakiye _entityBakiye = new CariBakiye();
        private CodeTool kodOlustur;
        StokDAL stokDAL = new StokDAL();
        CariBakiye entityBakiye = new CariBakiye();
        private Entities.Tables.Cari _entity;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\FisIslemSavedLayout.xml";
        private bool basariylaKaydedildi = false;
        bool duzenle = false;
        int frontOfficeUserId = 0;
        public frmFisIslem(string fisKodu = null, string fisTuru = null, bool cariGetir = false,
            Entities.Tables.Cari entity = null, int userId = 0)
        {
            InitializeComponent();
            frontOfficeUserId = userId;
            if (fisKodu != null)
            {
                duzenle = true;
            }
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            kodOlustur.BarButonOlustur();
            cmbTarih.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            cmbVadeTarihi.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                toggleCariDevir.IsOn =
                    context.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;
            }
            if (_fisentity.CariId != null)
            {
                lblCariAd.Text = _fisentity.Cari.CariAdi;
                lblCariKod.Text = _fisentity.Cari.CariKodu;
                txtFaturaUnvani.Text = _fisentity.Cari.FaturaUnvani;
                entityBakiye = this.cariDal.cariBakiyesi(context, Convert.ToInt32(_fisentity.CariId));
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
            else
            {
                _fisentity.FisTuru = fisTuru;

                _fisentity.Tarih = DateTime.Now;
                _fisentity.VadeTarihi = DateTime.Now;
                //_fisentity.FisKodu =
                //    CodeTool.KodOlustur("FS", SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu));
            }
            if (fisTuru == "Toptan Satış Faturası" || fisTuru == "Perakende Satış Faturası" ||
                fisTuru == "Satış İade Faturası" || fisTuru == "Alış İade Faturası" || fisTuru == "Alış Faturası" ||
                fisTuru == "Satış İrsaliyesi" || fisTuru == "Alış İrsaliyesi" || fisTuru == "Alınan Sipariş Fişi" ||
                fisTuru == "Verilen Sipariş Fişi" || fisTuru == "Alınan Teklif Fişi" ||
                fisTuru == "Verilen Teklif Fişi" || fisTuru == "Sayım Fazlası Fişi" || fisTuru == "Sayım Eksiği Fişi" ||
                fisTuru == "Stok Devir Fişi" || fisTuru == null)
            {
                if (fisKodu != null)
                {
                    context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                }
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
                _fisentity.FaturaUnvani = entity.FaturaUnvani;
                _fisentity.Adres = entity.Adres;
                _fisentity.Il = entity.Il;
                _fisentity.Ilce = entity.Ilce;
                _fisentity.VergiDairesi = entity.VergiDairesi;
                _fisentity.VergiNo = entity.VergiNo;
                _fisentity.Semt = entity.Semt;
                _fisentity.CepTelefonu = entity.CepTelefonu;
                _fisentity.CariAdi = entity.CariAdi;
                _fisentity.EMail = entity.EMail;
                _fisentity.Telefon = entity.Telefon;
                _fisentity.Aciklama = entity.Aciklama;
                lblCariAd.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                lblCariKod.Text = entity.CariKodu;
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
            txtKod.DataBindings.Add("Text", _fisentity, "FisKodu", false,
            DataSourceUpdateMode.OnPropertyChanged);
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", true,
                DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            cmbVadeTarihi.DataBindings.Add("EditValue", _fisentity, "VadeTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSeri.DataBindings.Add("Text", _fisentity, "Seri", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtSira.DataBindings.Add("Text", _fisentity, "Sira", false,
                                DataSourceUpdateMode.OnPropertyChanged);
            cmbTipi.DataBindings.Add("EditValue", _fisentity, "Tipi", false,
              DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
            toggleKDVDahil.DataBindings.Add("EditValue", _fisentity, "KDVDahil", false,
                DataSourceUpdateMode.OnPropertyChanged);
            if (!duzenle)
            {
                var kod = context.Kodlar.Where(c => c.Tablo == "fis").First();
                _fisentity.FisKodu = CodeTool.fiskodolustur(kod.OnEki, kod.SonDeger.ToString());
            }
            calcIndirimOrani.EditValue = _fisentity.DipIskOran;
            calcIndirimTutari.EditValue = _fisentity.DipIskTutari;
            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();

            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridContPersonelHareket.DataSource = context.PersonelHareketleri.Local.ToBindingList();
            FisAyar();
            HepsiniHesapla();
            OdenenTutarGuncelle();
            ButonlariYukle();
            MustahsilPanel();
            txtBarkod.Focus();
            //OdenenTutarGuncelle();
            //cari getirme alanı
            //    List<int> listIds = new List<int>();
            //if (fisKodu != null)
            //{
            //    foreach (var item in gridContStokHareket.DataSource as BindingList<StokHareket>)
            //    {
            //        listIds.Add(item.StokId);
            //    }
            //    context.Stoklar.Where(x => listIds.Contains(x.Id)).Load();
            //}
            //context.Stoklar.LoadAsync();
            //context.Configuration.AutoDetectChangesEnabled = false;
        }
        private void MustahsilPanel()
        {
            if (toggleMuhtasilmi.IsOn)
            {
                //panelIndirim.Visible = false;
                //panelKooperatif.Visible = true;
                //labelkdvToplam.Text = "Kesinti YEKÜNÜ";
                if (context.StokHareketleri.Local.ToBindingList().Count > 0)
                    foreach (var hareket in context.StokHareketleri.Local.ToBindingList())
                        hareket.Kdv = 0;
            }
            else
            {
                //panelIndirim.Visible = true;
                //panelKooperatif.Visible = false;
                //labelkdvToplam.Text = "Kdv Toplam :";
                if (context.StokHareketleri.Local.ToBindingList().Count > 0)
                    foreach (var hareket in context.StokHareketleri.Local.ToBindingList())
                    {
                        var s = context.Stoklar.FirstOrDefault(x => x.Id == hareket.StokId);
                        if (s != null) hareket.Kdv = s.SatisKdv;
                    }
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
                flowOdemeTurleri.Controls.Add(buton);
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
            flowPersonel.Controls.Add(PersonelSecimIptal);
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
                flowPersonel.Controls.Add(buton);
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

                frmOdemeEkrani form = new frmOdemeEkrani(Convert.ToInt32(buton.Tag), null, frontOfficeUserId);
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
                if (calcOdenemesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödenemsi Gereken Tutar Ödenmemiş Durumdadır.");
                }
                else
                {
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        int userId = 0;
                        if (frontOfficeUserId != 0)
                        {
                            userId = frontOfficeUserId;
                        }
                        else
                        {
                            userId = frmAnaMenu.UserId;
                        }
                        int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == userId).FirstOrDefault().KasaId);
                        if (kasaid == 0)
                        {
                            kasaid = 1;
                        }
                        KasaHareket entityKasaHareket = new KasaHareket
                        {
                            OdemeTuruId = Convert.ToInt32(buton.Tag),
                            KasaId = kasaid,
                            Tarih = Convert.ToDateTime(cmbTarih.DateTime),
                            Tutar = calcOdenemesiGereken.Value
                        };
                        kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                        OdenenTutarGuncelle();
                    }
                    else
                    {
                        for (int i = 0; i < gridPrsonelHareket.RowCount; i++)
                        {
                            KasaHareket entityKasaHareket = new KasaHareket
                            {
                                //kontrol edilecek
                                CariId = _cariId,
                                OdemeTuruId = Convert.ToInt32(buton.Tag),
                                Tutar = Convert.ToDecimal(gridPrsonelHareket.GetRowCellValue(i, colOdenecekTutar)),
                                Aciklama =
                                    $"{gridPrsonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridPrsonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()}Aylık Maaş : {Convert.ToDecimal(gridPrsonelHareket.GetRowCellValue(i, colAylikMaas)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridPrsonelHareket.GetRowCellValue(i, colPirimTutari)).ToString("C2")}"
                            };
                            kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                        }
                        OdenenTutarGuncelle();
                    }
                }
            }
        }
        private void FisAyar()
        {
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.FisTurleri = "Alış Faturası";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.SatisEkrani = true;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 0;
                    lblBaslik.Text = "Alış Faturası";
                    navPersonelIslem.Dispose();
                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.FisTurleri = "Perakende Satış Faturası";
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Perakende Satış Faturası";
                    lblBaslik.Appearance.ImageIndex = 1;
                    navPersonelIslem.Dispose();
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.FisTurleri = "Toptan Satış Faturası";
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
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Toptan Satış Faturası";
                    lblBaslik.Appearance.ImageIndex = 2;
                    navPersonelIslem.Dispose();
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.FisTurleri = "Alış İade Faturası";
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnYeniFtrDizany.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Alış İade Faturası";
                    lblBaslik.Appearance.ImageIndex = 3;
                    navPersonelIslem.Dispose();
                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.FisTurleri = "Satış İade Faturası";
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = true;
                    lblBaslik.Text = "Satış İade Faturası";
                    lblBaslik.Appearance.ImageIndex = 4;
                    navPersonelIslem.Dispose();
                    break;
                case "Satış İrsaliyesi":
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.FisTurleri = "Satış İrsaliyesi";
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblBaslik.Text = "Satış İrsaliyesi";
                    navPersonelIslem.Dispose();
                    break;
                case "Alış İrsaliyesi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.FisTurleri = "Alış İrsaliyesi";
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    lblBaslik.Text = "Alış İrsaliyesi";
                    navPersonelIslem.Dispose();
                    break;
                case "Alınan Sipariş Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.FisTurleri = "Alınan Sipariş Fişi";
                    ayarlar.SatisEkrani = true;
                    ayarlar.OdemeEkrani = false;
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    lblBaslik.Text = "Alınan Sipariş Fişi";
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    navPersonelIslem.Dispose();
                    break;
                case "Verilen Sipariş Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.FisTurleri = "Verilen Sipariş Fişi";
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    ayarlar.SatisEkrani = true;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    lblBaslik.Text = "Verilen Sipariş Fişi";
                    navPersonelIslem.Dispose();
                    break;
                case "Alınan Teklif Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.FisTurleri = "Alınan Teklif Fişi";
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    lblBaslik.Text = "Alınan Teklif Fişi";
                    navPersonelIslem.Dispose();
                    break;
                case "Verilen Teklif Fişi":
                    lblSatir.Visible = true;
                    calcIndirimOrani.ReadOnly = true;
                    calcIndirimTutari.ReadOnly = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.FisTurleri = "Verilen Teklif Fişi";
                    ayarlar.SatisEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblBaslik.Text = "Verilen Teklif Fişi";
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Eksiği Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.FisTurleri = "Sayım Eksiği Fişi";
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    toggleKDVDahil.Visible = false;
                    ayarlar.SatisEkrani = true;
                    navPlasiyerBilgi.Dispose();
                    lblBaslik.Text = "Sayım Eksiği Fişi";
                    lblBaslik.Appearance.ImageIndex = 5;
                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Sayım Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    //ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.FisTurleri = "Sayım Fişi";
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    btnFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.OdemeEkrani = false;
                    toggleKDVDahil.Visible = false;
                    ayarlar.SatisEkrani = true;
                    navPlasiyerBilgi.Dispose();
                    lblBaslik.Text = "Sayım Fişi";
                    lblBaslik.Appearance.ImageIndex = 5;
                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Sayım Fazlası Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.FisTurleri = "Sayım Fazlası Fişi";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    toggleKDVDahil.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    navPlasiyerBilgi.Dispose();
                    lblBaslik.Appearance.ImageIndex = 6;
                    lblBaslik.Text = "Sayım Fazlası Fişi";
                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Stok Devir Fişi":
                    lblSatir.Visible = true;
                    lblSatirSayisi.Visible = true;
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.FisTurleri = "Stok Devir Fişi";
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    toggleKDVDahil.Visible = false;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    navPlasiyerBilgi.Dispose();
                    lblBaslik.Appearance.ImageIndex = 7;
                    lblBaslik.Text = "Stok Devir Fişi";
                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.FisTurleri = "Tahsilat Fişi";
                    ayarlar.OdemeEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = false;
                    btnOdemeFisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    navMasraf.SelectedPage = navOdemeEkrani;

                    toggleKDVDahil.Visible = false;

                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;

                    lblBaslik.Text = "Tahsilat Fişi";
                    break;
                case "Masraf Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.FisTurleri = "Masraf Fişi";
                    ayarlar.OdemeEkrani = true;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    ayarlar.SatisEkrani = false;
                    btnOdemeFisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();

                    navMasraf.SelectedPage = navOdemeEkrani;
                    toggleKDVDahil.Visible = false;

                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;

                    lblBaslik.Text = "Masraf Fişi";
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.FisTurleri = "Ödeme Fişi";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navSatisEkrani.Dispose();
                    btnTahsilatFisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAlisFaturalandir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    navPersonelIslem.Dispose();
                    toggleKDVDahil.Visible = false;

                    navMasraf.SelectedPage = navOdemeEkrani;
                    lblBaslik.Text = "Ödeme Fişi";

                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.FisTurleri = "Cari Devir Fişi";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    toggleCariDevir.Visible = true;

                    toggleKDVDahil.Visible = false;

                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;
                    layPanelCariDevir.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    txtKod.Width = 275;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    navMasraf.SelectedPage = navOdemeEkrani;
                    lblBaslik.Text = "Cari Devir Fişi";

                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
                case "Hakediş Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.FisTurleri = "Hakediş Fişi";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;

                    toggleKDVDahil.Visible = false;
                    navSatisEkrani.Dispose();
                    btnBarkodluFatura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    faturaYazdırToolStripMenuItem.Visible = false;
                    proformaFaturaYazdırToolStripMenuItem.Visible = false;
                    siparişYazdırToolStripMenuItem.Visible = false;
                    bilgiFişiYazdırToolStripMenuItem.Visible = false;
                    teklifYazdırToolStripMenuItem.Visible = false;
                    irsaliyeYazdırToolStripMenuItem.Visible = false;

                    navPlasiyerBilgi.Dispose();
                    navMasraf.SelectedPage = navPersonelIslem;
                    lblBaslik.Text = "Hakediş Fişi";

                    calcIndirimOrani.Visible = false;
                    calcIndirimToplami.Visible = false;
                    calcIndirimTutari.Visible = false;
                    break;
            }
        }
        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            if (frontOfficeUserId != 0 || ayarlar.SatisEkrani || _fisentity.FisTuru == "Hakediş Fişi")
            {
                calcOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                calcOdenemesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
            }
            else
            {
                calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
        }
        private void frmFisIslem_Load(object sender, EventArgs e)
        {
            var combx = eislem.HareketTipiListele();
            foreach (var i in combx)
            {
                cmbTipi.Properties.Items.Add(i.Aciklama);
            }
            var a = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanHareketTipi);
            if (a != null)
            {
                cmbTipi.Text = a;

            }

            if (duzenle)
            {
                cmbTipi.Text = _fisentity.Tipi;
            }
            ////if (_fisentity.FisTuru=="Satış İrsaliyesi" || _fisentity.FisTuru == "Alış İrsaliyesi"||_fisentity.FisTuru=="Alınan Sipariş Fişi" || _fisentity.FisTuru == "Verilen Sipariş Fişi"||_fisentity.FisTuru=="Alınan Teklif Fişi" || _fisentity.FisTuru == "Verilen Teklif Fişi")
            ////{
            ////    calcIndirimOrani.ReadOnly=true;
            ////    calcIndirimTutari.ReadOnly=true;
            ////}
            ///
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi)))
            {
                //lblmuhtahsil.Visible = true;
                toggleMuhtasilmi.Visible = true;
            }
            if (_fisentity.FisTuru == "Toptan Satış Faturası" || _fisentity.FisTuru == "Stok Devir Fişi" || _fisentity.FisTuru == "Sayım Fazlası Fişi" || _fisentity.FisTuru == "Sayım Eksiği Fişi" || _fisentity.FisTuru == "Alış Faturası")
            {
                gridContStokHareket.ForceInitialize();
                if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
            }
            else
            {
            }
            OdenenTutarGuncelle();
            Toplamlar();
            HepsiniHesapla();
        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDal indirimDal = new IndirimDal();
            CariDAL cariDal = new CariDAL();
            var Barkod = context.Barkodlar.FirstOrDefault(c => c.StokId == entity.Id);
            stokHareket.StokId = entity.Id;
            if (_fisentity.FisTuru == "Alış Faturası" || _fisentity.FisTuru == "Alış İade Faturası" || _fisentity.FisTuru == "Alış İrsaliyesi")
            {
                stokHareket.IndirimOrani = 0;
            }
            else
            {
                stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            }
            if (_fisentity.CariId != null)
            {
                var oran = context.Cariler.Where(x => x.Id == _fisentity.CariId).FirstOrDefault().IskontoOrani;

                stokHareket.IndirimOrani2 =
                    txtFisTuru.Text == "Toptan Satış Faturası" && oran != null ? oran : 0;
            }
            else
            {
                stokHareket.IndirimOrani2 = 0;
            }
            stokHareket.IndirimOrani3 = 0;
            int depoid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().DepoId);
            if (depoid == 0)
            {
                depoid = 1;
            }
            stokHareket.DepoId = depoid;

            if (toggleToptanSatis.IsOn)
            {
                stokHareket.BirimFiyati = entity.SatisFiyati4;
            }
            else
            {
                stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" || txtFisTuru.Text == "Alış İade Faturası" || txtFisTuru.Text == "Alış İrsaliyesi" || txtFisTuru.Text == "Verilen Sipariş Fişi" || txtFisTuru.Text == "Alınan Teklif Fişi" || txtFisTuru.Text == "Stok Devir Fişi" || txtFisTuru.Text == "Sayım Fazlası Fişi" || txtFisTuru.Text == "Sayım Eksiği Fişi" || txtFisTuru.Text == "Sayım Giriş Fişi" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            }

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
            stokHareket.Kdv = toggleMuhtasilmi.IsOn ? 0 : entity.SatisKdv;
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
            while (true)
            {
                try
                {
                    context.Stoklar.Count();
                    break;
                }
                catch
                {
                    Thread.Sleep(500);
                }
            }
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
                HepsiniHesapla();
                focusedSatirSec(s.StokId);
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
            while (true)
            {
                try
                {
                    context.Stoklar.Count();
                    break;
                }
                catch
                {
                    Thread.Sleep(500);
                }
            }
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
                    HepsiniHesapla();
                    Toplamlar();

                    focusedSatirSec(s.StokId);

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
                        HepsiniHesapla();
                        focusedSatirSec(s.StokId);

                    }
                    else
                    {
                        MessageBox.Show("Barkod Bulunamadı..");
                    }
                }
                txtBarkod.Text = "";
                calcMiktar.Value = 1;
            }
            gridStokHareket.RefreshData();
            gridContKasaHareket.Refresh();
            txtBarkod.Focus();
        }

        private void focusedSatirSec(int stokId)
        {
            try
            {
                for (int i = 0; i < (gridContStokHareket.DataSource as BindingList<StokHareket>).Count; i++)
                {
                    var a = Convert.ToInt32(gridStokHareket.GetRowCellValue(i, "StokId"));
                    if (a == stokId)
                    {
                        gridStokHareket.FocusedRowHandle = i;
                        break;
                    }
                }

            }
            catch
            {
            }
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                _entity = form.secilen.FirstOrDefault();
                entityBakiye = this.cariDal.cariBakiyesi(context, _entity.Id);
                _cariId = _entity.Id;
                _fisentity.CariId = _entity.Id;
                lblCariKod.Text = _entity.CariKodu;
                lblCariAd.Text = _entity.CariAdi;
                txtFaturaUnvani.Text = _entity.FaturaUnvani;
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
                _fisentity.FaturaUnvani = txtFaturaUnvani.Text;
                _fisentity.CepTelefonu = _entity.CepTelefonu;
                _fisentity.CariAdi = _entity.CariAdi;
                _fisentity.EMail = _entity.EMail;
                _fisentity.Telefon = _entity.Telefon;
                _fisentity.Il = _entity.Il;
                _fisentity.Ilce = _entity.Ilce;
                _fisentity.Semt = _entity.Semt;
                _fisentity.Adres = _entity.Adres;
                _fisentity.VergiDairesi = _entity.VergiDairesi;
                _fisentity.VergiNo = _entity.VergiNo;
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            _cariId = null;
            _fisentity.CariId = null;
            lblCariKod.Text = null;
            lblCariAd.Text = null;
            txtFaturaUnvani.Text = null;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }
        private void gridStokHareket_CellValueChanged(object sender,
                DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Toplamlar();
        }
        private void Toplamlar()
        {
            //    gridStokHareket.UpdateTotalSummary();
            //    calcZirai.Value = Convert.ToDecimal(colZiraiToplam.SummaryItem.SummaryValue);
            //    calcBagkur.Value = Convert.ToDecimal(colBagkurToplam.SummaryItem.SummaryValue);
            //    calcMera.Value = Convert.ToDecimal(colMeraToplam.SummaryItem.SummaryValue);
            //    calcBorsa.Value = Convert.ToDecimal(colBorsaToplam.SummaryItem.SummaryValue);
            //    gridStokHareket.UpdateSummary();
            //    calcIndirimTutari.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 *
            //                              calcIndirimOrani.Value;
            //    if (_fisentity.FisTuru == "Hakediş Fişi")
            //    {
            //        calcGenelToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            //    }
            //    else
            //    {
            //        #region Güncellenen Toggle Alanı
            //        if (toggleKDVDahil.IsOn)
            //        {
            //            calcAraToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue);
            //            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            //            if (toggleMuhtasilmi.IsOn)
            //            {
            //                calcKdvToplam.Value = calcZirai.Value + calcBagkur.Value + calcMera.Value + calcBorsa.Value;
            //                calcGenelToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue) -
            //                                        (calcKdvToplam.Value) - calcIndirimToplami.Value;
            //            }
            //            else
            //            {
            //                calcKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            //                calcGenelToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue) +
            //                                        (calcKdvToplam.Value) - calcIndirimToplami.Value;
            //            }
            //        }
            //        else
            //        {
            //            calcAraToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue);
            //            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            //            if (toggleMuhtasilmi.IsOn)
            //            {
            //                calcKdvToplam.Value = calcZirai.Value + calcBagkur.Value + calcMera.Value + calcBorsa.Value;
            //                calcGenelToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue) -
            //                                        (calcKdvToplam.Value) - calcIndirimToplami.Value;
            //            }
            //            else
            //            {
            //                calcKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            //                calcGenelToplam.Value = Convert.ToDecimal(colAraToplam.SummaryItem.SummaryValue) +
            //                                        (calcKdvToplam.Value) - calcIndirimToplami.Value;
            //            }
            //        }
            //        #endregion
            //    }
            //    calcOdenemesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
            //    if (_fisentity.FisTuru == "Masraf Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            //    if (_fisentity.FisTuru == "Tahsilat Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            //    if (_fisentity.FisTuru == "Ödeme Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            //    if (_fisentity.FisTuru == "Cari Devir Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
        }
        private void calcIndirimOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
            HepsiniHesapla();
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
            barFiyat4.Tag = txtFisTuru.Text == "Alış Faturası"
          ? fiyatEntity.AlisFiyati3 ?? 0
          : fiyatEntity.SatisFiyati4 ?? 0;

            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            barFiyat4.Caption = string.Format("{0:C2}", barFiyat4.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
            HepsiniHesapla();
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
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            frmSeriNoGir form = new frmSeriNoGir(veri, false);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }
        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Satırı Silmek İstediğinize Emin Misiniz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
                HepsiniHesapla();
            }
        }
        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKasaSec form = new frmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaId, form.entity.Id);
                context.ChangeTracker.DetectChanges();
            }
        }
        private void repoOdemeSil_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Satırı Silmek İstediğinize Emin Misiniz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }



        private void btnSatisBitir_Click(object sender, EventArgs e)
        {
            if (_fisentity.Tipi == "")
            {
                MessageBox.Show("Lütfen hareket tipi seçiniz.");
                return;
            }

            if (duzenle)
            {
                if (_fisentity.Id > 0)
                {
                    if (!String.IsNullOrEmpty(_fisentity.FaturaFisKodu))
                    {
                        MessageBox.Show("Faturalandırılmış irsaliyeler üzerinde değişiklik yapamazsınız.");
                        return;
                    }
                    var temp = context.Fisler.Where(x => x.FaturaFisKodu == _fisentity.FisKodu).ToList();
                    if (temp.Count != 0)
                    {
                        MessageBox.Show("İrsaliyeden faturalandırılmış fatura üzerinde değişiklik yapamazsınız.");
                        return;
                    }
                }
            }

            if (_fisentity.FisTuru == "Cari Devir Fişi")
            {
                if (toggleCariDevir.IsOn)
                {
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                }
                else
                {
                    ayarlar.KasaHareketi = "Kasa Giriş";
                }
            }
            if (!Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_CariEtkilesin)))
            {
                _fisentity.CariIrsaliye = "0";
            }
            else
            {
                _fisentity.CariIrsaliye = "1";
            }
            if (!Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_StoguEtkilesin)))
            {
                _fisentity.StokIrsaliye = "0";
            }
            else
            {
                _fisentity.StokIrsaliye = "1";
            }
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
            if (cmbTipi.Text == "")
            {
                message += "- Hareket Tipi Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (txtSira.Text == "" && txtFisTuru.Text == "Alış Faturası" && txtFisTuru.Text == "Alış İade Faturası" && txtFisTuru.Text == "Toptan Satış Faturası" && txtFisTuru.Text == "Satış İade Faturası")
            {
                message += "- Sıra No Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (_fisentity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi" && txtFisTuru.Text != "Masraf Fişi")
            {
                message += txtFisTuru.Text + " Türünde Cari Seçim Zorunludur. " + System.Environment.NewLine;
                hata++;
            }
            if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += " - Herhangi bir Ödeme Bulunamadı. " + System.Environment.NewLine;
                hata++;
            }
            if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true &&
                string.IsNullOrEmpty(lblCariKod.Text) && txtFisTuru.Text != "Hakediş Fişi")
            {
                message +=
                    "- Ödenmesi Gereken Tutar Ödenmemiş Görünüyor.Açık hesap satış yapabilmek için lütfen cari seçiniz." +
                    System.Environment.NewLine;
                hata++;
            }

            if (_fisentity.CariId != null && _fisentity.FisTuru == "Toptan Satış Faturası")
            {
                var bakiye = entityBakiye.Bakiye != null ? entityBakiye.Bakiye : 0;
                var risk = context.Cariler.Where(x => x.Id == _fisentity.CariId).FirstOrDefault().RiskLimiti;
                if (risk != null && risk != 0 && Convert.ToDecimal(calcGenelToplam.EditValue) + bakiye > risk)
                {

                    if (MessageBox.Show(
                      $"Risk Limitini astiniz - " + risk + " TL. Devam etmek istiyor musunuz?",
                      "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                        return;
                    }
                }
            }

            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }

            if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                if (MessageBox.Show(
                        $"Ödemenin # {calcOdenemesiGereken.Value.ToString("C2")} # tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. devam etmek istiyor musunuz?",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }
            if (!duzenle)
            {
                while (context.Fisler.Where(x => x.FisKodu == txtKod.Text).Count() > 0)
                {
                    var firstIndexZero = txtKod.Text.IndexOf('0');
                    var onEk = txtKod.Text.Substring(0, firstIndexZero);
                    var no = Convert.ToInt32(txtKod.Text.Substring(firstIndexZero + 1, txtKod.Text.Length - 1 - firstIndexZero
                        ));
                    no++;
                    txtKod.Text = CodeTool.fiskodolustur(onEk, no.ToString());
                }
            }
            decimal toplamDipIskontoPayi = 0;
            Fis sayimfazlasifisi = new Fis();
            Fis sayimeksigifisi = new Fis();
            List<StokHareket> sayimfazlasilist = new List<StokHareket>();
            List<StokHareket> sayimeksigilist = new List<StokHareket>();
            sayimfazlasifisi.FisTuru = "Sayım Fazlası Fişi";
            sayimeksigifisi.FisTuru = "Sayım Eksiği Fişi";

            if (_fisentity.FisTuru == "Sayım Fişi")
            {

            }

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                if (!Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_StoguEtkilesin)))
                {
                    stokVeri.StokIrsaliye = "0";
                }
                else
                {
                    stokVeri.StokIrsaliye = "1";
                }


                if (_fisentity.FisTuru == "Sayım Fişi")
                {

                    var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                        (Stoklar, StokHareketleri) =>
               new
               {
                   Stoklar.StokKodu,
                   StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                   StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Satış Faturası2") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                   MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                     (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Satış Faturası2")
                                     || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                     ).Sum(c => c.Miktar) ?? 0),
               }).Where(x => x.StokKodu.Contains(stokVeri.Stok.StokKodu)).ToList();

                    var mevcut = tablo[0].MevcutStok;
                    decimal fark = Convert.ToDecimal(mevcut) - Convert.ToDecimal(stokVeri.Miktar);
                    StokHareket sh = new StokHareket();
                    sh.Depo = stokVeri.Depo;
                    sh.DepoId = stokVeri.DepoId;

                    if (fark > 0)
                    {
                        //cikis yapilacak
                        sh.Miktar = fark;
                        sh.Stok = stokVeri.Stok;
                        sh.StokId = stokVeri.StokId;
                        sh.Hareket = "Stok Çıkış";
                        sh.FisTuru = "Sayım Fazlası Fişi";
                        sh.Tarih = cmbTarih.DateTime;
                        sayimfazlasilist.Add(sh);

                    }
                    else if (fark < 0)
                    {
                        //giris yapilacak
                        sh.Miktar = fark * -1;
                        sh.Stok = stokVeri.Stok;
                        sh.StokId = stokVeri.StokId;
                        sh.Hareket = "Stok Giriş";
                        sh.FisTuru = "Sayım Eksiği Fişi";
                        sh.Tarih = cmbTarih.DateTime;
                        sayimeksigilist.Add(sh);



                    }

                }





                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(cmbTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.FisSeri = txtSeri.Text;
                if (duzenle == true)
                {
                    stokVeri.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                    stokVeri.EditUser = frmAnaMenu.UserId;
                }
                else
                {
                    stokVeri.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                    stokVeri.SaveUser = frmAnaMenu.UserId;
                }
                stokVeri.Sira = txtSira.Text;
                stokVeri.Tipi = cmbTipi.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
                stokVeri.FisTuru = ayarlar.FisTurleri;
                toplamDipIskontoPayi += Convert.ToDecimal(stokVeri.DipIskontoPayi);
                if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_AlisFiyat)))
                {
                    if (_fisentity.FisTuru == "Alış Faturası" || _fisentity.FisTuru == "Alış İrsaliyesi")
                    {
                        stokVeri.Stok.AlisFiyati1 = stokVeri.BirimFiyati;
                    }
                }
                for (int i = 0; i < gridStokHareket.RowCount; i++)
                {
                    string stokkodu = gridStokHareket.GetRowCellValue(i, "Stok.StokKodu").ToString();
                    string stokAdi = gridStokHareket.GetRowCellValue(i, "Stok.StokAdi").ToString();
                    if (stokVeri.Stok.StokKodu.Equals(stokkodu) && stokVeri.Stok.StokAdi.Equals(stokAdi))
                    {
                        stokVeri.ToplamTutar =
                            Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar").ToString());
                        stokVeri.KdvToplam =
                            Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString());
                        stokVeri.KdvHaric_ =
                            Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "colKsizTutar"));
                        stokVeri.IndirimTutar =
                            Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimTutar").ToString());
                        // Stok harekete yazmak
                        //stokVeri.IndirimTutar2 =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimTutar2").ToString());
                        //stokVeri.IndirimTutar3 =
                        //    Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimTutar3").ToString());
                    }
                }
            }



            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
                //itemHareket.Id=_fisentity.Personel.Id;
            }
            if (ayarlar.OdemeEkrani || context.KasaHareketleri.Local.ToList().Count != 0)
            {
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = Convert.ToDateTime(cmbTarih.DateTime);
                    kasaVeri.VadeTarihi = Convert.ToDateTime(cmbVadeTarihi.DateTime);
                    kasaVeri.FisTuru = txtFisTuru.Text;
                    kasaVeri.FisKodu = txtKod.Text;
                    if (duzenle == true)
                    {
                        kasaVeri.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                        kasaVeri.EditUser = frmAnaMenu.UserId;
                    }
                    else
                    {
                        kasaVeri.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                        kasaVeri.SaveUser = frmAnaMenu.UserId;
                    }
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    if (kasaVeri.FisTuru == "Satış İrsaliyesi")
                    {
                        kasaVeri.Hareket = "Kasa Giriş";
                    }
                    else if (kasaVeri.FisTuru == "Alış İrsaliyesi")
                    {
                        kasaVeri.Hareket = "Kasa Çıkış";
                    }
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        kasaVeri.CariId = _fisentity.CariId;
                    }
                }
            }
            if (duzenle == true)
            {
                _fisentity.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                _fisentity.EditUser = frmAnaMenu.UserId;
            }
            else
            {
                _fisentity.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                _fisentity.SaveUser = frmAnaMenu.UserId;
            }
            _fisentity.FisKodu = txtKod.Text;
            _fisentity.FisTuru = txtFisTuru.Text;
            _fisentity.BelgeNo = txtBelgeNo.Text;
            _fisentity.Aciklama = txtAciklama.Text;
            _fisentity.EfaturaDurumu = false;
            _fisentity.Sira = txtSira.Text;
            _fisentity.Seri = txtSeri.Text;
            _fisentity.Tipi = cmbTipi.Text;
            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.IskontoOrani1 = calcIndirimOrani.Value;
            _fisentity.IskontoTutari1 = calcIndirimToplami.Value + toplamDipIskontoPayi;
            _fisentity.AraToplam_ = calcAraToplam.Value;
            _fisentity.KdvToplam_ = calcKdvToplam.Value;
            _fisentity.DipIskTutari = calcIndirimTutari.Value;
            _fisentity.DipIskNetTutari = toplamDipIskontoPayi;
            _fisentity.DipIskOran = calcIndirimOrani.Value;
            if (!duzenle)
            {
                kodOlustur.KodArttirma("fis");
                if (_fisentity.FisTuru == "Sayım Fişi")
                {
                    kodOlustur.KodArttirma("fis");

                }

            }
            context.ChangeTracker.DetectChanges();
            bool result = fisDal.AddOrUpdate(context, _fisentity);
            if (!result)
            {
                return;
            }
            context.SaveChanges();

            FaturaOlustur();



            int oneortwo = 1;

            if (_fisentity.FisTuru == "Sayım Fişi")
            {
                sayimfazlasifisi.Tarih = DateTime.Now;
                sayimfazlasifisi.KayitTarihi = DateTime.Now;
                sayimfazlasifisi.GuncellemeTarihi = DateTime.Now;
                sayimeksigifisi.Tarih = DateTime.Now;
                sayimeksigifisi.KayitTarihi = DateTime.Now;
                sayimeksigifisi.GuncellemeTarihi = DateTime.Now;
                if (sayimfazlasilist.Count > 0)
                {
                    oneortwo = 2;
                    var firstIndexZero = txtKod.Text.IndexOf('0');
                    var onEk = txtKod.Text.Substring(0, firstIndexZero);
                    var no = Convert.ToInt32(txtKod.Text.Substring(firstIndexZero + 1, txtKod.Text.Length - 1 - firstIndexZero
                        ));
                    no++;
                    sayimfazlasifisi.FisKodu = CodeTool.fiskodolustur(onEk, no.ToString());

                    fisDal.AddOrUpdate(context, sayimfazlasifisi);
                    foreach (var item in sayimfazlasilist)
                    {
                        item.FisKodu = sayimfazlasifisi.FisKodu;
                        stokHareketDal.AddOrUpdate(context, item);
                    }

                }
                if (sayimeksigilist.Count > 0)
                {
                    var firstIndexZero = txtKod.Text.IndexOf('0');
                    var onEk = txtKod.Text.Substring(0, firstIndexZero);
                    var no = Convert.ToInt32(txtKod.Text.Substring(firstIndexZero + 1, txtKod.Text.Length - 1 - firstIndexZero
                        ));
                    no += oneortwo;
                    sayimeksigifisi.FisKodu = CodeTool.fiskodolustur(onEk, no.ToString());

                    fisDal.AddOrUpdate(context, sayimeksigifisi);
                    foreach (var item in sayimeksigilist)
                    {
                        item.FisKodu = sayimeksigifisi.FisKodu;
                        stokHareketDal.AddOrUpdate(context, item);
                    }
                }
                context.SaveChanges();

            }


            //ReportsPrintTool yazdir = new ReportsPrintTool();
            //yazdir.RaporYazdir(fatura, belge);
            //int sonFisKodu = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu)) + 1;
            ////SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, sonFisKodu.ToString());
            //SettingsTool.Save();
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
            basariylaKaydedildi = true;
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
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            frmPersonelSec form = new frmPersonelSec(time);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemHareket in form.secilen.ToList())
                {
                    if (context.PersonelHareketleri.Local.Count(c =>
                            c.Donemi == time && c.PersonelKodu == itemHareket.PersonelKodu) == 0)
                    {
                        personelHareketDal.AddOrUpdate(context, itemHareket);
                    }
                }
                Toplamlar();
            }
        }
        private void lblBaslik_Click(object sender, EventArgs e)
        {
        }
        private void frmFisIslem_Shown(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }
        private void labelControl36_Click(object sender, EventArgs e)
        {
        }
        #region Güncellenen Toggle Event Alanı
        private void toggleKDVDahil_Toggled(object sender, EventArgs e)
        {
            HepsiniHesapla();
            Toplamlar();
        }
        #endregion
        private void gridKasaHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            OdenenTutarGuncelle();
            Toplamlar();
            HepsiniHesapla();
        }
        private void frmFisIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F6)
            {
                var val = txtBarkod.EditValue;
                if (val == null)
                {
                    val = "";
                }
                frmStokSec form = new frmStokSec(ref this.context, val.ToString());
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
                    HepsiniHesapla();
                    focusedSatirSec(s.StokId);
                    txtBarkod.Text = "";
                }
            }
        }
        private void btnKaydetYeni_Click(object sender, EventArgs e)
        {
            if (_fisentity.FisTuru == "Cari Devir Fişi")
            {
                if (toggleCariDevir.IsOn)
                {
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                }
                else
                {
                    ayarlar.KasaHareketi = "Kasa Giriş";
                }
            }
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
            if (_fisentity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += txtFisTuru.Text + " Türünde Cari Seçim Zorunludur. " + System.Environment.NewLine;
                hata++;
            }
            if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += " - Herhangi bir Ödeme Bulunamadı. " + System.Environment.NewLine;
                hata++;
            }
            if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true &&
                string.IsNullOrEmpty(lblCariKod.Text) && txtFisTuru.Text != "Hakediş Fişi")
            {
                message +=
                    "- Ödenmesi Gereken Tutar Ödenmemiş Görünüyor.Açık hesap satış yapabilmek için lütfen cari seçiniz." +
                    System.Environment.NewLine;
                hata++;
            }
            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            if (calcOdenemesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                if (MessageBox.Show(
                        $"Ödemenin # {calcOdenemesiGereken.Value.ToString("C2")} # tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. devam etmek istiyor musunuz?",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }
            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(cmbTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
            }
            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
            }
            if (ayarlar.OdemeEkrani)
            {
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null
                        ? Convert.ToDateTime(cmbTarih.DateTime)
                        : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.VadeTarihi = kasaVeri.VadeTarihi == null
                        ? Convert.ToDateTime(cmbVadeTarihi.DateTime)
                        : Convert.ToDateTime(kasaVeri.VadeTarihi);
                    kasaVeri.FisKodu = txtKod.Text;
                    kasaVeri.FisTuru = txtFisTuru.Text;
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        kasaVeri.CariId = _cariId;
                    }
                }
            }
            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.IskontoOrani1 = calcIndirimOrani.Value;
            _fisentity.IskontoTutari1 = calcIndirimTutari.Value;
            _fisentity.DipIskTutari = calcIndirimTutari.Value;
            kodOlustur.KodArttirma();
            fisDal.AddOrUpdate(context, _fisentity);
            context.SaveChanges();
            //ReportsPrintTool yazdir = new ReportsPrintTool();
            //yazdir.RaporYazdir(fatura, belge);
            //int sonFisKodu = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu)) + 1;
            ////SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, sonFisKodu.ToString());
            //SettingsTool.Save();
            MessageBox.Show("Fatura Başarılı bir şekilde kaydedildi.");
            if (gridStokHareket.RowCount != 0)
            {
                Temizle();
                _fisentity.CariId = null;
                _fisentity.BelgeNo = null;
                _fisentity.FisKodu = null;
                _fisentity.Aciklama = null;
                calcAraToplam.Text = null;
                calcGenelToplam.Text = null;
                calcIndirimOrani.Text = null;
                calcIndirimTutari.Text = null;
                calcKdvToplam.Text = null;
                calcMiktar.Text = "1";
                calcOdenemesiGereken.Text = null;
                calcOdenenTutar.Text = null;
                txtKod.Text = "";
                context.StokHareketleri.Local.Clear();
                context.KasaHareketleri.Local.Clear();
                context.PersonelHareketleri.Local.Clear();
                context.Kodlar.Local.Clear();
            }
            else
            {
                MessageBox.Show("Mevcutta bir fatura bulunmadı");
            }
        }
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
            //if (gridStokHareket.RowCount != 0)
            //{
            //    if (MessageBox.Show(
            //            "Bu Evrağı Faturalandırmak İstediğinize Emin Misiniz ? ",
            //            "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        _fisentity.FisTuru = "Toptan Satış Faturası";
            //        ayarlar.KasaHareketi = "Kasa Giriş";
            //        ayarlar.StokHareketi = "Stok Çıkış";
            //        _fisentity.Tarih = DateTime.Now;
            //        _fisentity.VadeTarihi = DateTime.Now;
            //        MessageBox.Show("Faturaya Dönüştürme işlemi gerçekleşti.");
            //    }
            //}
            //else
            //{
            //    this.Close();
            //}
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
        private void frmFisIslem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (basariylaKaydedildi == false && gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Satış Ekranında Ürünler Var. İşlemi İptal Edip Çıkmak İstediğinize Emin Misiniz?",
                        "DİKKAT", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void gridStokHareket_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private void gridContStokHareket_Click(object sender, EventArgs e)
        {
        }
        private void gridStokHareket_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }
        void HepsiniHesapla()
        {
            gridPrsonelHareket.UpdateSummary();
            context.Configuration.AutoDetectChangesEnabled = false;
            decimal toplamSatirIndirimTutari = 0;
            decimal toplamAraToplam = 0;
            decimal toplamKdvToplam = 0;
            decimal toplamGenelToplam = 0;
            decimal tumGridinSatirIndirimSonrasiToplami = 0;
            foreach (StokHareket item in context.StokHareketleri.Local)
            {
                decimal satirTutari = Convert.ToDecimal(item.Miktar) * Convert.ToDecimal(item.BirimFiyati);
                tumGridinSatirIndirimSonrasiToplami +=
                    satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100
                    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100) * Convert.ToDecimal(item.IndirimOrani2) / 100
                    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100
                    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100) * Convert.ToDecimal(item.IndirimOrani2) / 100) * Convert.ToDecimal(item.IndirimOrani3) / 100;
                //decimal indirim2 = satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100
                //    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100) * Convert.ToDecimal(item.IndirimOrani2) / 100;
                //decimal indirim3 = satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100
                //    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100) * Convert.ToDecimal(item.IndirimOrani2) / 100
                //    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100
                //    - (satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100) * Convert.ToDecimal(item.IndirimOrani2) / 100) * Convert.ToDecimal(item.IndirimOrani3) / 100;
            }
            foreach (StokHareket item in context.StokHareketleri.Local)
            {
                decimal miktar = Convert.ToDecimal(item.Miktar);
                decimal birimfiyat = Convert.ToDecimal(item.BirimFiyati);
                decimal kdv = Convert.ToDecimal(item.Kdv);
                decimal indirimOrani = Convert.ToDecimal(item.IndirimOrani);
                decimal indirimOrani2 = Convert.ToDecimal(item.IndirimOrani2);
                decimal indirimOrani3 = Convert.ToDecimal(item.IndirimOrani3);
                decimal aratoplam = miktar * birimfiyat;
                if (toggleKDVDahil.IsOn)
                {
                    aratoplam = aratoplam / (1 + kdv / 100);
                }
                toplamAraToplam += aratoplam;
                decimal satirIndirimSonrasiToplam = aratoplam
                    - aratoplam * indirimOrani / 100
                    - (aratoplam
                    - aratoplam * indirimOrani / 100) * indirimOrani2 / 100
                    - (aratoplam
                    - aratoplam * indirimOrani / 100
                    - (aratoplam
                    - aratoplam * indirimOrani / 100) * indirimOrani2 / 100) * indirimOrani3 / 100;
                decimal satirIndirimTutari = aratoplam - satirIndirimSonrasiToplam;
                toplamSatirIndirimTutari += satirIndirimTutari;
                decimal tumIndirimlerSonrasiToplam = 0;
                decimal dipIskontoPayi = 0;
                decimal dipIskontoOrani = Convert.ToDecimal(calcIndirimOrani.EditValue);
                decimal dipIskontoTutari = Convert.ToDecimal(calcIndirimTutari.EditValue);
                decimal kdvToplam = 0;
                decimal satirNetTutar = 0;
                if (toggleKDVDahil.IsOn)
                {
                    if (dipIskontoOrani != 0)
                    {
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - satirIndirimSonrasiToplam * dipIskontoOrani / 100;
                        dipIskontoPayi = satirIndirimSonrasiToplam - tumIndirimlerSonrasiToplam;
                    }
                    else if (dipIskontoTutari != 0)
                    {
                        dipIskontoPayi = dipIskontoTutari * satirIndirimSonrasiToplam / tumGridinSatirIndirimSonrasiToplami;
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - dipIskontoPayi;
                    }
                    else
                    {
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam;
                    }
                    //kdvToplam = tumIndirimlerSonrasiToplam - tumIndirimlerSonrasiToplam / (1 + kdv / 100);
                    kdvToplam = tumIndirimlerSonrasiToplam * (kdv / 100);
                    satirNetTutar = tumIndirimlerSonrasiToplam + kdvToplam;
                }
                else
                {
                    if (dipIskontoOrani != 0)
                    {
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - satirIndirimSonrasiToplam * dipIskontoOrani / 100;
                        dipIskontoPayi = satirIndirimSonrasiToplam - tumIndirimlerSonrasiToplam;
                    }
                    else if (dipIskontoTutari != 0)
                    {
                        dipIskontoPayi = dipIskontoTutari * satirIndirimSonrasiToplam / tumGridinSatirIndirimSonrasiToplami;
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - dipIskontoPayi;
                    }
                    else
                    {
                        tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam;
                    }
                    kdvToplam = tumIndirimlerSonrasiToplam * (kdv / 100);
                    satirNetTutar = tumIndirimlerSonrasiToplam + kdvToplam;
                }
                toplamKdvToplam += kdvToplam;
                toplamGenelToplam += satirNetTutar;
                int i = 0;
                while (i < gridStokHareket.RowCount)
                {
                    int stokId = Convert.ToInt32(gridStokHareket.GetRowCellValue(i, "StokId"));
                    if (stokId == item.StokId)
                    {
                        gridStokHareket.SetRowCellValue(i, "DipIskontoPayi", dipIskontoPayi);
                        gridStokHareket.SetRowCellValue(i, "KdvToplam", kdvToplam);
                        gridStokHareket.SetRowCellValue(i, "AraToplam", aratoplam);
                        gridStokHareket.SetRowCellValue(i, "IndirimTutar", satirIndirimTutari);
                        gridStokHareket.SetRowCellValue(i, "ToplamTutar", satirNetTutar);
                        //gridStokHareket.SetRowCellValue(i, "IndirimTutar2", satirIndirimTutari);
                        //gridStokHareket.SetRowCellValue(i, "IndirimTutar3", satirNetTutar);
                        break;
                    }
                    i++;
                }
            }
            calcKdvToplam.EditValue = toplamKdvToplam;
            calcAraToplam.EditValue = toplamAraToplam - toplamKdvToplam;
            calcAraToplam.EditValue = toplamAraToplam;
            calcGenelToplam.EditValue = toplamGenelToplam;
            calcIndirimToplami.EditValue = toplamSatirIndirimTutari;
            calcOdenemesiGereken.EditValue = toplamGenelToplam - calcOdenenTutar.Value;
            if (_fisentity.FisTuru == "Masraf Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            if (_fisentity.FisTuru == "Tahsilat Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            if (_fisentity.FisTuru == "Ödeme Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            if (_fisentity.FisTuru == "Cari Devir Fişi") calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            //if (_fisentity.FisTuru == "Hakediş Fişi") calcGenelToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
        }
        private void repoFiyat_EditValueChanged(object sender, EventArgs e)
        {
            gridStokHareket.PostEditor();
            HepsiniHesapla();
        }
        private void repoMiktar_EditValueChanged(object sender, EventArgs e)
        {
            gridStokHareket.PostEditor();
            HepsiniHesapla();
        }
        private void repoIskonto_EditValueChanged(object sender, EventArgs e)
        {
            gridStokHareket.PostEditor();
            HepsiniHesapla();
        }
        private void calcIndirimOrani_EditValueChanged(object sender, EventArgs e)
        {
            CalcEdit edit = sender as CalcEdit;
            if (Convert.ToDecimal(edit.EditValue) != 0)
            {
                calcIndirimTutari.Properties.ReadOnly = true;
            }
            else
            {
                calcIndirimTutari.Properties.ReadOnly = false;
            }
            HepsiniHesapla();
        }
        private void calcIndirimTutari_EditValueChanged(object sender, EventArgs e)
        {
            CalcEdit edit = sender as CalcEdit;
            if (Convert.ToDecimal(edit.EditValue) != 0)
            {
                calcIndirimOrani.Properties.ReadOnly = true;
            }
            else
            {
                calcIndirimOrani.Properties.ReadOnly = false;
            }
            HepsiniHesapla();
        }
        private void txtBarkod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //frmStokSec form = new frmStokSec(txtBarkod.EditValue.ToString());
                //    form.ShowDialog();
                frmStokSec form = new frmStokSec(ref this.context, txtBarkod.EditValue.ToString());
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
                    HepsiniHesapla();
                    txtBarkod.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }
        private void btnExcelAc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OleDbConnection CNN;
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;";
            DialogResult OkeyMi = openFileDialog1.ShowDialog();
            if (OkeyMi == DialogResult.OK)
            {
                if (!openFileDialog1.FileName.Contains(".xlsx"))
                    CNN = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFileDialog1.FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'");
                else
                    CNN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'");
                CNN.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter($"SELECT * FROM [Sayfa1$]", CNN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                CNN.Close();
                string olmayanBarkodlar = "";
                foreach (DataRow item in DT.Rows)
                {
                    Barkod entity;
                    StokHareket sh = new StokHareket();
                    string barkodveyastokkodu = item[DT.Columns[0].ColumnName].ToString();
                    var entityStok = context.Stoklar.FirstOrDefault(x => x.Barkodu == barkodveyastokkodu || x.StokKodu == barkodveyastokkodu);
                    if (entityStok != null)
                    {
                        sh = StokSec(entityStok);
                        sh.Miktar = Convert.ToDecimal(item[DT.Columns[1].ColumnName]);
                        sh.BirimFiyati = Convert.ToDecimal(item[DT.Columns[2].ColumnName]);
                        sh.IndirimOrani = Convert.ToDecimal(item[DT.Columns[3].ColumnName]);
                        sh.IndirimOrani2 = Convert.ToDecimal(item[DT.Columns[4].ColumnName]);
                        sh.IndirimOrani3 = Convert.ToDecimal(item[DT.Columns[5].ColumnName]);
                        stokHareketDal.AddOrUpdate(context, sh);
                        HepsiniHesapla();
                        Toplamlar();
                    }
                    else
                    {
                        entity = context.Barkodlar.Where(c => c.Barkodu == barkodveyastokkodu).SingleOrDefault();
                        if (entity != null)
                        {
                            sh = StokSec(entity.Stok);
                            sh.Miktar = Convert.ToDecimal(item[DT.Columns[1].ColumnName]);
                            sh.BirimFiyati = Convert.ToDecimal(item[DT.Columns[2].ColumnName]);
                            sh.IndirimOrani = Convert.ToDecimal(item[DT.Columns[3].ColumnName]);
                            sh.IndirimOrani2 = Convert.ToDecimal(item[DT.Columns[4].ColumnName]);
                            sh.IndirimOrani3 = Convert.ToDecimal(item[DT.Columns[5].ColumnName]);
                            stokHareketDal.AddOrUpdate(context, sh);
                            Toplamlar();
                            HepsiniHesapla();
                        }
                        else
                        {
                            olmayanBarkodlar += item[DT.Columns[0].ColumnName].ToString() + ",";
                        }
                    }
                }
                if (olmayanBarkodlar != "")
                {
                    MessageBox.Show(olmayanBarkodlar.Substring(0, olmayanBarkodlar.Length - 1) + "numarali barkodlar/stok kodlari bulunamadi");
                }
                MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            }
        }
        private void excelFaturaİşleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection CNN;
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;";
            DialogResult OkeyMi = openFileDialog1.ShowDialog();
            if (OkeyMi == DialogResult.OK)
            {
                if (!openFileDialog1.FileName.Contains(".xlsx"))
                    CNN = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFileDialog1.FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'");
                else
                    CNN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'");
                CNN.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter($"SELECT * FROM [Sayfa1$]", CNN);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                CNN.Close();
                string olmayanBarkodlar = "";
                foreach (DataRow item in DT.Rows)
                {
                    Barkod entity;
                    StokHareket sh = new StokHareket();
                    try
                    {
                        var str = item[DT.Columns[0].ColumnName].ToString();

                        var entityStok = context.Stoklar.FirstOrDefault(x => x.Barkodu == str || x.StokKodu == str);
                        if (entityStok != null)
                        {
                            sh = StokSec(entityStok);
                            sh.Miktar = Convert.ToDecimal(item[DT.Columns[1].ColumnName]);
                            sh.BirimFiyati = Convert.ToDecimal(item[DT.Columns[2].ColumnName]);
                            sh.IndirimOrani = Convert.ToDecimal(item[DT.Columns[3].ColumnName]);
                            sh.IndirimOrani2 = Convert.ToDecimal(item[DT.Columns[4].ColumnName]);
                            sh.IndirimOrani3 = Convert.ToDecimal(item[DT.Columns[5].ColumnName]);
                            stokHareketDal.AddOrUpdate(context, sh);
                            HepsiniHesapla();
                            Toplamlar();
                        }
                        else
                        {
                            entity = context.Barkodlar.Where(c => c.Barkodu == str).SingleOrDefault();
                            if (entity != null)
                            {
                                sh = StokSec(entity.Stok);
                                sh.Miktar = Convert.ToDecimal(item[DT.Columns[1].ColumnName]);
                                sh.BirimFiyati = Convert.ToDecimal(item[DT.Columns[2].ColumnName]);
                                sh.IndirimOrani = Convert.ToDecimal(item[DT.Columns[3].ColumnName]);
                                sh.IndirimOrani2 = Convert.ToDecimal(item[DT.Columns[4].ColumnName]);
                                sh.IndirimOrani3 = Convert.ToDecimal(item[DT.Columns[5].ColumnName]);
                                stokHareketDal.AddOrUpdate(context, sh);
                                Toplamlar();
                                HepsiniHesapla();
                            }
                            else
                            {
                                olmayanBarkodlar += item[DT.Columns[0].ColumnName].ToString() + ",";
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (olmayanBarkodlar != "")
                {
                    MessageBox.Show(olmayanBarkodlar.Substring(0, olmayanBarkodlar.Length - 1) + "numarali barkodlar/stok kodlari bulunamadi");
                }
                MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            }
        }
        private void repositoryItemButtonEdit5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string search = gridStokHareket.ActiveEditor.Text;
            //while (true)
            //{
            //    try
            //    {
            //        context.Stoklar.Count();
            //        break;
            //    }
            //    catch
            //    {
            //        Thread.Sleep(500);
            //    }
            //}
            //txtBarkod.Text = null;
            frmStokSec form = new frmStokSec(ref this.context, search);
            form.ShowDialog();
            if (form.secildi)
            {
                //Buradan
                var enti = form.secilen.First();
                if (MinStokAltinda(enti)) return;
                //Buraya kadar
                StokHareket s = StokSec(enti);
                //if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                //{
                //    s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                //    s.Miktar = s.Miktar + calcMiktar.Value;
                //}
                stokHareketDal.AddOrUpdate(context, s);
                Toplamlar();
                //calcMiktar.Value = 1;
                HepsiniHesapla();
            }
            gridStokHareket.RefreshData();
            gridContKasaHareket.Refresh();
        }
        private void repositoryItemButtonEdit6_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string search = gridStokHareket.ActiveEditor.Text;
            gridView1.AddNewRow();
            //while (true)
            //{
            //    try
            //    {
            //        context.Stoklar.Count();
            //        break;
            //    }
            //    catch
            //    {
            //        Thread.Sleep(500);
            //    }
            //}
            //txtBarkod.Text = null;
            frmStokSec form = new frmStokSec(ref this.context, search);
            form.ShowDialog();
            if (form.secildi)
            {
                //Buradan
                var enti = form.secilen.First();
                if (MinStokAltinda(enti)) return;
                //Buraya kadar
                StokHareket s = StokSec(enti);
                //if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                //{
                //    s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                //    s.Miktar = s.Miktar + calcMiktar.Value;
                //}
                context.StokHareketleri.Local.Remove(context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == 0));
                stokHareketDal.AddOrUpdate(context, s);
                Toplamlar();
                //calcMiktar.Value = 1;
                HepsiniHesapla();
            }
        }
        private void repositoryItemButtonEdit5_KeyDown(object sender, KeyEventArgs e)
        {
            string search = gridStokHareket.ActiveEditor.Text;
            if (e.KeyCode == Keys.Enter)
            {
                while (true)
                {
                    try
                    {
                        context.Stoklar.Count();
                        break;
                    }
                    catch
                    {
                        Thread.Sleep(500);
                    }
                }
                Barkod entity;
                var entityStok = context.Stoklar.FirstOrDefault(x => x.Barkodu == search);
                if (entityStok != null)
                {
                    if (MinStokAltinda(entityStok)) return;
                    StokHareket s = StokSec(entityStok);
                    stokHareketDal.AddOrUpdate(context, s);
                    HepsiniHesapla();
                    Toplamlar();
                }
                else
                {
                    entity = context.Barkodlar.Where(c => c.Barkodu == search).SingleOrDefault();
                    if (entity != null)
                    {
                        if (MinStokAltinda(entity.Stok)) return; StokHareket s = StokSec(entity.Stok);
                        stokHareketDal.AddOrUpdate(context, s);
                        Toplamlar();
                        HepsiniHesapla();
                    }
                    else
                    {
                        MessageBox.Show("Barkod Bulunamadı..");
                    }
                }
            }
            gridStokHareket.RefreshData();
            gridContKasaHareket.Refresh();
        }
        private void btnStokGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (gridStokHareket.RowCount != 0)
                {
                    sec = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
                    frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == sec));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void gridContStokHareket_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                try
                {
                    if (gridStokHareket.RowCount != 0)
                    {
                        sec = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
                        frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == sec));
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seçili Stok Bulunamadı");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (e.KeyCode == Keys.F10)
            {
                try
                {
                    if (gridStokHareket.RowCount != 0)
                    {
                        string aramaMetni = gridStokHareket.GetFocusedRowCellValue(colStokAdi).GetString();
                        frmStokSec form = new frmStokSec(ref this.context, aramaMetni);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seçili Stok Bulunamadı");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (e.KeyCode == Keys.F12)
            {
                try
                {
                    if (gridStokHareket.RowCount != 0)
                    {
                        sec = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
                        frmStokHareket frmstokhareket = new frmStokHareket(sec);
                        frmstokhareket.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seçili Stok Bulunamadı");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void btnExcelAktar_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridStokHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        private void görünümüKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fisentity.FisTuru == "Toptan Satış Faturası" || _fisentity.FisTuru == "Stok Devir Fişi" || _fisentity.FisTuru == "Sayım Fazlası Fişi" || _fisentity.FisTuru == "Sayım Eksiği Fişi" || _fisentity.FisTuru == "Alış Faturası")
            {
                gridStokHareket.ClearColumnsFilter();
                //if (!File.Exists(DosyaYolu)) File.Create(DosyaYolu);
                gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
            }
        }
        private void seçiliStoğuDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridStokHareket.RowCount != 0)
                {
                    sec = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
                    frmStokIslem form = new frmStokIslem(stokDAL.GetByFilter(context, c => c.Id == sec));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void faturaYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(txtKod.Text);
        }
        private void proformaFaturaYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.ProformaFaturaHazirlama(txtKod.Text);
        }
        private void siparişYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.SiparisHazirlama(txtKod.Text);
        }
        private void teklifYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.TeklifHazirlama(txtKod.Text);
        }
        private void irsaliyeYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.IrsaliyeHazirlama(txtKod.Text);
        }
        private void bilgiFişiYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaHazirla f = new FaturaHazirla();
            f.BilgiFisi(txtKod.Text);
        }
        private void FaturaOlustur()
        {
            string HarTipi = "";
            if (txtFisTuru.Text == "Alış Faturası")
            {
                HarTipi = "FA";
            }
            if (txtFisTuru.Text == "Toptan Satış Faturası")
            {
                HarTipi = "FS";
            }
            if (txtFisTuru.Text == "Alış İade Faturası")
            {
                HarTipi = "AI";
            }
            if (txtFisTuru.Text == "Satış İade Faturası")
            {
                HarTipi = "SI";
            }
            if (txtFisTuru.Text == "Satış İrsaliyesi")
            {
                HarTipi = "IS";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Alış İrsaliyesi")
            {
                HarTipi = "IA";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Alınan Sipariş Fişi")
            {
                HarTipi = "SA";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Verilen Sipariş Fişi")
            {
                HarTipi = "SV";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Verilen Teklif Fişi")
            {
                HarTipi = "TV";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Alınan Teklif Fişi")
            {
                HarTipi = "TA";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Stok Devir Fişi")
            {
                HarTipi = "SD";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Sayım Ekiği Fişi")
            {
                HarTipi = "SG";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Sayım Fazlası Fişi")
            {
                HarTipi = "SC";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Ödeme Fişi")
            {
                HarTipi = "OF";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Tahsilat Fişi")
            {
                HarTipi = "TF";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Cari Devir Fişi")
            {
                HarTipi = "CD";
                cmbTipi.Text = "-";
            }
            if (txtFisTuru.Text == "Masraf Fişi")
            {
                HarTipi = "MF";
                cmbTipi.Text = "-";
            }
            NetSatis.EDonusum.Models.Donusum.Master m = null;
            if (duzenle)
            {
                EDonusum.VTContext c = new EDonusum.VTContext();
                var res = c.Master.Where(x => x.FisKodu == txtKod.Text).FirstOrDefault();
                if (res != null)
                {
                    m = res;
                    m.Aciklama = txtAciklama.Text;
                    m.AlisVerisNo = _fisentity.Id;
                    m.DokumanKodu = "";
                    m.EditDate = DateTime.Now;
                    m.EditUser = frmAnaMenu.UserId;
                    m.FisKodu = txtKod.Text;
                    m.FisTuru = txtFisTuru.Text;
                    m.HareketTipi = eislem.HareketIdGetir(cmbTipi.Text);
                    m.HarTip = HarTipi;
                    m.IslemTarihi = Convert.ToDateTime(cmbTarih.Text);
                    m.Kdv = Convert.ToDecimal(calcKdvToplam.Value);
                    m.MusteriKodu = Convert.ToInt32(_fisentity.CariId);
                    m.Matrah = Convert.ToDecimal(calcGenelToplam.Value - calcKdvToplam.Value);
                    m.NetTutar = calcGenelToplam.Value;
                    m.SaveDate = DateTime.Now;
                    m.SaveUser = frmAnaMenu.UserId;
                    m.SeriKodu = txtSeri.Text;
                    m.SiraKodu = txtSira.Text;
                    m.Tutar = Convert.ToDecimal(calcAraToplam.Value);
                    m.VadeTarihi = Convert.ToDateTime(cmbVadeTarihi.Text);
                    m.DipIskonto = Convert.ToDecimal(calcIndirimToplami.Value);
                    DetailsDuzenle(eislem.MasterGuncelle(m), HarTipi);
                }
            }
            else
            {
                m = new EDonusum.Models.Donusum.Master
                {
                    Aciklama = txtAciklama.Text,
                    AlisVerisNo = _fisentity.Id,
                    DokumanKodu = "",
                    EditDate = DateTime.Now,
                    EditUser = frmAnaMenu.UserId,
                    FisKodu = txtKod.Text,
                    FisTuru = txtFisTuru.Text,
                    HareketTipi = eislem.HareketIdGetir(cmbTipi.Text),
                    HarTip = HarTipi,
                    IslemTarihi = Convert.ToDateTime(cmbTarih.Text),
                    Kdv = Convert.ToDecimal(calcKdvToplam.Value),
                    MusteriKodu = Convert.ToInt32(_fisentity.CariId),
                    Matrah = Convert.ToDecimal(calcGenelToplam.Value - calcKdvToplam.Value),
                    NetTutar = calcGenelToplam.Value,
                    SaveDate = DateTime.Now,
                    SaveUser = frmAnaMenu.UserId,
                    SeriKodu = txtSeri.Text,
                    SiraKodu = txtSira.Text,
                    Tutar = Convert.ToDecimal(calcAraToplam.Value),
                    VadeTarihi = Convert.ToDateTime(cmbVadeTarihi.Text),
                    DipIskonto = Convert.ToDecimal(calcIndirimToplami.Value)
                };
                DetailsDuzenle(eislem.MasterOlustur(m), HarTipi);

            }

        }
        private void DetailsDuzenle(int id, string HarTipi)
        {
            EDonusum.VTContext c = new EDonusum.VTContext();

            var detailsList = c.Detail.Where(x => x.MasterId == id).ToList();

            for (int i = 0; i < detailsList.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < gridStokHareket.RowCount; j++)
                {
                    int stokid = Convert.ToInt32(gridStokHareket.GetRowCellValue(j, "StokId"));

                    if (stokid == detailsList[i].StokId)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    eislem.DetailsSil(detailsList[i].Id);
                }
            }

            for (int i = 0; i < gridStokHareket.RowCount; i++)
            {
                decimal fyt = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString());
                decimal fyt2 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar"));
                int stokid = Convert.ToInt32(gridStokHareket.GetRowCellValue(i, "StokId"));
                NetSatis.EDonusum.Models.Donusum.Details d = null;
                if (duzenle)
                {
                    var res = c.Detail.Where(x => x.MasterId == id && x.StokId == stokid).FirstOrDefault();
                    if (res == null)
                    {
                        d = new EDonusum.Models.Donusum.Details
                        {
                            HareketTipi = eislem.HareketIdGetir(cmbTipi.Text),
                            //Magaza="",
                            HarTip = HarTipi,
                            Isk1 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani").ToString()),
                            Isk2 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani2").ToString()),
                            Isk3 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani3").ToString()),
                            IskontoTutar = Convert.ToDecimal(calcIndirimToplami.Value.ToString()),
                            Kdv = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString()),
                            KdvOrani = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Kdv").ToString()),
                            KdvDahilFiyat = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar".ToString())),
                            MasterId = id,
                            Matrah = fyt2 - fyt,
                            Miktar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Miktar")),
                            MusteriKodu = Convert.ToInt32(_fisentity.CariId),
                            StokId = stokid,
                            Tutar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "BirimFiyati").ToString())
                        };
                        eislem.DetailsOlustur(d);
                    }
                    else
                    {

                        res.HareketTipi = eislem.HareketIdGetir(cmbTipi.Text);
                        res.HarTip = HarTipi;
                        res.Isk1 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani").ToString());
                        res.Isk2 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani2").ToString());
                        res.Isk3 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani3").ToString());
                        res.IskontoTutar = Convert.ToDecimal(calcIndirimToplami.Value.ToString());
                        res.Kdv = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString());
                        res.KdvOrani = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Kdv").ToString());
                        res.KdvDahilFiyat = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar".ToString()));
                        res.MasterId = id;
                        res.Matrah = fyt2 - fyt;
                        res.Miktar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Miktar"));
                        res.MusteriKodu = Convert.ToInt32(_fisentity.CariId);
                        res.StokId = stokid;
                        res.Tutar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "BirimFiyati").ToString());
                        eislem.DetailsGuncelle(res);
                    }
                }
                else
                {
                    d = new EDonusum.Models.Donusum.Details
                    {
                        HareketTipi = eislem.HareketIdGetir(cmbTipi.Text),
                        //Magaza="",
                        HarTip = HarTipi,
                        Isk1 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani").ToString()),
                        Isk2 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani2").ToString()),
                        Isk3 = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimOrani3").ToString()),
                        IskontoTutar = Convert.ToDecimal(calcIndirimToplami.Value.ToString()),
                        Kdv = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString()),
                        KdvOrani = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Kdv").ToString()),
                        KdvDahilFiyat = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar".ToString())),
                        MasterId = id,
                        Matrah = fyt2 - fyt,
                        Miktar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "Miktar")),
                        MusteriKodu = Convert.ToInt32(_fisentity.CariId),
                        StokId = stokid,
                        Tutar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "BirimFiyati").ToString())
                    };
                    eislem.DetailsOlustur(d);
                }
            }
        }

        private void txtSeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtSira;
                string kod = txtSeri.Text;
                if (kod != "")
                {
                    var lastFis = context.Fisler.Where(x => x.Seri == kod).OrderByDescending(x => x.KayitTarihi).FirstOrDefault();
                    if (lastFis != null && lastFis.Sira != null && lastFis.Sira != "")
                    {
                        int serino = 1;
                        try
                        {
                            serino = Convert.ToInt32(lastFis.Sira) + 1;
                            txtSira.Text = serino.ToString();
                            txtSira.SelectionLength = 0;
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void gridStokHareket_ShownEditor(object sender, EventArgs e)
        {
            if (gridStokHareket.FocusedColumn.FieldName == "Miktar"
                || gridStokHareket.FocusedColumn.FieldName == "BirimFiyati"
                )
            {
                BeginInvoke(new Action(() =>
          {
              if (gridStokHareket.ActiveEditor != null)
              {
                  gridStokHareket.ActiveEditor.SelectAll();
              }
          }));

            }
        }

        private void calcMiktar_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }
        delegate void EditorSelectAllProc(Control c);
        void EditorSelectAll(Control c)
        {
            ((TextBox)c.Controls[0]).SelectAll();
        }

        private void calcMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtBarkod;
            }
        }

        private void calcIndirimOrani_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcIndirimTutari_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridStokHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void gridStokHareket_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            //GridView view = (GridView)sender;
            ////Check whether the indicator cell belongs to a data row
            //if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            //{
            //    e.Info.DisplayText = e.RowHandle.ToString() + 1;
            //}
        }

        private void stokKartınıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridStokHareket.RowCount != 0)
                {
                    string aramaMetni = gridStokHareket.GetFocusedRowCellValue(colStokAdi).GetString();
                    frmStokSec form = new frmStokSec(ref this.context, aramaMetni);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void seçiliStoğunHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridStokHareket.RowCount != 0)
                {
                    sec = Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId));
                    frmStokHareket frmstokhareket = new frmStokHareket(sec);
                    frmstokhareket.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gridStokHareket_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {


            if (e.Column.Caption == "Sıra No")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void repoKdv_EditValueChanged(object sender, EventArgs e)
        {

            gridStokHareket.PostEditor();
            HepsiniHesapla();
        }
    }
}

