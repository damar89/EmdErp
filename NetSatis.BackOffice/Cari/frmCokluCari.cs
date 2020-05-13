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

namespace NetSatis.BackOffice.Cari
{
    public partial class frmCokluCari : DevExpress.XtraEditors.XtraForm
    {
        //Mesaj_Fonksiyonlari Mesajlar = new Mesaj_Fonksiyonlari();
        NetSatisContext DB = new NetSatisContext();
        OleDbConnection CNN;
        public frmCokluCari()
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
                    Title = "Lütfen Cari Kayıtları Dosyasını Seçininiz..."
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
        private void frmCokluCari_Load(object sender, EventArgs e)
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
                case "chkCariAdi":
                    cmbCariAdi.Enabled = box.Checked;
                    break;
                case "chkCariTuru":
                    cmbCariTuru.Enabled = box.Checked;
                    break;
                case "chkSinif":
                    cmbCariSinif.Enabled = box.Checked;
                    break;
                case "chkYetkili":
                    cmbYetkili.Enabled = box.Checked;
                    break;
                case "chkFaturaUnvan":
                    cmbFaturaUnvan.Enabled = box.Checked;
                    break;
                case "chkCepTelefon":
                    cmbCepTelefon.Enabled = box.Checked;
                    break;
                case "chkTelefon":
                    cmbTelefon.Enabled = box.Checked;
                    break;
                case "chkFax":
                    cmbFax.Enabled = box.Checked;
                    break;
                case "chkMail":
                    cmbMail.Enabled = box.Checked;
                    break;
                case "chkWeb":
                    cmbWeb.Enabled = box.Checked;
                    break;
                case "chkAdres":
                    cmbAdres.Enabled = box.Checked;
                    break;
                case "chkIl":
                    cmbIl.Enabled = box.Checked;
                    break;
                case "chkIlce":
                    cmbIlce.Enabled = box.Checked;
                    break;
                case "chkSemt":
                    cmbSemt.Enabled = box.Checked;
                    break;
                case "chkGrup":
                    cmbCariGrup.Enabled = box.Checked;
                    break;
                case "chkAltGrup":
                    cmbCariAltGrup.Enabled = box.Checked;
                    break;
                case "chkOzelKod1":
                    cmbOzelKod1.Enabled = box.Checked;
                    break;
                case "chkOzelKod2":
                    cmbOzelKod2.Enabled = box.Checked;
                    break;
                case "chkOzelKod3":
                    cmbOzelKod3.Enabled = box.Checked;
                    break;
                case "chkOzelKod4":
                    cmbOzelKod4.Enabled = box.Checked;
                    break;
                case "chkVergiDairesi":
                    cmbVergiDairesi.Enabled = box.Checked;
                    break;
                case "chkVergiNo":
                    cmbVergiNo.Enabled = box.Checked;
                    break;
                case "chkIskontoOran":
                    cmbIskontoOran.Enabled = box.Checked;
                    break;
                case "chkRiskLimiti":
                    cmbRiskLimit.Enabled = box.Checked;
                    break;
                case "chkAciklama":
                    cmbAciklama.Enabled = box.Checked;
                    break;
                case "chkDevirGiris":
                    cmbDevirGiris.Enabled = box.Checked;
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
            string CariKodu, CariAdi, CariTuru, Sinif, Yetkili, FaturaUnvan, CepTelefon, Telefon, Fax, Mail,
        Web, Adres, Il, Ilce, Semt, Grup, AltGrup,
        OzelKod1, OzelKod2, OzelKod3, OzelKod4, VeriDairesi, VergiNo,
        IskontoOran, RiskLimit, Aciklama, DevirBakiye;
            #endregion
            Invoke((MethodInvoker)delegate
            {
                progressKayit.Properties.Maximum = gridListe.RowCount;
            });
            for (int i = 0; i < gridListe.RowCount; i++)
            {
                try
                {
                    #region Alan Bilgilerinin Çekilmesi
                    CariKodu = VeriAl(cmbCariKodu, i);
                    CariAdi = VeriAl(cmbCariAdi, i);
                    CariTuru = VeriAl(cmbCariTuru, i);
                    Sinif = VeriAl(cmbCariSinif, i);
                    Yetkili = VeriAl(cmbYetkili, i);
                    Mail = VeriAl(cmbMail, i);
                    Web = VeriAl(cmbWeb, i);
                    Adres = VeriAl(cmbAdres, i);
                    Il = VeriAl(cmbIl, i);
                    Ilce = VeriAl(cmbIlce, i);
                    Semt = VeriAl(cmbSemt, i);
                    Grup = VeriAl(cmbCariGrup, i);
                    AltGrup = VeriAl(cmbCariAltGrup, i);
                    OzelKod1 = VeriAl(cmbOzelKod1, i);
                    OzelKod2 = VeriAl(cmbOzelKod2, i);
                    FaturaUnvan = VeriAl(cmbFaturaUnvan, i);
                    OzelKod3 = VeriAl(cmbOzelKod3, i);
                    OzelKod4 = VeriAl(cmbOzelKod4, i);
                    VeriDairesi = VeriAl(cmbVergiDairesi, i);
                    VergiNo = VeriAl(cmbVergiNo, i);
                    IskontoOran = VeriAl(cmbIskontoOran, i);
                    RiskLimit = VeriAl(cmbRiskLimit, i);
                    Aciklama = VeriAl(cmbAciklama, i);
                    CepTelefon = VeriAl(cmbCepTelefon, i);
                    Telefon = VeriAl(cmbTelefon, i);
                    Fax = VeriAl(cmbFax, i);
                    DevirBakiye = VeriAl(cmbDevirGiris, i);
                    #endregion
                    DB = new NetSatisContext();
                    #region Tanım Kontrolleri
                    if (chkAdres.Checked) TanimKontrol(AltGrup, frmTanim.TanimTuru.AltGrup);
                    if (chkWeb.Checked) TanimKontrol(Grup, frmTanim.TanimTuru.Grubu);
                    if (chkMail.Checked) TanimKontrol(OzelKod1, frmTanim.TanimTuru.CariOzelKod1);
                    if (chkIl.Checked) TanimKontrol(OzelKod2, frmTanim.TanimTuru.CariOzelKod2);
                    if (chkSemt.Checked) TanimKontrol(OzelKod3, frmTanim.TanimTuru.CariOzelKod3);
                    if (chkOzelKod2.Checked) TanimKontrol(OzelKod4, frmTanim.TanimTuru.CariOzelKod4);
                    #endregion
                    Entities.Tables.Cari cari = DB.Cariler.FirstOrDefault(x => x.CariKodu == CariKodu);

                    #region Eğer Stok Databasede Kayıtlı Değil İse
                    {
                        cari = new Entities.Tables.Cari();
                        cari.Fax = chkFax.Checked ? Aciklama : "";
                        cari.CariGrubu = chkGrup.Checked ? Grup : "";
                        cari.VergiDairesi = chkVergiDairesi.Checked ? VeriDairesi : "";
                        cari.VergiNo = chkVergiNo.Checked ? VergiNo : "";
                        cari.Adres = chkAdres.Checked ? Adres : "";
                        cari.Web = chkWeb.Checked ? Web : "";
                        cari.CariTuru = chkCariTuru.Checked ? CariTuru : "";
                        cari.CariSinif = chkSinif.Checked ? Sinif : "";
                        cari.YetkiliKisi = chkYetkili.Checked ? Yetkili : "";
                        cari.FaturaUnvani = chkFaturaUnvan.Checked ? FaturaUnvan : "";
                        cari.EMail = chkMail.Checked ? Mail : "";
                        cari.Il = chkIl.Checked ? Il : "";
                        cari.Ilce = chkCepTelefon.Checked ? Ilce : "";
                        cari.Telefon = chkTelefon.Checked ? Telefon : "";
                        cari.Semt = chkSemt.Checked ? Semt : "";
                        cari.OzelKod2 = chkOzelKod2.Checked ? OzelKod2 : "";
                        cari.CariAltGrubu = chkAltGrup.Checked ? AltGrup : "";
                        cari.CariGrubu = chkGrup.Checked ? Grup : "";
                        cari.IskontoOrani = chkIskontoOran.Checked ? decimal.Parse(IskontoOran) : 0;
                        cari.RiskLimiti = chkRiskLimiti.Checked ? decimal.Parse(RiskLimit) : 0;
                        cari.Aciklama = chkAciklama.Checked ? Aciklama : "";
                        cari.OzelKod3 = chkOzelKod3.Checked ? OzelKod3 : "";
                        cari.OzelKod1 = chkOzelKod1.Checked ? OzelKod1 : "";
                        cari.CariAdi = chkCariAdi.Checked ? CariAdi : "";
                        cari.CariKodu = CariKodu;
                        cari.Ilce = chkIlce.Checked ? Ilce : "";

                        cari.Durum = true;
                        DB.Cariler.Add(cari);
                        DB.SaveChanges();
                        if (Convert.ToDecimal(DevirBakiye) != 0)
                        {
                            NetSatisContext context = new NetSatisContext();
                            Fis cariDevirFisi = new Fis();
                            var kod = DB.Kodlar.Where(c => c.Tablo == "fis").First();
                            cariDevirFisi.FisKodu = CodeTool.fiskodolustur(kod.OnEki.ToString(), kod.SonDeger.ToString());
                            cariDevirFisi.FisTuru = "Cari Devir Fişi";
                            cariDevirFisi.Tarih = DateTime.Now;
                            cariDevirFisi.VadeTarihi = DateTime.Now;
                            cariDevirFisi.CariId = cari.Id;
                            cariDevirFisi.FaturaUnvani = cari.FaturaUnvani;
                            cariDevirFisi.VergiDairesi = cari.VergiDairesi;
                            cariDevirFisi.VergiNo = cari.VergiNo;
                            DB.Fisler.Add(cariDevirFisi);
                            DB.SaveChanges();
                            CodeTool ct = new CodeTool();
                            ct.KodArttirma("fis");
                            KasaHareket kasaHar = new KasaHareket();
                            kasaHar.FisKodu = cariDevirFisi.FisKodu;
                            kasaHar.FisTuru = "Cari Devir Fişi";
                            kasaHar.Hareket = Convert.ToDecimal(DevirBakiye) > 0 ? "Kasa Çıkış" : "Kasa Giriş";
                            int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().KasaId);
                            kasaHar.KasaId = kasaid;
                            kasaHar.OdemeTuruId = 1;
                            kasaHar.CariId = cariDevirFisi.CariId;
                            kasaHar.Tarih = DateTime.Now;
                            kasaHar.VadeTarihi = DateTime.Now;
                            kasaHar.Tutar = Convert.ToDecimal(DevirBakiye) > 0 ? Convert.ToDecimal(DevirBakiye) : Convert.ToDecimal(DevirBakiye) * -1;
                            DB.KasaHareketleri.Add(kasaHar);
                        }
                        DB.SaveChanges();
                    }
                    #endregion
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
            MessageBox.Show("Verilerin eklenmesi hatasız bir şekilde tamamlanmıştır.");
        }
        /// <summary>
        /// Verilerin güncelleme işleminin yapıldığı metoddur. Ekleme metodu ile benzer şekilde çalışır.
        /// Sadece alanların aktif olup olmadıklarına göre güncelleme işlemi gerçekleştirir.
        /// </summary>
        public void VeriGuncelle()
        {
            #region Değişkenler
            string CariKodu, CariAdi, CariTuru, Sinif, Yetkili, FaturaUnvan, CepTelefon, Telefon, Fax, Mail,
      Web, Adres, Il, Ilce, Semt, Grup, AltGrup,
      OzelKod1, OzelKod2, OzelKod3, OzelKod4, VeriDairesi, VergiNo,
      IskontoOran, RiskLimit, Aciklama,
      DevirBakiye;
            #endregion
            for (int i = 0; i < gridListe.RowCount; i++)
            {
                #region Alan Bilgilerinin Çekilmesi
                CariKodu = VeriAl(cmbCariKodu, i);
                CariAdi = VeriAl(cmbCariAdi, i);
                CariTuru = VeriAl(cmbCariTuru, i);
                Sinif = VeriAl(cmbCariSinif, i);
                Yetkili = VeriAl(cmbYetkili, i);
                Mail = VeriAl(cmbMail, i);
                Web = VeriAl(cmbWeb, i);
                Adres = VeriAl(cmbAdres, i);
                Il = VeriAl(cmbIl, i);
                Ilce = VeriAl(cmbIlce, i);
                Semt = VeriAl(cmbSemt, i);
                Grup = VeriAl(cmbCariGrup, i);
                AltGrup = VeriAl(cmbCariAltGrup, i);
                OzelKod1 = VeriAl(cmbOzelKod1, i);
                OzelKod2 = VeriAl(cmbOzelKod2, i);
                FaturaUnvan = VeriAl(cmbFaturaUnvan, i);
                OzelKod3 = VeriAl(cmbOzelKod3, i);
                OzelKod4 = VeriAl(cmbOzelKod4, i);
                VeriDairesi = VeriAl(cmbVergiDairesi, i);
                VergiNo = VeriAl(cmbVergiNo, i);
                IskontoOran = VeriAl(cmbIskontoOran, i);
                RiskLimit = VeriAl(cmbRiskLimit, i);
                Aciklama = VeriAl(cmbAciklama, i);
                CepTelefon = VeriAl(cmbCepTelefon, i);
                Telefon = VeriAl(cmbTelefon, i);
                Fax = VeriAl(cmbFax, i);
                DevirBakiye = VeriAl(cmbDevirGiris, i);
                #endregion
                #region Güncelleme İşlemi
                Entities.Tables.Cari cari = DB.Cariler.FirstOrDefault(x => x.CariKodu == CariKodu);
                if (cari != null)
                {
                    if (chkFax.Checked) cari.Fax = Aciklama;
                    if (chkOzelKod4.Checked) cari.OzelKod4 = OzelKod4;
                    if (chkVergiDairesi.Checked) cari.VergiDairesi = VeriDairesi;
                    if (chkVergiNo.Checked) cari.VergiNo = VergiNo;
                    if (chkAdres.Checked) cari.Adres = Adres;
                    if (chkWeb.Checked) cari.Web = Web;
                    if (chkCariTuru.Checked) cari.CariTuru = CariTuru;
                    if (chkSinif.Checked) cari.CariSinif = Sinif;
                    if (chkYetkili.Checked) cari.YetkiliKisi = Yetkili;
                    if (chkFaturaUnvan.Checked) cari.FaturaUnvani = FaturaUnvan;
                    if (chkMail.Checked) cari.EMail = Mail;
                    if (chkIl.Checked) cari.Il = Il;
                    if (chkCepTelefon.Checked) cari.CepTelefonu = CepTelefon;
                    if (chkTelefon.Checked) cari.Telefon = Telefon;
                    if (chkSemt.Checked) cari.Semt = Semt;
                    if (chkOzelKod2.Checked) cari.OzelKod2 = OzelKod2;
                    if (chkAltGrup.Checked) cari.CariAltGrubu = AltGrup;
                    if (chkGrup.Checked) cari.CariGrubu = Grup;
                    if (chkIskontoOran.Checked) cari.IskontoOrani = decimal.Parse(IskontoOran);
                    if (chkRiskLimiti.Checked) cari.RiskLimiti = decimal.Parse(RiskLimit);
                    if (chkAciklama.Checked) cari.Aciklama = Aciklama;
                    if (chkOzelKod3.Checked) cari.OzelKod3 = OzelKod3;
                    if (chkOzelKod1.Checked) cari.OzelKod1 = OzelKod1;
                    if (chkCariAdi.Checked) cari.CariAdi = CariAdi;
                    if (chkIlce.Checked) cari.Ilce = Ilce;
                }
                DB.SaveChanges();
                #endregion
                if (Convert.ToDecimal(DevirBakiye) != 0)
                {
                    NetSatisContext context = new NetSatisContext();
                    Fis cariDevirFisi = new Fis();
                    var kod = DB.Kodlar.Where(c => c.Tablo == "fis").First();
                    cariDevirFisi.FisKodu = CodeTool.fiskodolustur(kod.OnEki.ToString(), kod.SonDeger.ToString());
                    cariDevirFisi.FisTuru = "Cari Devir Fişi";
                    cariDevirFisi.Tarih = DateTime.Now;
                    cariDevirFisi.VadeTarihi = DateTime.Now;
                    cariDevirFisi.CariId = cari.Id;
                    cariDevirFisi.FaturaUnvani = cari.FaturaUnvani;
                    cariDevirFisi.VergiDairesi = cari.VergiDairesi;
                    cariDevirFisi.VergiNo = cari.VergiNo;
                    DB.Fisler.Add(cariDevirFisi);
                    DB.SaveChanges();
                    CodeTool ct = new CodeTool();
                    ct.KodArttirma("fis");
                    KasaHareket kasaHar = new KasaHareket();
                    kasaHar.FisKodu = cariDevirFisi.FisKodu;
                    kasaHar.FisTuru = "Cari Devir Fişi";
                    kasaHar.Hareket = Convert.ToDecimal(DevirBakiye) > 0 ? "Kasa Çıkış" : "Kasa Giriş";
                    int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == frmAnaMenu.UserId).FirstOrDefault().KasaId);
                    kasaHar.KasaId = kasaid;
                    kasaHar.OdemeTuruId = 1;
                    kasaHar.CariId = cariDevirFisi.CariId;
                    kasaHar.Tarih = DateTime.Now;
                    kasaHar.VadeTarihi = DateTime.Now;
                    kasaHar.Tutar = Convert.ToDecimal(DevirBakiye) > 0 ? Convert.ToDecimal(DevirBakiye) : Convert.ToDecimal(DevirBakiye) * -1;
                    DB.KasaHareketleri.Add(kasaHar);
                }
                DB.SaveChanges();
            }
            MessageBox.Show("Verilerin güncellenmesi hatasız bir şekilde tamamlanmıştır.");
        }
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
            if (cmbCariKodu.SelectedIndex == 0)
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