using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.BackOffice.Extensions;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmGunSonuRapor : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        class ornek
        {
            public string Baslik;
            public decimal? Tutar;
        }
        public frmGunSonuRapor(DateTime baslangic, DateTime bitis, int userId = 0)
        {
            InitializeComponent();

            var res = (from fis in context.Fisler.Where(s => s.Tarih >= baslangic && s.Tarih <= bitis).GroupBy(x => new { x.FisTuru, x.FisKodu })
                       from kasa in context.KasaHareketleri.Where(x => x.FisKodu == fis.Key.FisKodu).GroupBy(x => new { x.FisTuru, x.OdemeTuru.OdemeTuruAdi }).DefaultIfEmpty()
                       from kasa2 in context.KasaHareketleri.Where(s => s.Tarih >= baslangic && s.Tarih <= bitis).GroupBy(s => s.FisKodu).DefaultIfEmpty()
                       select new
                       {
                           OdemeTuru = string.IsNullOrEmpty(kasa.Key.OdemeTuruAdi) ? "Açık Hesap" : kasa.Key.OdemeTuruAdi,
                           kasaTutar = string.IsNullOrEmpty(kasa.Key.OdemeTuruAdi) ? kasa2.Sum(s => s.Tutar) : kasa.Sum(s => s.Tutar),
                           iadeToplam = fis.Where(x => x.FisTuru == "Satış İade Faturası" || x.FisTuru == "Perakende İade Faturası").Sum(s => s.ToplamTutar),
                           perakendeFisTutari = fis.Where(x => x.FisTuru == "Perakende Satış Faturası").Sum(s => s.ToplamTutar),
                           indirimToplam = fis.Where(x => x.FisTuru == "Perakende Satış Faturası" || x.FisTuru == "Toptan Satış Faturası").Sum(s => s.IskontoTutari1),
                           tahsilatToplam = fis.Where(x => x.FisTuru == "Tahsilat Fişi").Sum(s => s.ToplamTutar),
                           odemeToplam = fis.Where(x => x.FisTuru == "Ödeme Fişi").Sum(s => s.ToplamTutar),
                           masrafToplam = fis.Where(x => x.FisTuru == "Masraf Fişi").Sum(s => s.ToplamTutar),
                       }).ToList();


            List<ornek> list = new List<ornek>();

            ornek iade = new ornek();
            iade.Baslik = "İadeler";
            iade.Tutar = res.Sum(s => s.iadeToplam);
            list.Add(iade);

            ornek masraf = new ornek();
            masraf.Baslik = "Masraflar";
            masraf.Tutar = res.Sum(s => s.masrafToplam);
            list.Add(masraf);

            ornek odeme = new ornek();
            odeme.Baslik = "Ödemeler";
            odeme.Tutar = res.Sum(s => s.odemeToplam);
            list.Add(odeme);

            ornek tahsilat = new ornek();
            tahsilat.Baslik = "Tahsilatlar";
            tahsilat.Tutar = res.Sum(s => s.tahsilatToplam);
            list.Add(tahsilat);

            ornek indirimToplam = new ornek();
            indirimToplam.Baslik = "İndirimler";
            indirimToplam.Tutar = res.Sum(s => s.indirimToplam);
            list.Add(indirimToplam);

            ornek perakende = new ornek();
            perakende.Baslik = "Perakende Satışlar";
            perakende.Tutar = res.Sum(s => s.perakendeFisTutari);
            list.Add(perakende);



            var odemeTuru = new List<ornek>();
            foreach (var item in res.GroupBy(s => s.OdemeTuru))
            {
                if (item == null)
                    continue;
                odemeTuru.Add(new ornek
                {
                    Baslik = item.Key,
                    Tutar = item.Sum(s => s.kasaTutar)
                });
            }

            list.AddRange(odemeTuru);
            //gridControl1.DataSource = list.ToList();
            gridControl1.DataSource = list.Select(x => new { x.Baslik, x.Tutar }).ToList();

            //           var tablo = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
            //           (c.FisTuru == "Toptan Satış Faturası" || c.FisTuru == "Perakende Satış Faturası")).GroupJoin(
            //               context.KasaHareketleri,
            //               kasa => kasa.FisTuru,
            //               fis => fis.FisTuru,
            //                 (fisler, kasalar) => new
            //                 {
            //                     Fis = fisler,
            //                     Kasa = kasalar
            //                 }
            //               ).GroupBy(x =>
            //               context.KasaHareketleri.Where(a => a.FisKodu == x.Fis.FisKodu).FirstOrDefault().OdemeTuruId
            //               ).ToList();
            //           var tablo2 = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
            //(c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası")).GroupJoin(
            //    context.KasaHareketleri,
            //    kasa => kasa.FisTuru,
            //    fis => fis.FisTuru,
            //      (fisler, kasalar) => new
            //      {
            //          Fis = fisler,
            //          Kasa = kasalar
            //      }
            //    ).ToList();



            //           var y = tablo
            //             .Select(k => new
            //             {
            //                 k
            //             })

            //             .ToList();

            //  .GroupJoin(
            //    context.Fisler, c => c.CariId, c => c.CariId,
            //    (fisler, cariler) =>
            //       new
            //       {
            //           fisler.Id,
            //           fisler.FisKodu,
            //           fisler.FisTuru,
            //           fisler.ToplamTutar,
            //           fisler.Cari.CariAdi,

            //           OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
            //             context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
            //                    : "Acik Hesap"
            //           ),

            //           borc =
            //           (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
            //           .Sum(c => c.ToplamTutar) ?? 0) +
            //           (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
            //           .Sum(c => c.Tutar) ?? 0)
            //       }).Select(k => new
            //       {

            //           k.IskontoTutari1,
            //           k.borc,
            //           k.alacak,
            //           bakiye = k.alacak - k.borc
            //       }).ToList();
            //return tablo;

        }
    }
}