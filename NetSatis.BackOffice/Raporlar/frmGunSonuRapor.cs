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
            public string baslik;
            public decimal tutar;
        }
        public frmGunSonuRapor(DateTime baslangic, DateTime bitis, int userId = 0)
        {
            InitializeComponent();

            decimal iadeToplam = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
            (c.FisTuru == "Iade" || c.FisTuru == "Iade")).Sum(x => x.ToplamTutar).GetDecimal();

            decimal perakendeFisTutari = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
          (c.FisTuru == "perakende" || c.FisTuru == "toptan")).Sum(x => x.ToplamTutar).GetDecimal();

            decimal indirimToplam = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis).Sum(x => x.IskontoTutari1).GetDecimal();

            decimal tahsilatToplam = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
   (c.FisTuru == "tahsilate" || c.FisTuru == "tahsilat")).Sum(x => x.ToplamTutar).GetDecimal();

            decimal odemeToplam = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
           (c.FisTuru == "odeme" || c.FisTuru == "toptan")).Sum(x => x.ToplamTutar).GetDecimal();

            decimal masrafToplam = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis &&
   (c.FisTuru == "masraf" || c.FisTuru == "toptan")).Sum(x => x.ToplamTutar).GetDecimal();


            List<ornek> list = new List<ornek>();

            ornek iade = new ornek();
            iade.baslik = "IADE" ; 
            iade.tutar = iadeToplam;
            list.Add(iade);

             ornek masraf = new ornek();
            masraf.baslik = "IADE" ; 
            masraf.tutar = masrafToplam;
            list.Add(masraf);

         




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

            gridControl1.DataSource = list;
        }
    }
}