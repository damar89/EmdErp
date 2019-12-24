using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using NetSatis.EDonusum;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;

namespace NetSatisAdmin
{

    public partial class frmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        private bool kaydedildi = false;


        public frmBaglantiAyarlari()
        {
            InitializeComponent();
        }

        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServer.Text;
            connectionStringBuilder.InitialCatalog = txtDatabase.Text;
            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;

            }
            else
            {
                connectionStringBuilder.UserID = txtKullaniciAdi.Text;
                connectionStringBuilder.Password = txtParola.Text;
                connectionStringBuilder.IntegratedSecurity = false;

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";

            if (ConnectionTool.CheckConnetion(connectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı Başarılı");
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız !");
            }

        }

        private void chkSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSqlServer.Checked)
            {
                txtKullaniciAdi.Enabled = true;
                txtParola.Enabled = true;

            }
            else
            {
                txtKullaniciAdi.Enabled = false;
                txtParola.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";

            if (ConnectionTool.CheckConnetion(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = txtDatabase.Text;
                MessageBox.Show(
                    "Seçtiğiniz Server'da belirtilen Database yoksa bu mesajdan sonra oluşturulacak bu işlem biraz uzun sürebilir");
                NetSatis.Entities.Tools.SettingsTool.AyarDegistir(NetSatis.Entities.Tools.SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                NetSatis.Entities.Tools.SettingsTool.Save();

                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kasalar.Any(c => c.KasaKodu == "001"))
                    {
                        context.Kasalar.Add(new Kasa
                        {
                            KasaAdi = "Kasa1",
                            KasaKodu = "001",

                        });
                        context.SaveChanges();

                    }
                }
                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Depolar.Any(c => c.DepoKodu == "001"))
                    {
                        context.Depolar.Add(new Depo
                        {
                            DepoAdi = "Merkez Depo",
                            DepoKodu = "001",

                        });
                        context.SaveChanges();

                    }
                }

                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                    {
                        context.Kullanicilar.Add(new Kullanici
                        {
                            KullaniciAdi = "Yönetici",
                            Parola = "741852",
                            HatirlatmaSorusu = "Program Firması",
                            Cevap = "EMD",
                            DepoId = 1,
                            KasaId = 1,
                        });
                        context.SaveChanges();

                    }
                }


                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.OdemeTurleri.Any(c => c.OdemeTuruKodu == "001"))
                    {
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "Nakit",
                            OdemeTuruKodu = "001",

                        });
                        context.SaveChanges();

                    }
                }
                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.OdemeTurleri.Any(c => c.OdemeTuruKodu == "002"))
                    {
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "Kredi Kartı",
                            OdemeTuruKodu = "002",

                        });
                        context.SaveChanges();

                    }
                }
                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.OdemeTurleri.Any(c => c.OdemeTuruKodu == "003"))
                    {
                        context.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "Evrak",
                            OdemeTuruKodu = "003"
                        });
                        context.SaveChanges();
                    }
                }

                using (var donusum = new VTContext())
                {
                    donusum.Database.CreateIfNotExists();
                    if (!donusum.HareketTipi.Any(c => c.Kodu == "A"))
                    {
                        donusum.HareketTipi.Add(new NetSatis.EDonusum.Models.Donusum.HareketTipi
                        {
                            Aciklama = "A",
                            Kodu = "A"
                        });
                        donusum.SaveChanges();
                    }
                }
                using (var donusum = new VTContext())
                {
                    donusum.Database.CreateIfNotExists();
                    if (!donusum.HareketTipi.Any(c => c.Kodu == "B"))
                    {
                        donusum.HareketTipi.Add(new NetSatis.EDonusum.Models.Donusum.HareketTipi
                        {
                            Aciklama = "B",
                            Kodu = "B"
                        });
                        donusum.SaveChanges();
                    }
                }
                  using (var donusum = new VTContext())
                {
                    donusum.Database.CreateIfNotExists();
                    if (!donusum.HareketTipi.Any(c => c.Kodu == "-"))
                    {
                        donusum.HareketTipi.Add(new NetSatis.EDonusum.Models.Donusum.HareketTipi
                        {
                            Aciklama = "-",
                            Kodu = "-"
                        });
                        donusum.SaveChanges();
                    }
                }
                using (var context = new NetSatisContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kodlar.Any(c => c.Tablo == "Fis"))
                    {
                        context.Kodlar.Add(new Kod
                        {
                            OnEki = "TSF",
                            SonDeger = 1,
                            Tablo = "Fis"
                        });
                        context.SaveChanges();
                    }
                }
                kaydedildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız !");
            }
        }

        private void frmBaglantiAyarlari_Load(object sender, EventArgs e)
        {

        }

        private void frmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                MessageBox.Show("Uygulamada bağlantı cümlesi olmadığından kapatılacak");
                Application.Exit();
            }
        }
    }
}