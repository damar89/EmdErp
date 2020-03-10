using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;

namespace NetSatis.Entities.Tools
{
    public static class ConverterTool
    {
        private static object frmAnaMenu;

        private static StokHareket StokToStokHareket(NetSatisContext context, Entities.Tables.Stok entity, decimal miktar)
        {
            
            StokHareket stokHareket = new StokHareket();
            IndirimDal indirimDal = new IndirimDal();
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
          

            //stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;

            stokHareket.Miktar = miktar;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;


            return stokHareket;
        }

        public static decimal stringToDecimal(string ifade, string OndalikAyrac)
        {
            string OndalikKarekter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
                .CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(OndalikAyrac, OndalikKarekter));
        }
    }
}
