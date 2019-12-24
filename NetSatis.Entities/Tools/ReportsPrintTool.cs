using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;

namespace NetSatis.Entities.Tools
{
    public class ReportsPrintTool
    {
        public enum Belge
        {
            BilgiFisi,
            Fatura,
            Tahsilat,
            Irsaliye,
            Siparis,
            Teklif,
            ProformaFatura,
            Diger
        }
        public void RaporYazdir(XtraReport rapor, Belge belge)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            string yaziciAdi = null;

            int ayar = 0;
            switch (belge)
            {
                case Belge.Tahsilat:
                    rapor.RequestParameters = false;
             
                    raporYazdir.AutoShowParametersPanel = false;
                    break;
                case Belge.Siparis:
                    rapor.RequestParameters = false;
                  
                    raporYazdir.AutoShowParametersPanel = false;
                    break;
                case Belge.ProformaFatura:
                    rapor.RequestParameters = false;
               
                    raporYazdir.AutoShowParametersPanel = false;
                    break;

                case Belge.Teklif:
                    rapor.RequestParameters = false;
       
                    raporYazdir.AutoShowParametersPanel = false;
                    break;
                case Belge.Fatura:
                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                    break;
                case Belge.BilgiFisi:
                    rapor.RequestParameters = false;
                    //rapor.Parameters["FirmaAdi"].Value =
                    //     SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);
                    raporYazdir.AutoShowParametersPanel = false;

                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazidirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                    break;

            }

            switch (ayar)
            {
                case 0:
                    raporYazdir.Print(yaziciAdi);
                    break;
                case 1:
                    raporYazdir.PrintDialog();
                    break;
                case 2:
                    raporYazdir.ShowPreviewDialog();
                    break;
            }

        }
    }
}
