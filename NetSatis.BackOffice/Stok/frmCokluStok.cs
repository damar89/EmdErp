using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Microsoft.Win32;
using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmCokluStok : DevExpress.XtraEditors.XtraForm
    {
        //Mesaj_Fonksiyonlari Mesajlar = new Mesaj_Fonksiyonlari();
        NetSatisContext DB = new NetSatisContext();
        OleDbConnection CNN;
        public frmCokluStok()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Excel dosyasının aktif olarak okunup dosyada olan sayfaların isimlerinin listelendiği alandır.. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnExcelAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbProviders.EditValue.ToString().Contains("Microsoft.ACE.OLEDB"))
            {
                string provider = cmbProviders.EditValue.ToString();
                OpenFileDialog OFD = new OpenFileDialog
                {
                    Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx",
                    Title = "Lütfen Stok Kayıtları Dosyasını Seçininiz..."
                };
                DialogResult OkeyMi = OFD.ShowDialog();
                if (OkeyMi == DialogResult.OK)
                {
                    try
                    {
                        CNN = new OleDbConnection($@"Provider={provider};Data Source={OFD.FileName}; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                        CNN.Open();
                        DataTable dtSheet = CNN.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        repositoryItemComboBox2.Items.Clear();
                        repositoryItemComboBox2.Items.Add("Bir Sayfa Seçin...");
                        cmbSheets.EditValue = "Bir Sayfa Seçin...";
                        foreach (DataRow drSheet in dtSheet.Rows)
                        {
                            if (drSheet["TABLE_NAME"].ToString().Contains("$"))//checks whether row contains '_xlnm#_FilterDatabase' or sheet name(i.e. sheet name always ends with $ sign)
                            {
                                repositoryItemComboBox2.Items.Add(drSheet["TABLE_NAME"].ToString());
                                //listSheet.Add(drSheet["TABLE_NAME"].ToString());
                            }
                        }
                        CNN.Close();
                        MessageBox.Show("Excel dosyası sayfaları listelendi. Şimdi bir Excel Sayfası seçin.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bir provider seçimi yapmalısınız.");
            }
        }
        /// <summary>
        /// Gridde alanların listelenmesi ile alan isimleri de ortaya çıkar. Bu alan isimleri database'deki alan 
        /// isimleri ile eşleştirme amacıyla tüm comboboxlara yüklenir. Daha sonra ekleme için, gridde'ki hangi alan 
        /// database'deki hangi alana eklenecek seçilir. 
        /// </summary>
        /// <param name="cmb"></param>
        private void BaslikYukle(ComboBoxEdit cmb)
        {
            ComboBoxItemCollection data = cmb.Properties.Items;
            data.Clear();
            data.BeginUpdate();
            data.Add("");
            for (int i = 0; i < gridListe.Columns.Count; i++)
            {
                data.Add(gridListe.Columns[i].FieldName);
            }
            data.EndUpdate();
            cmb.SelectedIndex = 0;
        }
        /// <summary>
        /// Form yüklendiğinde Windowsdaki OLEDB Sürücülerini kontrol ederek ilgili combobox'a yüklenir.
        /// Bu sürücü/provider aracılığı ile Excel dosyaları okunabilir. 
        /// Provider olmadığı durumlarda excel dosyasının okunması mümkün olmayacaktır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCokluStok_Load(object sender, EventArgs e)
        {
            string AccessDBAsValue = string.Empty;
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes");
            if (registryKey != null)
            {
                foreach (string subKey in registryKey.GetSubKeyNames())
                {
                    if (subKey.Contains("Microsoft.ACE.OLEDB") && !subKey.Contains("Error"))
                    {
                        repositoryItemComboBox1.Items.Add(subKey);
                    }
                }
            }
            if (repositoryItemComboBox1.Items.Count < 1)
            {
                repositoryItemComboBox1.Items.Add("Kayıtlı Provider Yok");
                cmbProviders.EditValue = "Kayıtlı Provider Yok";
            }
            else
            {
                cmbProviders.EditValue = "Bir Provider Seçin";
            }
        }
        /// <summary>
        /// Formdaki işaret kutularının durumlarına göre comboboxların aktif veya pasif olmasını sağlayan metoddur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxKontrol(object sender, EventArgs e)
        {
            CheckEdit box = sender as CheckEdit;
            switch (box.Name)
            {
                case "chkStokAdi":
                    cmbStokAdi.Enabled = box.Checked;
                    break;
                case "chkBarkod":
                    cmbBarkod.Enabled = box.Checked;
                    break;
                case "chkBarkodTuru":
                    cmbBarkodTuru.Enabled = box.Checked;
                    break;
                case "chkStokBirim":
                    cmbStokBirim.Enabled = box.Checked;
                    break;
                case "chkGarantiSuresi":
                    cmbGarantiSuresi.Enabled = box.Checked;
                    break;
                case "chkMinStokMiktari":
                    cmbMinStokMiktari.Enabled = box.Checked;
                    break;
                case "chkMaxStokMiktari":
                    cmbMaxStokMiktari.Enabled = box.Checked;
                    break;
                case "chkAciklama":
                    cmbAciklama.Enabled = box.Checked;
                    break;
                case "chkKategori":
                    cmbKategori.Enabled = box.Checked;
                    break;
                case "chkKategoriKodu":
                    cmbKategoriKodu.Enabled = box.Checked;
                    break;
                case "chkAnaGrup":
                    cmbAnaGrup.Enabled = box.Checked;
                    break;
                case "chkAnaGrupKodu":
                    cmbAnaGrupKodu.Enabled = box.Checked;
                    break;
                case "chkAltGrup":
                    cmbAltGrup.Enabled = box.Checked;
                    break;
                case "chkAltGrupKodu":
                    cmbAltGrupKodu.Enabled = box.Checked;
                    break;
                case "chkMarka":
                    cmbMarka.Enabled = box.Checked;
                    break;
                case "chkUretici":
                    cmbUretici.Enabled = box.Checked;
                    break;
                case "chkModel":
                    cmbModel.Enabled = box.Checked;
                    break;
                case "chkProje":
                    cmbProje.Enabled = box.Checked;
                    break;
                case "chkPozisyon":
                    cmbPozisyon.Enabled = box.Checked;
                    break;
                case "chkSezonYil":
                    cmbSezonYil.Enabled = box.Checked;
                    break;
                case "chkOzelKod":
                    cmbOzelKod.Enabled = box.Checked;
                    break;
                case "chkKDV":
                    cmbKDV.Enabled = box.Checked;
                    break;
                case "chkAlisFiyat1":
                    cmbAlisFiyat1.Enabled = box.Checked;
                    break;
                case "chkAlisFiyat2":
                    cmbAlisFiyat2.Enabled = box.Checked;
                    break;
                case "chkAlisFiyat3":
                    cmbAlisFiyat3.Enabled = box.Checked;
                    break;
                case "chkSatisFiyat1":
                    cmbSatisFiyat1.Enabled = box.Checked;
                    break;
                case "chkSatisFiyat2":
                    cmbSatisFiyat2.Enabled = box.Checked;
                    break;
                case "chkSatisFiyat3":
                    cmbSatisFiyat3.Enabled = box.Checked;
                    break;
                case "chkDevirMiktar":
                    cmbDevirMiktar.Enabled = box.Checked;
                    break;
                case "chkSatisFiyat4":
                    cmbSatisFiyat4.Enabled = box.Checked;
                    break;
                case "chkWebSatis":
                    cmbWebSatis.Enabled = box.Checked;
                    break;
                case "chkWebBayi":
                    cmbWebBayi.Enabled = box.Checked;
                    break;
            }
        }
        /// <summary>
        /// <para>
        /// Verilerin database'e işlenmesi için kullanılan metoddur. Öncelikle tüm verileri, combobox'larda seçili olan, grid
        /// alanlarından çekerek değişkenlere aktarır. sonra Öncelikle grid satırıda geçen birim database'de kayıtlı mı kontrol
        /// edilir. Kayıtlı ise database'deki veri kullanılır. Kayıtlı değilse yeni bir birim oluşturulur. aynı yöntemle
        /// grup da kontrol edilir. Son olarak aynı yöntemle stok koduna bağlı stok olup olmadığına bakılır. 
        /// </para>
        /// <para>
        /// Eğer stok önceden database'de kayıtlı değil ise, yeni bir kayıt oluşturularak bilgiler girilir. Ancak önceden kayıtlı
        /// bir stok ise, kullanıcıya bir uyarı mesajı verilerek güncelleme için onay istenir. Onay verilirse, stok bilgileri güncellenir.
        /// </para>
        /// </summary>
        private void VeriEkle()
        {
            #region Değişkenler
            string StokKodu, StokAdi, Barkodu, BarkodTuru, Birim, KategoriDegisken, AnaGrupDegisken, AltGrupDegisken, Marka, Uretici,
        Modeli, Proje, Pozisyon, SezonYil, OzelKodu, GarantiSuresi, SatisKdv, KategoriKodu, AnaGrupKodu, AltGrupKodu,
        AlisFiyati1, AlisFiyati2, AlisFiyati3, SatisFiyati1, SatisFiyati2, SatisFiyati3, SatisFiyati4, WebSatisFiyat, WebBayiFiyat,
        MinmumStokMiktari, MaxmumStokMiktari, Aciklama, DevirMiktar;
            #endregion
            Fis stokDevirFisi = new Fis();
            var kod = DB.Kodlar.Where(c => c.Tablo == "fis").First();
            stokDevirFisi.FisKodu = CodeTool.fiskodolustur(kod.OnEki.ToString(), kod.SonDeger.ToString());
            stokDevirFisi.FisTuru = "Stok Devir Fişi";
            stokDevirFisi.Tarih = DateTime.Now;
            stokDevirFisi.VadeTarihi = DateTime.Now;
            decimal fisKdvToplam = 0, fisAraToplam = 0, fisToplamTutar = 0;
            bool yeniStokEklendi = false;
            int yeniFisId = 0;
            Invoke((MethodInvoker)delegate
            {
                progressKayit.Properties.Maximum = gridListe.RowCount;
            });
            for (int i = 0; i < gridListe.RowCount; i++)
            {
                try
                {
                    #region Alan Bilgilerinin Çekilmesi
                    StokKodu = VeriAl(cmbStokKodu, i);
                    StokAdi = VeriAl(cmbStokAdi, i);
                    Barkodu = VeriAl(cmbBarkod, i);
                    BarkodTuru = VeriAl(cmbBarkodTuru, i);
                    Birim = VeriAl(cmbStokBirim, i);
                    KategoriDegisken = VeriAl(cmbKategori, i);
                    KategoriKodu = VeriAl(cmbKategoriKodu, i);
                    AnaGrupDegisken = VeriAl(cmbAnaGrup, i);
                    AnaGrupKodu = VeriAl(cmbAnaGrupKodu, i);
                    AltGrupDegisken = VeriAl(cmbAltGrup, i);
                    AltGrupKodu = VeriAl(cmbAltGrupKodu, i);
                    Marka = VeriAl(cmbMarka, i);
                    Uretici = VeriAl(cmbUretici, i);
                    Modeli = VeriAl(cmbModel, i);
                    Proje = VeriAl(cmbProje, i);
                    Pozisyon = VeriAl(cmbPozisyon, i);
                    SezonYil = VeriAl(cmbSezonYil, i);
                    OzelKodu = VeriAl(cmbOzelKod, i);
                    GarantiSuresi = VeriAl(cmbGarantiSuresi, i);
                    SatisKdv = VeriAl(cmbKDV, i);
                    AlisFiyati1 = VeriAl(cmbAlisFiyat1, i);
                    AlisFiyati2 = VeriAl(cmbAlisFiyat2, i);
                    AlisFiyati3 = VeriAl(cmbAlisFiyat3, i);
                    SatisFiyati1 = VeriAl(cmbSatisFiyat1, i);
                    SatisFiyati2 = VeriAl(cmbSatisFiyat2, i);
                    SatisFiyati3 = VeriAl(cmbSatisFiyat3, i);
                    SatisFiyati4 = VeriAl(cmbSatisFiyat4, i);
                    WebSatisFiyat = VeriAl(cmbWebSatis, i);
                    WebBayiFiyat = VeriAl(cmbWebBayi, i);
                    MinmumStokMiktari = VeriAl(cmbMinStokMiktari, i);
                    MaxmumStokMiktari = VeriAl(cmbMaxStokMiktari, i);
                    Aciklama = VeriAl(cmbAciklama, i);
                    DevirMiktar = VeriAl(cmbDevirMiktar, i);
                    #endregion
                    DB = new NetSatisContext();
                    //burası 2
                    #region Tanım Kontrolleri
                    if (chkMarka.Checked) TanimKontrol(Marka, frmTanim.TanimTuru.Marka);
                    if (chkModel.Checked) TanimKontrol(Modeli, frmTanim.TanimTuru.Model);
                    if (chkOzelKod.Checked) TanimKontrol(OzelKodu, frmTanim.TanimTuru.OzelKod);
                    if (chkPozisyon.Checked) TanimKontrol(Pozisyon, frmTanim.TanimTuru.Pozisyon);
                    if (chkProje.Checked) TanimKontrol(Proje, frmTanim.TanimTuru.Proje);
                    if (chkSezonYil.Checked) TanimKontrol(SezonYil, frmTanim.TanimTuru.SezonYil);
                    if (chkStokBirim.Checked) TanimKontrol(Birim, frmTanim.TanimTuru.Birim);
                    if (chkUretici.Checked) TanimKontrol(Uretici, frmTanim.TanimTuru.Uretici);
                    #endregion
                    Entities.Tables.Stok stok = DB.Stoklar.FirstOrDefault(x => x.StokKodu == StokKodu);
                    #region Eğer Stok Databasede Kayıtlı İse Barkod işlemlerini yapıyoruz.
                    if (stok != null)
                    {
                        if (chkBarkod.Checked)
                        {
                            if (string.IsNullOrEmpty(stok.Barkodu) || string.IsNullOrWhiteSpace(stok.Barkodu))
                            {
                                stok.Barkodu = Barkodu;
                            }
                            else if (!string.IsNullOrEmpty(Barkodu) || !string.IsNullOrWhiteSpace(Barkodu))
                            {
                                Barkod b = DB.Barkodlar.FirstOrDefault(x => x.Barkodu == Barkodu);
                                if (b == null)
                                {
                                    b = new Barkod();
                                    b.StokId = stok.Id;
                                    b.Barkodu = Barkodu;
                                    DB.Barkodlar.Add(b);
                                    DB.SaveChanges();
                                }
                            }
                        }
                        DB.SaveChanges();
                    }
                    #endregion
                    #region Eğer Stok Databasede Kayıtlı Değil İse
                    else
                    {
                        if (!yeniStokEklendi && DevirMiktar != "" && DevirMiktar != "0")
                        {
                            yeniStokEklendi = true;
                            DB.Fisler.Add(stokDevirFisi);
                            yeniFisId = stokDevirFisi.Id;
                            CodeTool ct = new CodeTool();
                            ct.KodArttirma("fis");
                        }
                        stok = new Entities.Tables.Stok();
                        stok.Aciklama = chkAciklama.Checked ? Aciklama : "";
                        stok.AlisFiyati1 = chkAlisFiyat1.Checked ? decimal.Parse(AlisFiyati1) : 0;
                        stok.AlisFiyati2 = chkAlisFiyat2.Checked ? decimal.Parse(AlisFiyati2) : 0;
                        stok.AlisFiyati3 = chkAlisFiyat3.Checked ? decimal.Parse(AlisFiyati3) : 0;
                        stok.AltGrup = chkAltGrup.Checked ? AltGrupKodu : "";
                        stok.AnaGrup = chkAnaGrup.Checked ? AnaGrupKodu : "";
                        stok.Barkodu = chkBarkod.Checked ? Barkodu : "";
                        stok.BarkodTuru = chkBarkodTuru.Checked ? BarkodTuru : "";
                        stok.Birim = chkStokBirim.Checked ? Birim : "";
                        stok.GarantiSuresi = chkGarantiSuresi.Checked ? GarantiSuresi : "";
                        stok.Kategori = chkKategori.Checked ? KategoriKodu : "";
                        stok.Marka = chkMarka.Checked ? Marka : "";
                        stok.KayitTarihi = DateTime.Now;
                        stok.MaxmumStokMiktari = chkMinStokMiktari.Checked ? decimal.Parse(MinmumStokMiktari) : 0;
                        stok.MaxmumStokMiktari = chkMaxStokMiktari.Checked ? decimal.Parse(MaxmumStokMiktari) : 0;
                        stok.Modeli = chkModel.Checked ? Modeli : "";
                        stok.OzelKodu = chkOzelKod.Checked ? OzelKodu : "";
                        stok.Pozisyon = chkPozisyon.Checked ? Pozisyon : "";
                        stok.Proje = chkProje.Checked ? Proje : "";
                        stok.SatisFiyati1 = chkSatisFiyat1.Checked ? decimal.Parse(SatisFiyati1) : 0;
                        stok.SatisFiyati2 = chkSatisFiyat2.Checked ? decimal.Parse(SatisFiyati2) : 0;
                        stok.SatisFiyati3 = chkSatisFiyat3.Checked ? decimal.Parse(SatisFiyati3) : 0;
                        stok.SatisFiyati4 = chkSatisFiyat4.Checked ? decimal.Parse(SatisFiyati4) : 0;
                        stok.WebSatisFiyati = chkWebSatis.Checked ? decimal.Parse(WebSatisFiyat) : 0;
                        stok.WebBayiSatisFiyati = chkWebBayi.Checked ? decimal.Parse(WebBayiFiyat) : 0;
                        stok.SatisKdv = chkKDV.Checked ? int.Parse(SatisKdv) : 0;
                        stok.SezonYil = chkSezonYil.Checked ? SezonYil : "";
                        stok.StokAdi = chkStokAdi.Checked ? StokAdi : "";

                        stok.StokKodu = StokKodu;
                        stok.Uretici = chkUretici.Checked ? Uretici : "";
                        stok.Durumu = true;
                        stok.WebAcikMi = false;
                        DB.Stoklar.Add(stok);
                        DB.SaveChanges();
                        if (DevirMiktar != "" && DevirMiktar != "0")
                        {
                            NetSatisContext context= new NetSatisContext();
                            StokHareket stokHar = new StokHareket();
                            stokHar.StokId = stok.Id;
                            stokHar.Hareket = "Stok Giriş";
                            stokHar.FisKodu = stokDevirFisi.FisKodu;
                            stokHar.KayitTarihi = DateTime.Now;
                            stokHar.SaveUser = frmAnaMenu.UserId;
                            stokHar.Miktar = Convert.ToDecimal(DevirMiktar);
                            stokHar.Tipi = "DV";
                            stokHar.Kdv = chkKDV.Checked ? int.Parse(SatisKdv) : 0;
                            stokHar.BirimFiyati = chkAlisFiyat1.Checked ? decimal.Parse(AlisFiyati1) : 0;
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
                            fisKdvToplam += Convert.ToDecimal(stokHar.KdvToplam);
                            fisAraToplam += Convert.ToDecimal(stokHar.AraToplam);
                            fisToplamTutar += Convert.ToDecimal(stokHar.ToplamTutar);
                            DB.StokHareketleri.Add(stokHar);
                            DB.SaveChanges();
                        }
                    }
                    #endregion
                    var kategori = DB.Kategoriler.FirstOrDefault(x => x.Kod == KategoriKodu);
                    var anagrup = DB.AnaGruplar.FirstOrDefault(x => x.Kod == AnaGrupKodu);
                    var altgrup = DB.AltGruplar.FirstOrDefault(x => x.Kod == AltGrupKodu);
                    if (kategori == null)
                    {
                        Kategori k = new Kategori();
                        k.Kod = KategoriKodu;
                        k.KategoriAdi = KategoriDegisken;
                        k.KayitTarihi = DateTime.Now;

                        DB.Kategoriler.Add(k);
                        DB.SaveChanges();
                    }
                    if (anagrup == null)
                    {
                        AnaGrup k = new AnaGrup();
                        k.Kod = AnaGrupKodu;
                        k.AnaGrupAdi = AnaGrupDegisken;
                        k.KayitTarihi = DateTime.Now;
                        k.SaveUser = frmAnaMenu.UserId;
                        DB.AnaGruplar.Add(k);
                        DB.SaveChanges();
                    }
                    if (altgrup == null)
                    {
                        AltGrup k = new AltGrup();
                        k.Kod = AltGrupKodu;
                        k.AltGrupAdi = AltGrupDegisken;
                        k.KayitTarihi = DateTime.Now;
                        k.SaveUser = frmAnaMenu.UserId;
                        DB.AltGruplar.Add(k);
                        DB.SaveChanges();
                    }
                    //DB.StoklarGruplari.Add(new StokGrubu { StokID = stok.ID, GrupID = grup.ID });
                    //DB.SaveChanges();
                    Invoke((MethodInvoker)delegate
                    {
                        progressKayit.PerformStep();
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }
            Fis fis = DB.Fisler.FirstOrDefault(x => x.Id == yeniFisId);
            if (fis != null)
            {
                stokDevirFisi.KdvToplam_ = fisKdvToplam;
                stokDevirFisi.AraToplam_ = fisAraToplam;
                stokDevirFisi.ToplamTutar = fisToplamTutar;
            }
            DB.SaveChanges();
            MessageBox.Show("Verilerin eklenmesi hatasız bir şekilde tamamlanmıştır.");
        }
        /// <summary>
        /// Verilerin güncelleme işleminin yapıldığı metoddur. Ekleme metodu ile benzer şekilde çalışır.
        /// Sadece alanların aktif olup olmadıklarına göre güncelleme işlemi gerçekleştirir.
        /// </summary>
        public void VeriGuncelle()
        {
            #region Değişkenler
            string StokKodu, StokAdi, Barkodu, BarkodTuru, Birim, KategoriDegisken, AnaGrupDegisken, AltGrupDegisken, Marka, Uretici,
        Modeli, Proje, Pozisyon, SezonYil, OzelKodu, GarantiSuresi, SatisKdv, KategoriKodu, AnaGrupKodu, AltGrupKodu,
        AlisFiyati1, AlisFiyati2, AlisFiyati3, SatisFiyati1, SatisFiyati2, SatisFiyati3, SatisFiyati4, WebSatisFiyat, WebBayiFiyat,
        MinmumStokMiktari, MaxmumStokMiktari, Aciklama; int EditUser;
            #endregion
            for (int i = 0; i < gridListe.RowCount; i++)
            {
                #region Alan Bilgilerinin Çekilmesi
                StokKodu = VeriAl(cmbStokKodu, i);
                StokAdi = VeriAl(cmbStokAdi, i);
                Barkodu = VeriAl(cmbBarkod, i);
                BarkodTuru = VeriAl(cmbBarkodTuru, i);
                Birim = VeriAl(cmbStokBirim, i);
                KategoriDegisken = VeriAl(cmbKategori, i);
                KategoriKodu = VeriAl(cmbKategoriKodu, i);
                AnaGrupDegisken = VeriAl(cmbAnaGrup, i);
                AnaGrupKodu = VeriAl(cmbAnaGrupKodu, i);
                AltGrupDegisken = VeriAl(cmbAltGrup, i);
                AltGrupKodu = VeriAl(cmbAltGrupKodu, i);
                Marka = VeriAl(cmbMarka, i);
                Uretici = VeriAl(cmbUretici, i);
                Modeli = VeriAl(cmbModel, i);
                Proje = VeriAl(cmbProje, i);
                Pozisyon = VeriAl(cmbPozisyon, i);
                SezonYil = VeriAl(cmbSezonYil, i);
                OzelKodu = VeriAl(cmbOzelKod, i);
                GarantiSuresi = VeriAl(cmbGarantiSuresi, i);
                SatisKdv = VeriAl(cmbKDV, i);
                AlisFiyati1 = VeriAl(cmbAlisFiyat1, i);
                AlisFiyati2 = VeriAl(cmbAlisFiyat2, i);
                AlisFiyati3 = VeriAl(cmbAlisFiyat3, i);
                SatisFiyati1 = VeriAl(cmbSatisFiyat1, i);
                SatisFiyati2 = VeriAl(cmbSatisFiyat2, i);
                SatisFiyati3 = VeriAl(cmbSatisFiyat3, i);
                EditUser = frmAnaMenu.UserId;
                SatisFiyati4 = VeriAl(cmbSatisFiyat4, i);
                WebSatisFiyat = VeriAl(cmbWebSatis, i);
                WebBayiFiyat = VeriAl(cmbWebBayi, i);
                MinmumStokMiktari = VeriAl(cmbMinStokMiktari, i);
                MaxmumStokMiktari = VeriAl(cmbMaxStokMiktari, i);
                Aciklama = VeriAl(cmbAciklama, i);
                #endregion
                #region Güncelleme İşlemi
                Entities.Tables.Stok stok = DB.Stoklar.FirstOrDefault(x => x.StokKodu == StokKodu);
                if (stok != null)
                {
                    if (chkAciklama.Checked) stok.Aciklama = Aciklama;
                    if (chkAlisFiyat1.Checked) stok.AlisFiyati1 = decimal.Parse(AlisFiyati1);
                    if (chkAlisFiyat2.Checked) stok.AlisFiyati2 = decimal.Parse(AlisFiyati2);
                    if (chkAlisFiyat3.Checked) stok.AlisFiyati3 = decimal.Parse(AlisFiyati3);
                    if (chkAltGrup.Checked) stok.AltGrup = AltGrupKodu;
                    if (chkAnaGrup.Checked) stok.AnaGrup = AnaGrupKodu;
                    if (chkBarkod.Checked) stok.Barkodu = Barkodu;
                    if (chkBarkodTuru.Checked) stok.BarkodTuru = BarkodTuru;
                    if (chkStokBirim.Checked) stok.Birim = Birim;
                    if (chkGarantiSuresi.Checked) stok.GarantiSuresi = GarantiSuresi;
                    if (chkKategori.Checked) stok.Kategori = KategoriKodu;
                    if (chkMarka.Checked) stok.Marka = Marka;
                    if (chkMinStokMiktari.Checked) stok.MaxmumStokMiktari = decimal.Parse(MinmumStokMiktari);
                    if (chkMaxStokMiktari.Checked) stok.MaxmumStokMiktari = decimal.Parse(MaxmumStokMiktari);
                    if (chkModel.Checked) stok.Modeli = Modeli;
                    if (chkOzelKod.Checked) stok.OzelKodu = OzelKodu;
                    if (chkPozisyon.Checked) stok.Pozisyon = Pozisyon;
                    if (chkProje.Checked) stok.Proje = Proje;
                    if (chkSatisFiyat1.Checked) stok.SatisFiyati1 = decimal.Parse(SatisFiyati1);
                    if (chkSatisFiyat2.Checked) stok.SatisFiyati2 = decimal.Parse(SatisFiyati2);
                    if (chkSatisFiyat3.Checked) stok.SatisFiyati3 = decimal.Parse(SatisFiyati3);
                    if (chkSatisFiyat4.Checked) stok.SatisFiyati4 = decimal.Parse(SatisFiyati4);
                    if (chkWebSatis.Checked) stok.WebSatisFiyati = decimal.Parse(WebSatisFiyat);
                    if (chkWebBayi.Checked) stok.WebBayiSatisFiyati = decimal.Parse(WebBayiFiyat);
                    if (chkKDV.Checked) stok.SatisKdv = int.Parse(SatisKdv);
                    if (chkSezonYil.Checked) stok.SezonYil = SezonYil;
                    if (chkStokAdi.Checked) stok.StokAdi = StokAdi;
                    if (chkUretici.Checked) stok.Uretici = Uretici;
                }
                DB.SaveChanges();
                var kategori = DB.Kategoriler.FirstOrDefault(x => x.Kod == KategoriKodu);
                var anagrup = DB.AnaGruplar.FirstOrDefault(x => x.Kod == AnaGrupKodu);
                var altgrup = DB.AltGruplar.FirstOrDefault(x => x.Kod == AltGrupKodu);
                if (kategori == null)
                {
                    Kategori k = new Kategori();
                    k.Kod = KategoriKodu;
                    k.KategoriAdi = KategoriDegisken;
                    k.EditUser = frmAnaMenu.UserId;
                    k.GuncellemeTarihi = DateTime.Now;
                    DB.Kategoriler.Add(k);
                    DB.SaveChanges();
                }
                if (anagrup == null)
                {
                    AnaGrup k = new AnaGrup();
                    k.Kod = KategoriKodu;
                    k.AnaGrupAdi = AnaGrupDegisken;
                    k.EditUser = frmAnaMenu.UserId;
                    k.GuncellemeTarihi = DateTime.Now;
                    DB.AnaGruplar.Add(k);
                    DB.SaveChanges();
                }
                if (altgrup == null)
                {
                    AltGrup k = new AltGrup();
                    k.Kod = KategoriKodu;
                    k.AltGrupAdi = AltGrupDegisken;
                    k.EditUser = frmAnaMenu.UserId;
                    k.GuncellemeTarihi = DateTime.Now;
                    DB.AltGruplar.Add(k);
                    DB.SaveChanges();
                }
                #endregion
            }
            MessageBox.Show("Verilerin güncellenmesi hatasız bir şekilde tamamlanmıştır.");
        }
        //bu alan
        public void TanimKontrol(string tanim, frmTanim.TanimTuru tanimTuru)
        {
            Tanim t = DB.Tanimlar.FirstOrDefault(x => x.Tanimi == tanim && x.Turu == tanimTuru.ToString());
            if (t == null)
            {
                t = new Tanim
                {
                    Tanimi = tanim,
                    Turu = tanimTuru.ToString()
                };
                DB.Tanimlar.Add(t);
                DB.SaveChanges();
            }
        }
        public void Kategori(string tanim, frmTanim.TanimTuru tanimTuru)
        {
            Tanim t = DB.Tanimlar.FirstOrDefault(x => x.Tanimi == tanim && x.Turu == tanimTuru.ToString());
            if (t == null)
            {
                t = new Tanim
                {
                    Tanimi = tanim,
                    Turu = tanimTuru.ToString()
                };
                DB.Tanimlar.Add(t);
                DB.SaveChanges();
            }
        }
        /// <summary>
        /// Parametre ile gelen combobox'daki veri alanının adı kullanılarak, yine parametre ile gelen indexe sahip
        /// grid satırından combox'daki alan bilgisine sahip alan verisi alınarak string olarak geri döndürülür.
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private string VeriAl(ComboBoxEdit cmb, int i)
        {
            string veri = string.Empty;
            if (cmb.SelectedIndex > 0)
            {
                veri = gridListe.GetRowCellValue(i, cmb.SelectedItem.ToString()).ToString();
            }
            return veri;
        }
        /// <summary>
        /// Excel dosyasından okunmuş olan verileri eklemek amacıyla kullanılan buttonun click eventidir.
        /// Burada öncelikle ekleme işlemi için combobox'alanlarında bir seçim yapılıp yapılmadığı kontrol edilir.
        /// Sonra ise herhangi bir alanın pasif edilip edilmediği kontrol edilir.
        /// Eğer iki durumdan birinde bir eksiklik var ise işlem iptal edilir.
        /// Bunun sebebi ekleyeceğimiz bilgilerin yeni bilgiler olması ve grup,birim gibi bilgilerin 
        /// veri tabanında kayıtlı olmayabileceği, yeni kayıt oluşturulması gerekebileceği yada güncellenmesi gerekebileceğidir.
        /// Bu sebeple ekleme işleminde alanların tümünün veri olarak bulunması gerekmektedir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnVeriEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control item in splitContainerControl1.Panel1.Controls)
            {
                if (item is ComboBoxEdit)
                {
                    if ((item as ComboBoxEdit).SelectedIndex == 0)
                    {
                        //Mesajlar.Hata(new Exception("Lütfen tüm alanların seçimini yapınız."));
                        return;
                    }
                }
                if (item is CheckEdit)
                {
                    if (!(item as CheckEdit).Checked)
                    {
                        //Mesajlar.Hata(new Exception("Toplu stok eklemesinde tüm alanları işaretlemelisiniz....\n Lütfen tüm alanların seçimini yapınız."));
                        return;
                    }
                }
            }
            Task.Run(() =>
            {
                VeriEkle();
            });
        }
        /// <summary>
        /// Güncelleme işlemi için alanların kontrolü yapılır. Öncelikle bir stok kodunun seçilip seçilmediğine bakılır. 
        /// SEçili olan stok koduna göre aktif olan alanlar güncellenir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnVeriGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbStokKodu.SelectedIndex == 0)
            {
                //Mesajlar.Hata(new Exception("Lütfen stok kodu alanı seçimini yapınız."));
                return;
            }
            DialogResult DR = MessageBox.Show("Aktif edilen tüm alanlar güncellenecektir. Aktif alanlardan herhangi birini boş bırakmadığınızdan emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (DR == DialogResult.Yes)
            {
                VeriGuncelle();
            }
        }
        private void barBtnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Seçilen Excel dosyası içerisindeki sayfaların listelendiği combobox'ın seçim işlemi yapılması ise,
        /// ilgili sayfadaki verilerin gride aktarılmasını sağlayan metoddur. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSheets_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbSheets.EditValue.ToString() == "Bir Sayfa Seçin...")
            {
                gcListe.DataSource = null;
                gridListe.Columns.Clear();
            }
            else if (CNN != null && (cmbSheets.EditValue.ToString() != "Bir Sayfa Seçin..."))
            {
                try
                {
                    CNN.Open();
                    OleDbDataAdapter DA = new OleDbDataAdapter($"SELECT * FROM [{cmbSheets.EditValue.ToString()}]", CNN);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    CNN.Close();
                    gcListe.DataSource = DT;
                    foreach (Control item in xtraScrollableControl1.Controls)
                    {
                        if (item is ComboBoxEdit)
                        {
                            BaslikYukle(item as ComboBoxEdit);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (CNN == null)
            {
                //Mesajlar.Hata(new Exception("Bir excel dosyası seçimi yapmadınız."));
            }
        }
    }
}