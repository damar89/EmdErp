using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Fiş;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using NetSatis.BackOffice.Raporlar;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DevExpress.XtraGrid.Views.Grid;
using NetSatis.BackOffice;

namespace NetSatis.FrontOffice
{
    public partial class frmFrontOffice : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        public static string GidenBilgi = "";
        private int odemeTuruId;
        CariDAL cariDal = new CariDAL();
        decimal eskiFiyat = 0;
        Fis _fisentity = new Fis();
        CariBakiye _entityBakiye = new CariBakiye();
        private int bekleyenSatisId = 0;
        private int cagrilanSatisId = -1;
        private bool tekParca = false;
        List<BekleyenSatis> _bekleyenSatis = new List<BekleyenSatis>(); private Nullable<int> _cariId;
        int fisNo = 0;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\HizliSatis_SavedLayout.xml";
        public frmFrontOffice()
        {
            //WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            InitializeComponent();
            //frmKullaniciGiris girisform = new frmKullaniciGiris();
            //girisform.ShowDialog();
            context.Stoklar.Load();
            context.Depolar.Load();
            context.Kasalar.Load();
            context.Configuration.AutoDetectChangesEnabled = false;
            //txtKod.Text =
            //kodOlustur = new CodeTool(this, CodeTool.Table.Pos);
            //kodOlustur.BarButonOlustur();
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_doviz)))
            {
                calcDolar.Visible = true;
                calcEuro.Visible = true;
                calcRub.Visible = true;
                labelControl26.Visible = true;
                labelControl27.Visible = true;
                labelControl28.Visible = true;
            }
            //var stoklar = context.sto.AsNoTracking().Where(w=>w.Durumu).ToList();
            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            //context.StokHareketleri.Local.Reverse();
            ButonlariYukle();
            txtIslem.Text = "SATIŞ";//kodOlustur.KodArttirma();
        }
        private void HizliSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            Stok entity;
            entity = context.Stoklar.SingleOrDefault(c => c.StokKodu == buton.Name);
            if (entity != null)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(entity));
                gridStokHareket.FocusedRowHandle = 0;
                HepsiniHesapla();
            }
            else
            {
                MessageBox.Show("Stok Bulunamadı..");
            }
            calcMiktar.Value = 1;
            txtBarkod.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F9)
            {
                AcikHesap_Click(null, null);
                return true;
            }
            if (keyData == Keys.F1)
            {
                var buton = new SimpleButton
                {
                    Name = "nakit",
                    Tag = "1",
                };
                OdemeEkle_Click(buton, null);
            }
            if (keyData == Keys.F3)
            {
                var buton = new SimpleButton
                {
                    Name = "Kredi Kartı",
                    Tag = "2",
                };
                OdemeEkle_Click(buton, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
        private void ButonlariYukle()
        {
            foreach (var hizliSatisGrup in context.HizliSatisGruplari.ToList())
            {
                XtraTabPage page = new XtraTabPage { Name = hizliSatisGrup.Id.ToString(), Text = hizliSatisGrup.GrupAdi };
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);
                foreach (var hizliSatis in context.HizliSatislar.Where(c => c.GrupId == hizliSatisGrup.Id).ToList())
                {
                    SimpleButton button = new SimpleButton
                    {
                        Name = hizliSatis.StokKodu,
                        Text = hizliSatis.UrunAdi + Environment.NewLine + hizliSatis.Fiyati,
                        Appearance = { TextOptions = { WordWrap = WordWrap.Wrap }/*BackColor=Color.OrangeRed,ForeColor=Color.White*/},
                        Height = 70,
                        Width = 70,
                    };
                    Image img = byteArrayToImage(hizliSatis.Resim);
                    if (img != null)
                    {
                        Bitmap bitmapimg = ResizeImage(img, 50, 50);
                        button.ImageOptions.Image = bitmapimg;
                        button.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    }
                    button.Click += HizliSatis_Click;
                    panel.Controls.Add(button);
                }
                xtraTabControl1.TabPages.Add(page);
            }
            var AcikHesapButon = new SimpleButton
            {
                Name = "AcikHesap",
                Text = "&Açık Hesap",
                Height = 48,
                Width = 92,
                BackColor = Color.DarkCyan,
                ForeColor = Color.Black
            };
            AcikHesapButon.Click += AcikHesap_Click;
            flowOdemeTurleri.Controls.Add(AcikHesapButon);
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 48,
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
                Checked = true
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    Tag = item.Id,
                    GroupIndex = 1,
                    Height = 35,
                    Width = 92,
                    Checked = false
                };
                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }
        private void AcikHesap_Click(object sender, EventArgs e)
        {
            odemeTuruId = -1;
            DialogResult Soru;
            //radialYazdir.ShowPopup(MousePosition);
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi)) && !(Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu))))
            {
                FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
            }
            else if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi)) && (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu))))
            {
                Soru = MessageBox.Show("Bilgi Fişi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Soru == DialogResult.Yes)
                {
                    FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
                }
                else
                {
                    FisiKaydet(ReportsPrintTool.Belge.Diger);
                }
            }
            else
            {
                FisiKaydet(ReportsPrintTool.Belge.Diger);
            }
        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (btnOdemeBol.Checked)
            {
                if (calcOdenemesiGereken.Value == 0)
                {
                    MessageBox.Show("Ödenemesi gereken tutar ödenmiş durumda.");
                }
                else
                {
                    frmOdemeEkrani form = new frmOdemeEkrani(Convert.ToInt32(buton.Tag), calcOdenemesiGereken.Value);
                    form.ShowDialog();
                    if (form.entity != null)
                    {
                        kasaHareketDal.AddOrUpdate(context, form.entity);
                        OdenenTutarGuncelle();
                    }
                }
            }
            else
            {
                odemeTuruId = Convert.ToInt32(buton.Tag);
                tekParca = true;
                DialogResult Soru;
                //radialYazdir.ShowPopup(MousePosition);
                if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi)) && !(Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu))))
                {
                    FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
                }
                else if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi)) && (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu))))
                {
                    Soru = MessageBox.Show("Bilgi Fişi Yazdırmak İster isiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (Soru == DialogResult.Yes)
                    {
                        FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
                    }
                    else
                    {
                        FisiKaydet(ReportsPrintTool.Belge.Diger);
                    }
                }
                else
                {
                    FisiKaydet(ReportsPrintTool.Belge.Diger);
                }
            }
        }
        private void FisiKaydet(ReportsPrintTool.Belge belge)
        {
            HepsiniHesapla();
            OdenenTutarGuncelle();
            string message = null;
            int hata = 0;
            if (gridStokHareket.RowCount == 0)
            {
                message += "- Satış Ekranında eklenmiş bir ürün bulunamadı.." + System.Environment.NewLine;
                hata++;
            }
            if (gridKasaHareket.RowCount == 0 && btnOdemeBol.Checked && String.IsNullOrEmpty(lblCariKod.Text))
            {
                message += " - Herhangi bir Ödeme Bulunamadı. " + System.Environment.NewLine;
                hata++;
            }
            if (txtKod.Text == "")
            {
                message += "- Fiş Kodu Alanı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (calcOdenemesiGereken.Value != 0 && String.IsNullOrEmpty(lblCariKod.Text) && tekParca == false)
            {
                message += "- Ödenmesi Gereken Tutar Ödenmemiş Görünüyor. Ödenmeyen tutarı açık hesaba aktarabilmek için cari seçimi yapınız." + System.Environment.NewLine;
                hata++;
            }
            var ayar = context.Ayarlar.FirstOrDefault();
            if (ayar != null)
            {
                if (ayar.HizliSatisSiradakiNo > fisNo)
                {
                    txtKod.Text = CodeTool.fiskodolustur(ayar.HizliSatisOnEki, ayar.HizliSatisSiradakiNo.ToString());
                    fisNo = ayar.HizliSatisSiradakiNo;
                }
            }
            while (context.Fisler.Where(x => x.FisKodu == txtKod.Text).Count() > 0)
            {
                var firstIndexZero = txtKod.Text.IndexOf('0');
                var onEk = txtKod.Text.Substring(0, firstIndexZero);
                var no = Convert.ToInt32(txtKod.Text.Substring(firstIndexZero + 1, txtKod.Text.Length - 1 - firstIndexZero
                    ));
                no++;
                txtKod.Text = CodeTool.fiskodolustur(onEk, no.ToString());
                fisNo = no;
            }
            //if (odemeTuruId == 0)
            //{
            //    message += "- Ödeme türü seçilmemiş. Lütfen ödeme türünü seçin." + System.Environment.NewLine;
            //    hata++;
            //}
            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            if (btnOdemeBol.Checked && calcOdenemesiGereken.Value != 0)
            {
                if (MessageBox.Show($"Ödemenin{calcOdenemesiGereken.Value.ToString("C2")} tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. devam etmek isitor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }
            decimal toplamDipIskontoPayi = 0;
            if (txtIslem.Text == "İADE")
            {
                _fisentity.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende İade İrsaliyesi" : "Perakende İade Faturası";
            }
            else
            {
                _fisentity.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende Satış İrsaliyesi" : "Perakende Satış Faturası";
            }
            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                toplamDipIskontoPayi += Convert.ToDecimal(stokVeri.DipIskontoPayi);
                stokVeri.Tarih = Convert.ToDateTime(DateTime.Now);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = txtIslem.Text == "İADE" ? "Stok Giriş" : "Stok Çıkış";
                if (txtIslem.Text == "İADE")
                {
                    stokVeri.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende İade İrsaliyesi" : "Perakende İade Faturası";
                }
                else
                {
                    stokVeri.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende Satış İrsaliyesi" : "Perakende Satış Faturası";
                }
                for (int i = 0; i < gridStokHareket.RowCount; i++)
                {
                    string stokkodu = gridStokHareket.GetRowCellValue(i, "Stok.StokKodu").ToString();
                    string stokAdi = gridStokHareket.GetRowCellValue(i, "Stok.StokAdi").ToString();
                    if (stokVeri.Stok.StokKodu.Equals(stokkodu) && stokVeri.Stok.StokAdi.Equals(stokAdi))
                    {
                        stokVeri.ToplamTutar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "ToplamTutar").ToString());
                        stokVeri.KdvToplam = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvToplam").ToString());
                        stokVeri.KdvHaric_ = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "KdvHaric"));
                        stokVeri.IndirimTutar = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "IndirimTutar").ToString());
                        stokVeri.AraToplam = Convert.ToDecimal(gridStokHareket.GetRowCellValue(i, "AraToplam").ToString());
                    }
                }
            }
            foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
            {
                kasaVeri.Tarih = Convert.ToDateTime(DateTime.Now);
                //kasaVeri.Tarih = kasaVeri.Tarih == null
                //    ? Convert.ToDateTime(DateTime.Now)
                //    : Convert.ToDateTime(kasaVeri.Tarih);
                kasaVeri.FisKodu = txtKod.Text;
                kasaVeri.Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş";
                if (txtIslem.Text == "İADE")
                {
                    kasaVeri.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende İade İrsaliyesi" : "Perakende İade Faturası";
                }
                else
                {
                    kasaVeri.FisTuru = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende Satış İrsaliyesi" : "Perakende Satış Faturası";
                }
                kasaVeri.CariId = _cariId;
            }
            _fisentity.FisKodu = txtKod.Text;
            _fisentity.BelgeNo = txtBelgeNo.Text;
            _fisentity.Aciklama = txtAciklama.Text;
            _fisentity.FaturaUnvani = txtFaturaUnvani.Text;
            _fisentity.CepTelefonu = txtCepTel.Text;
            _fisentity.Il = txtIl.Text;
            _fisentity.Ilce = txtIlce.Text;
            _fisentity.Semt = txtSemt.Text;
            _fisentity.Adres = txtAdres.Text;
            _fisentity.VergiDairesi = txtVergiDairesi.Text;
            _fisentity.VergiNo = txtVergiNo.Text;
            _fisentity.KDVDahil = true;
            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.IskontoOrani1 = calcIndirimOrani.Value;
            _fisentity.IskontoTutari1 = calcIndirimToplami.Value;
            _fisentity.Tarih = Convert.ToDateTime(DateTime.Now);
            _fisentity.AraToplam_ = txtAraToplam.Value;
            _fisentity.KdvToplam_ = calcKdvToplam.Value;
            _fisentity.DipIskTutari = calcIndirimTutari.Value;
            _fisentity.DipIskNetTutari = toplamDipIskontoPayi;
            _fisentity.DipIskOran = calcIndirimOrani.Value;
            //kodOlustur.KodArttirma();
            bool result = fisDal.AddOrUpdate(context, _fisentity);
            if (!result)
            {
                return;
            }
            int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().KasaId);
            if (!btnOdemeBol.Checked && odemeTuruId != -1)
            {
                string ft = "";
                if (txtIslem.Text == "İADE")
                {
                    ft = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende İade İrsaliyesi" : "Perakende İade Faturası";
                }
                else
                {
                    ft = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu)) && _fisentity.CariId != null && _fisentity.CariId != 0 ? "Perakende Satış İrsaliyesi" : "Perakende Satış Faturası";
                }
                kasaHareketDal.AddOrUpdate(context, new KasaHareket
                {
                    CariId = _cariId,
                    FisKodu = txtKod.Text,
                    Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                    FisTuru = ft,
                    KasaId = kasaid,
                    OdemeTuruId = odemeTuruId,
                    Tarih = Convert.ToDateTime(DateTime.Now),
                    Tutar = calcGenelToplam.Value
                });
                OdenenTutarGuncelle();
            }
            context.SaveChanges();
            btnOdemeBol.Checked = false;
            radialYazdir.HidePopup();
            switch (belge)
            {
                case ReportsPrintTool.Belge.Fatura:
                    //ReportsPrintTool yazdir = new ReportsPrintTool();
                    //rptFaturaBarkodlu fatura = new rptFaturaBarkodlu(txtKod.Text);
                    //yazdir.RaporYazdir(fatura, belge);
                    FaturaHazirla f = new FaturaHazirla();
                    f.FaturaHazirlama(txtKod.Text);
                    break;
                case ReportsPrintTool.Belge.BilgiFisi:
                    FaturaHazirla yazdirBilgiFisi = new FaturaHazirla();
                    yazdirBilgiFisi.BilgiFisi(txtKod.Text);
                    break;
            }
            if (cagrilanSatisId != -1)
            {
                var secilen = _bekleyenSatis.SingleOrDefault(c => c.Id == cagrilanSatisId);
                _bekleyenSatis.Remove(secilen);
                flowBekleyenSatislar.Controls.Find(Convert.ToString(cagrilanSatisId), false).SingleOrDefault().Dispose();
                cagrilanSatisId = -1;
            }
            FisTemizle();
            string FisKoduBilgisi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_PesFisKodu);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_PesFisKodu, Convert.ToString(Convert.ToInt32(FisKoduBilgisi) + 1));
            SettingsTool.Save();
            context.Configuration.AutoDetectChangesEnabled = true;
            Ayar fisayar = context.Ayarlar.First();
            fisayar.HizliSatisSiradakiNo += 1;
            context.SaveChanges();
            context.Configuration.AutoDetectChangesEnabled = false;
            txtKod.Text = CodeTool.fiskodolustur(ayar.HizliSatisOnEki, (ayar.HizliSatisSiradakiNo).ToString());
            tekParca = false;
            txtBarkod.Focus();
            txtIslem.Text = "SATIŞ";
            txtIslem.BackColor = Color.Green;
            txtIslem.ForeColor = Color.White;
            odemeTuruId = 0;
        }
        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            calcOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenemesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
        }
        private void FisTemizle()
        {
            _fisentity = new Fis();
            _cariId = null;
            lblRiskLimiti.Text = null;
            lblCariKod.Text = null;
            lblCariAd.Text = null;
            txtKod.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTel.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtAdres.Text = null;
            txtSemt.Text = null;
            txtOdenenTutar.Text = null;
            txtParaUstu.Text = null;
            calcDusur.Value = 0;
            calcIndirimOrani.Value = 0;
            calcMaliyet.Value = 0;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
            btnTemizle.PerformClick();
            var cikarilacakKayit = context.ChangeTracker.Entries()
                .Where(c => c.Entity is KasaHareket || c.Entity is StokHareket || c.Entity is Fis).ToList();
            foreach (var kayit in cikarilacakKayit)
            {
                context.Entry(kayit.Entity).State = EntityState.Detached;
            }
            Toplamlar();
            OdenenTutarGuncelle();
            txtBarkod.Focus();
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
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Tag);
            }
        }
        private void BekleyenSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            BekleyenSatisYukle(Convert.ToInt32(buton.Name));
        }
        private void btnSatisBeklet_Click(object sender, EventArgs e)
        {
            SatisBeklet();
        }
        private void SatisBeklet()
        {
            if (gridStokHareket.RowCount == 0)
            {
                MessageBox.Show("Satış bekletebilmeniz için ürün eklemeniz gerekmektedir.");
                return;
            }
            int bekleyenId;
            BekleyenSatis satis;
            if (cagrilanSatisId != -1)
            {
                bekleyenId = cagrilanSatisId;
                satis = _bekleyenSatis.SingleOrDefault(c => c.Id == bekleyenId);
                var buton = (SimpleButton)flowBekleyenSatislar.Controls.Find(Convert.ToString(bekleyenId), false).SingleOrDefault();
                buton.Text = lblCariKod.Text + " - " + lblCariAd.Text + "\n" + context.StokHareketleri.Local.Count +
                             " adet ürün eklendi." + "\n" + calcGenelToplam.Value.ToString("C2");
            }
            else
            {
                bekleyenId = bekleyenSatisId;
                satis = new BekleyenSatis();
                satis.BekleyenFis = new Fis();
                satis.Id = bekleyenId;
                SimpleButton BekleyenButon = new SimpleButton
                {
                    Name = bekleyenSatisId.ToString(),
                    Text = lblCariKod.Text + " - " + lblCariAd.Text + "\n" + "\n" + context.StokHareketleri.Local.Count + " adet ürün eklendi." + "\n" + calcGenelToplam.Value.ToString("C2"),
                    Height = 95,
                    Width = flowBekleyenSatislar.Width - 5
                };
                BekleyenButon.Click += BekleyenSatis_Click;
                flowBekleyenSatislar.Controls.Add(BekleyenButon);
                bekleyenSatisId++;
            }
            satis.BekleyenFis.CariId = _fisentity.CariId;
            satis.BekleyenFis.Cari = _fisentity.Cari;
            satis.BekleyenFis.Aciklama = _fisentity.Aciklama;
            satis.BekleyenFis.Adres = _fisentity.Adres;
            satis.BekleyenFis.BelgeNo = _fisentity.BelgeNo;
            satis.BekleyenFis.CepTelefonu = _fisentity.CepTelefonu;
            satis.BekleyenFis.FaturaUnvani = _fisentity.FaturaUnvani;
            satis.BekleyenFis.FisTuru = _fisentity.FisTuru;
            satis.BekleyenFis.Il = _fisentity.Il;
            satis.BekleyenFis.Ilce = _fisentity.Ilce;
            satis.BekleyenFis.Semt = _fisentity.Semt;
            satis.BekleyenFis.PlasiyerId = _fisentity.PlasiyerId;
            satis.BekleyenFis.VergiDairesi = _fisentity.VergiDairesi;
            satis.BekleyenFis.VergiNo = _fisentity.VergiNo;
            satis.BekleyenFis.Adres = _fisentity.Adres;
            satis.BekleyenFis.IskontoOrani1 = calcIndirimOrani.Value;
            satis.StokHareketi = context.StokHareketleri.Local.ToList();
            satis.KasaHareketi = context.KasaHareketleri.Local.ToList();
            CheckButton personelButonYok = (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();
            personelButonYok.Checked = true;
            if (cagrilanSatisId == -1)
            {
                _bekleyenSatis.Add(satis);
            }
            cagrilanSatisId = -1;
            FisTemizle();
            var ayar = context.Ayarlar.FirstOrDefault();
            if (ayar != null)
            {
                txtKod.Text = CodeTool.fiskodolustur(ayar.HizliSatisOnEki, ayar.HizliSatisSiradakiNo.ToString());
                fisNo = ayar.HizliSatisSiradakiNo;
            }
            txtBarkod.Focus();
        }
        private void BekleyenSatisYukle(int id)
        {
            if (cagrilanSatisId == -1 && gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Bekleyen satışı çağırmadan önce mevcuttaki satışı beklemeye almak ister misiniz =",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SatisBeklet();
                }
            }
            FisTemizle();
            var SatisBilgisi = _bekleyenSatis.SingleOrDefault(c => c.Id == id);
            _fisentity.CariId = SatisBilgisi.BekleyenFis.CariId;
            var cariBilgi = context.Cariler.SingleOrDefault(c => c.Id == _fisentity.CariId);
            if (cariBilgi != null)
            {
                _entityBakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(SatisBilgisi.BekleyenFis.CariId));
                lblRiskLimiti.Text = _entityBakiye.RiskLimiti.ToString("C2");
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
                lblCariKod.Text = cariBilgi.CariKodu;
                lblCariAd.Text = cariBilgi.CariAdi;
            }
            _fisentity.PlasiyerId = SatisBilgisi.BekleyenFis.PlasiyerId;
            var personelBilgi = context.Personeller.SingleOrDefault(c => c.Id == _fisentity.PlasiyerId);
            if (personelBilgi != null)
            {
                CheckButton personelButon = (CheckButton)flowPersonel.Controls
                    .Find(personelBilgi.PersonelKodu, false).SingleOrDefault();
                personelButon.Checked = true;
            }
            else
            {
                CheckButton personelButonYok =
                    (CheckButton)flowPersonel.Controls.Find("Yok", false).SingleOrDefault();
                personelButonYok.Checked = true;
            }
            var ayar = context.Ayarlar.FirstOrDefault();
            if (ayar != null)
            {
                txtKod.Text = CodeTool.fiskodolustur(ayar.HizliSatisOnEki, ayar.HizliSatisSiradakiNo.ToString());
                fisNo = ayar.HizliSatisSiradakiNo;
            }
            //txtKod.Text =
            //CodeTool.fiskodolustur(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_PesFisOnEki), SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_PesFisKodu));
            txtBelgeNo.Text = SatisBilgisi.BekleyenFis.BelgeNo;
            txtAciklama.Text = SatisBilgisi.BekleyenFis.Aciklama;
            txtFaturaUnvani.Text = SatisBilgisi.BekleyenFis.FaturaUnvani;
            txtCepTel.Text = SatisBilgisi.BekleyenFis.CepTelefonu;
            txtIl.Text = SatisBilgisi.BekleyenFis.Il;
            txtIlce.Text = SatisBilgisi.BekleyenFis.Ilce;
            txtAdres.Text = SatisBilgisi.BekleyenFis.Adres;
            txtVergiDairesi.Text = SatisBilgisi.BekleyenFis.VergiDairesi;
            txtVergiNo.Text = SatisBilgisi.BekleyenFis.VergiNo;
            calcGenelToplam.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.ToplamTutar);
            txtAraToplam.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.AraToplam_);
            calcDusur.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.DipIskTutari);
            calcIndirimOrani.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.IskontoOrani1);
            calcIndirimTutari.Value = Convert.ToDecimal(SatisBilgisi.BekleyenFis.IskontoTutari1);
            foreach (var item in SatisBilgisi.StokHareketi)
            {
                context.StokHareketleri.Local.Add(item);
            }
            foreach (var item in SatisBilgisi.KasaHareketi)
            {
                context.KasaHareketleri.Local.Add(item);
            }
            cagrilanSatisId = id;
            Toplamlar();
            HepsiniHesapla();
            OdenenTutarGuncelle();
        }
        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = null;
            frmStokSec form = new frmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                StokHareket s = StokSec(form.secilen.First());
                if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                {
                    s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                    s.Miktar++;
                }
                stokHareketDal.AddOrUpdate(context, s);
                Toplamlar();
                HepsiniHesapla();
            }
            txtBarkod.Focus();
        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDal indirimDal = new IndirimDal();
            var Barkod = context.Barkodlar.FirstOrDefault(c => c.StokId == entity.Id);
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.IndirimOrani2 = 0;
            stokHareket.IndirimOrani3 = 0;
            int depoid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().DepoId);
            stokHareket.DepoId = depoid;
            stokHareket.BirimFiyati = txtIslem.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = calcMiktar.Value;
            stokHareket.MaliyetFiyati = entity.AlisFiyati1 ?? 0;
            stokHareket.Tarih = Convert.ToDateTime(DateTime.Now);
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }
        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            calcIndirimTutari.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 *
                                      calcIndirimOrani.Value;
            calcKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            calcGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) + (calcKdvToplam.Value) - calcIndirimTutari.Value;
            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            txtAraToplam.Value = calcGenelToplam.Value - (calcIndirimToplami.Value + calcKdvToplam.Value);
            //calcMaliyet.EditValue = Convert.ToDecimal(colMaliyetTutar.SummaryItem.SummaryValue);
            txtParaUstu.Value = txtOdenenTutar.Value - calcGenelToplam.Value;
            calcOdenemesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
            HepsiniHesapla();
        }
        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Satışı iptal etmem istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _fisentity.BelgeNo = null;
                    _fisentity.FisKodu = null;
                    _fisentity.Aciklama = null;
                    btnTemizle_Click(sender, e);
                    context.StokHareketleri.Local.Clear();
                    calcGenelToplam.Text = null;
                    calcIndirimOrani.Text = null;
                    calcIndirimToplami.Text = null;
                    calcKdvToplam.Text = null;
                    calcOdenemesiGereken.Text = null;
                    calcOdenenTutar.Text = null;
                    txtOdenenTutar.Text = "";
                    txtParaUstu.Text = "";
                    calcDusur.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Mevcutta bir satış işlemi bulunamadı.");
            }
            txtBarkod.Focus();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _cariId = null;
            lblCariKod.Text = null;
            lblCariAd.Text = null;
            _fisentity.CariId = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTel.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtAdres.Text = null;
            txtSemt.Text = null;
            lblRiskLimiti.Text = "Görüntülenemiyor";
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
            txtBarkod.Focus();
        }
        private void checkIade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIade.Checked)
            {
                txtIslem.Text = "İADE";
                txtIslem.BackColor = Color.Red;
                txtIslem.ForeColor = Color.White;
            }
            else
            {
                txtIslem.Text = "SATIŞ";
                txtIslem.BackColor = Color.Green;
                txtIslem.ForeColor = Color.White;
            }
            txtBarkod.Focus();
        }
        private void ParaEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            txtOdenenTutar.Value += ConverterTool.stringToDecimal(buton.Tag.ToString(), ".");
            Toplamlar();
            HepsiniHesapla();
            txtBarkod.Focus();
        }
        private void txtOdenenTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtOdenenTutar.Value = 0;
            Toplamlar();
            HepsiniHesapla();
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
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
                    gridStokHareket.FocusedRowHandle = 0;
                    Toplamlar();
                    HepsiniHesapla();
                }
                else
                {
                    entity = context.Barkodlar.Where(c => c.Barkodu == txtBarkod.Text).SingleOrDefault();
                    if (entity != null)
                    {
                        StokHareket s = StokSec(entity.Stok);
                        if (context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId) != null)
                        {
                            s = context.StokHareketleri.Local.ToBindingList().FirstOrDefault(x => x.StokId == s.StokId);
                            s.Miktar = s.Miktar + calcMiktar.Value;
                        }
                        stokHareketDal.AddOrUpdate(context, s);
                        gridStokHareket.FocusedRowHandle = 0;
                        Toplamlar();
                        HepsiniHesapla();
                    }
                    else
                    {
                        MessageBox.Show("Barkod Bulunamadı..");
                    }
                }
                txtBarkod.Text = "";
                calcMiktar.Value = 1;
            }
            txtBarkod.Focus();
        }
        private void calcIndirimOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
            HepsiniHesapla();
        }
        private void txtOdenenTutar_EditValueChanged(object sender, EventArgs e)
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
        private void txtIslem_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void btnIslemBitir_Click(object sender, EventArgs e)
        {
            //radialYazdir.ShowPopup(MousePosition);
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi)))
            {
                FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
            }
            else
            {
                FisiKaydet(ReportsPrintTool.Belge.Diger);
            }
            txtBarkod.Focus();
        }
        private void bntFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.Fatura);
        }
        private void btnBilgiFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
        }
        private void frmFrontOffice_Load(object sender, EventArgs e)
        {
            gridContStokHareket.ForceInitialize();
            if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
            txtBarkod.Focus();
            calcMiktar.Value = 1;
            var ayar = context.Ayarlar.FirstOrDefault();
            if (ayar != null)
            {
                txtKod.Text = CodeTool.fiskodolustur(ayar.HizliSatisOnEki, ayar.HizliSatisSiradakiNo.ToString());
                fisNo = ayar.HizliSatisSiradakiNo;
            }
            //txtKod.Text =
            //    CodeTool.fiskodolustur(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_PesFisOnEki), SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_PesFisKodu));
        }
        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //calcMaliyet.EditValue = Convert.ToDecimal(colMaliyetTutar.SummaryItem.SummaryValue);
            OdenenTutarGuncelle();
        }
        private void repoDepo_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec form = new frmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colId)));
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoKodu, form.entity.Id);
                context.ChangeTracker.DetectChanges();
            }
        }
        private void repoSeri_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            frmSeriNoGir form = new frmSeriNoGir(veri, false);
            form.ShowDialog(); gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }
        private void frmFrontOffice_Shown(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }
        private void frmFrontOffice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                btnStokBul.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnCariAc.PerformClick();
            }
            if (e.KeyCode == Keys.F11)
            {
                frmCariSec form = new frmCariSec();
                form.ShowDialog();
                if (form.secildi)
                {
                    Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                    _entityBakiye = this.cariDal.cariBakiyesi(context, entity.Id);
                    _cariId = entity.Id;
                    _fisentity.CariId = entity.Id;
                    lblCariKod.Text = entity.CariKodu;
                    lblCariAd.Text = entity.CariAdi;
                    txtFaturaUnvani.Text = entity.FaturaUnvani;
                    txtVergiDairesi.Text = entity.VergiDairesi;
                    txtVergiNo.Text = entity.VergiNo;
                    txtCepTel.Text = entity.CepTelefonu;
                    txtIl.Text = entity.Il;
                    txtIlce.Text = entity.Ilce;
                    txtAdres.Text = entity.Adres;
                    txtSemt.Text = entity.Semt;
                    lblRiskLimiti.Text = _entityBakiye.RiskLimiti.ToString("C2");
                    lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                    lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
                }
                txtBarkod.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnSatisBeklet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnSatisIptal.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnFiyatGor.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Delete)
            {
                btnTemizle1.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.M)
            {
                GidenBilgi = calcMaliyet.Value.ToString();
                frmMaliyet frm = new frmMaliyet();
                frm.ShowDialog();
            }
        }
        private void btnBelgesiz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.Diger);
        }
        private void fisIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption);
            form.Show();
        }
        private void btnCariAc_Click(object sender, EventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                _entityBakiye = this.cariDal.cariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisentity.CariId = entity.Id;
                lblCariKod.Text = entity.CariKodu;
                lblCariAd.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTel.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtAdres.Text = entity.Adres;
                txtSemt.Text = entity.Semt;
                lblRiskLimiti.Text = _entityBakiye.RiskLimiti.ToString("C2");
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
            }
            txtBarkod.Focus();
        }
        private void btnKasaRpr_Click(object sender, EventArgs e)
        {
            frmKasaTarih form = new frmKasaTarih();
            form.Show();
        }
        private void btnSatisRpr_Click(object sender, EventArgs e)
        {
            frmTarihliPesSatis form = new frmTarihliPesSatis();
            form.Show();
        }
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
        private void btnStokBul_Click(object sender, EventArgs e)
        {
            try
            {
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
                    gridStokHareket.FocusedRowHandle = 0;
                    Toplamlar();
                    HepsiniHesapla();
                    calcMiktar.Value = 1;
                    txtBarkod.Text = "";
                }
            }
            catch (Exception)
            {
            }
            txtBarkod.Focus();
        }
        private void btnCariSec1_Click(object sender, EventArgs e)
        {

        }
        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            lblCariKod.Text = null;
            lblCariAd.Text = null;
            _cariId = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTel.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtAdres.Text = null;
            txtSemt.Text = null;
            lblRiskLimiti.Text = "Görüntülenemiyor";
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
            txtBarkod.Focus();
        }
        private void btnOdemeBol_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOdemeBol.Checked)
            {
                navigationFrame1.SelectedPage = navOdeme;
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = false;
            }
            else
            {
                navigationFrame1.SelectedPage = navStokHareket;
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = true;
            }
            txtBarkod.Focus();
        }
        private void repoOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }
        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            radialMenu1.ShowPopup(MousePosition);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmTarihliStokSatis frm = new frmTarihliStokSatis();
            frm.Show();
        }
        private void calcGenelToplam_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_doviz)))
            {
                try
                {
                    calcEuro.Value = calcGenelToplam.Value / (Convert.ToDecimal(SettingsTool.AyarOku(SettingsTool.Ayarlar.DolarKur_Euro)));
                    calcRub.Value = calcGenelToplam.Value / (Convert.ToDecimal(SettingsTool.AyarOku(SettingsTool.Ayarlar.DolarKur_Rub)));
                    calcDolar.Value = calcGenelToplam.Value / (Convert.ToDecimal(SettingsTool.AyarOku(SettingsTool.Ayarlar.DolarKur_Usd)));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void btnMasrafRapor_Click(object sender, EventArgs e)
        {
            frmTarihliMasraf frm = new frmTarihliMasraf();
            frm.Show();
        }
        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            frmFiyatGor frm = new frmFiyatGor(new Entities.Tables.Stok());
            frm.ShowDialog();
        }
        private void calcIndirimToplami_EditValueChanged(object sender, EventArgs e)
        {
        }
        void HepsiniHesapla()
        {
            gridStokHareket.UpdateTotalSummary();
            decimal toplamSatirIndirimTutari = 0;
            decimal toplamAraToplam = 0;
            decimal toplamKdvToplam = 0;
            decimal toplamGenelToplam = 0;
            decimal tumGridinSatirIndirimSonrasiToplami = 0;
            foreach (StokHareket item in context.StokHareketleri.Local)
            {
                decimal satirTutari = Convert.ToDecimal(item.Miktar) * Convert.ToDecimal(item.BirimFiyati);
                tumGridinSatirIndirimSonrasiToplami += satirTutari - satirTutari * Convert.ToDecimal(item.IndirimOrani) / 100;
            }
            foreach (StokHareket item in context.StokHareketleri.Local)
            {
                decimal miktar = Convert.ToDecimal(item.Miktar);
                decimal birimfiyat = Convert.ToDecimal(item.BirimFiyati);
                decimal kdv = Convert.ToDecimal(item.Kdv);
                decimal indirimOrani = Convert.ToDecimal(item.IndirimOrani);
                decimal aratoplam = miktar * birimfiyat;
                toplamAraToplam += aratoplam;
                decimal satirIndirimSonrasiToplam = aratoplam - aratoplam * indirimOrani / 100;
                decimal satirIndirimTutari = aratoplam - satirIndirimSonrasiToplam;
                toplamSatirIndirimTutari += satirIndirimTutari;
                decimal tumIndirimlerSonrasiToplam = 0;
                decimal dipIskontoPayi = 0;
                decimal dipIskontoOrani = Convert.ToDecimal(calcIndirimOrani.EditValue);
                decimal dipIskontoTutari = Convert.ToDecimal(calcDusur.EditValue);
                decimal kdvToplam = 0;
                decimal satirNetTutar = 0;
                if (dipIskontoTutari != 0)
                {
                    dipIskontoPayi = dipIskontoTutari * satirIndirimSonrasiToplam / tumGridinSatirIndirimSonrasiToplami;
                    tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - dipIskontoPayi;
                }
                else if (dipIskontoOrani != 0)
                {
                    tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam - satirIndirimSonrasiToplam * dipIskontoOrani / 100;
                    dipIskontoPayi = satirIndirimSonrasiToplam - tumIndirimlerSonrasiToplam;
                }
                else
                {
                    tumIndirimlerSonrasiToplam = satirIndirimSonrasiToplam;
                }
                kdvToplam = tumIndirimlerSonrasiToplam - tumIndirimlerSonrasiToplam / (1 + kdv / 100);
                satirNetTutar = tumIndirimlerSonrasiToplam;
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
                        break;
                    }
                    i++;
                }
            }
            calcKdvToplam.EditValue = toplamKdvToplam;
            txtAraToplam.EditValue = toplamAraToplam - toplamKdvToplam;
            txtAraToplam.EditValue = toplamAraToplam;
            calcGenelToplam.EditValue = toplamGenelToplam;
            calcIndirimToplami.EditValue = toplamSatirIndirimTutari;
            calcOdenemesiGereken.EditValue = toplamGenelToplam - calcOdenenTutar.Value;
            txtParaUstu.Value = txtOdenenTutar.Value - calcGenelToplam.Value;
            calcMaliyet.Value = Convert.ToDecimal(colMaliyetTutar.SummaryItem.SummaryValue);
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
        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Olan Satırı Silmek İstediğinize Emin Misiniz ?", "Uyarı",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridStokHareket.DeleteSelectedRows();
                    Toplamlar();
                    HepsiniHesapla();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void repoFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Stok fiyatEntity =
                context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = _fisentity.FisTuru == "Alış Faturası"
                ? fiyatEntity.AlisFiyati1 ?? 0
                : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = _fisentity.FisTuru == "Alış Faturası"
                ? fiyatEntity.AlisFiyati2 ?? 0
                : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = _fisentity.FisTuru == "Alış Faturası"
                ? fiyatEntity.AlisFiyati3 ?? 0
                : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }
        private void btnRaporIade_Click(object sender, EventArgs e)
        {
            frmTarihliIade frm = new frmTarihliIade();
            frm.Show();
        }
        private void gridStokHareket_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void gridStokHareket_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarkod.Focus();
            }
        }
        private void gridStokHareket_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Irsaliye = (bool)checkIrsaliye.Checked;
            Properties.Settings.Default.Save();
        }
        private void btnDizaynKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }
    }
}
