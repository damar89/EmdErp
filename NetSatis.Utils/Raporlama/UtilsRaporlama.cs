using System.Collections.Generic;
using System.IO;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Utils.Raporlama;

namespace NetSatis.Utils.Raporlama
{
    public class UtilsRaporlama
    {
        RaporlamaDAL raporDal = new RaporlamaDAL();
        NetSatisContext context = new NetSatisContext();

        public void YazdirmaSecenekleriniEkle(BarSubItem btnYazdir, DizaynTipi dizaynTipi, ItemClickEventHandler action)
        {

            var resYSecenekleri = raporDal.GetAll(context, x => x.DizaynTipi == dizaynTipi.ToString());
            //var resYSecenekleri = repo.Rapor.Getir(x => x.DizaynTipi == dizaynTipi.ToString());
            btnYazdir.ClearLinks();

            foreach (var item in resYSecenekleri) {

                var br = CreateItem(item);
                btnYazdir.AddItem(br);
                br.ItemClick += action;
            }
        }
        public void YazdirmaSecenekleriniEkle(PopupMenu popupMenu, DizaynTipi dizaynTipi, ItemClickEventHandler action)
        {

            var resYSecenekleri = raporDal.GetAll(context, x => x.DizaynTipi == dizaynTipi.ToString());
            popupMenu.ClearLinks();

            foreach (var item in resYSecenekleri) {
                var br = CreateItem(item);
                popupMenu.AddItem(br);
                br.ItemClick += action;
            }
        }

        BarLargeButtonItem CreateItem(RaporTasarimlari item)
        {
            var br = new BarLargeButtonItem();
            br.Caption = item.DizaynIsmi;
            br.Tag = item.Id;

            br.ImageOptions.Image = Resource1.Yazdir;
            br.ImageOptions.LargeImage = Resource1.YazdirLarge;
            return br;
        }

        public void OnIzle(int ReportID, object data)
        {
            var rapor = RaporTasarimGetir(DesignID: ReportID);
            rapor.DataSource = data;
            var rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreview();
        }
        public void Yazdir(int ReportID, object data)
        {
            var rapor = RaporTasarimGetir(DesignID: ReportID);
            rapor.DataSource = data;
            var rpt = new ReportPrintTool(rapor);
            rpt.Print();
        }

        public List<XtraReport> RaporTasarimlariniGetir(DizaynTipi dizaynTipi)
        {
            var lst = new List<XtraReport>();
            var all = raporDal.GetAll(context, x => x.DizaynTipi == dizaynTipi.ToString());
            foreach (var item in all) {
                lst.Add(RaporTasarimGetir(item));
            }
            return lst;
        }

        public XtraReport RaporTasarimGetir(RaporTasarimlari rpt = null, int DesignID = 0)
        {
            var rapor = new XtraReport();

            if (rpt == null) {
                rpt = raporDal.GetByFilter(context, x => x.Id == DesignID);
            }

            rapor = XtraReport.FromStream(new MemoryStream(rpt.Dizayn));

            return rapor;

        }

    }
}
