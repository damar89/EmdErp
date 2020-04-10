using DevExpress.XtraBars;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Utils.Raporlama;

namespace NetSatis.Utils
{
    public class UtilsRaporlama
    {
        RaporlamaDAL raporDal = new RaporlamaDAL();
        NetSatisContext context = new NetSatisContext();
        public UtilsRaporlama()
        {

        }
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

    }
}
