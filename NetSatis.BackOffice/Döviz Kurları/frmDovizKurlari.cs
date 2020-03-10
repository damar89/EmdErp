using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetSatis.BackOffice.Döviz_Kurları
{
    public partial class frmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son Güncelleme Tarihi : " + info.LastWriteTime.ToString();
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }
        private void Guncelle(bool indir=true)
        {
            if (indir)
            {
                using (WebClient kurIndir = new WebClient())
                {
                    kurIndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();
            }
           

            XElement kurlar = XElement.Load(Application.StartupPath + "\\Kurlar.xml");
            List<DovizKurlari> listKurlar = new List<DovizKurlari>();
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();


            foreach (var itemElement in kurlar.Elements().Where(c => c.Attribute("CurrencyCode").Value != "XDR").ToList())
            {
                listKurlar.Add(new DovizKurlari
                {
                    CurrencyCode = itemElement.Attribute("CurrencyCode").Value,
                    Isim = itemElement.Element("Isim").Value,
                    ForexBuying = Convert.ToDecimal(itemElement.Element("ForexBuying").Value.Replace(".", ondalikKarakter)),
                    ForexSelling = Convert.ToDecimal(itemElement.Element("ForexSelling").Value.Replace(".", ondalikKarakter)),
                    BanknoteBuying = itemElement.Element("BanknoteBuying").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteBuying").Value.Replace(".", ondalikKarakter)),
                    BanknoteSelling = itemElement.Element("BanknoteSelling").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteSelling").Value.Replace(".", ondalikKarakter))
                });
               
                gridControl1.DataSource = listKurlar;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Guncelle();
            MessageBox.Show("Güncelleme işlemi Tamamlanmıştır");

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}