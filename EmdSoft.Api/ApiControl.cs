using System;
using System.Linq;
using System.Management;

namespace EmdSoft.Api
{
    public class ApiControl
    {
        public bool LicControl(Guid LicKey)
        {
            using (NetSatis.Entities.Context.NetSatisContext db = new NetSatis.Entities.Context.NetSatisContext())
            {
                var list = db.Api.Where(x => x.Key == LicKey).FirstOrDefault();
                return list.IsActivate; 
            }
        }
        public string OfflineLisans()
        {
            string cpuInfo = string.Empty;
            string temp = string.Empty;
            int sayiDeger = 1000;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == String.Empty)
                {
                    string deger = mo.Properties["ProcessorId"].Value.ToString();
                    for (int i = 0; i < deger.Length; i++)
                    {
                        if (Char.IsDigit(deger[i]))
                        { sayiDeger += deger[i]; }
                    }
                }
            }
            //
            var deger1 =// 1 (Yil + (Saniye * 165) + Ay)

 (Convert.ToInt32(DateTime.Now.Year)
 + Convert.ToInt32(DateTime.Now.Second * 12)
 + Convert.ToInt32(DateTime.Now.Month)).ToString().Substring(1, 3);

            //2 (Gün + (Saniye * 896)+ Saat)

            var deger2 = (DateTime.Now.Day.ToString() + Convert.ToInt32(DateTime.Now.Second * 7)
            + DateTime.Now.Hour.ToString()).Substring(0, 3);

            //3 (Dakika + (Saniye * 648)+Saniye)

            var deger3 = (DateTime.Now.Minute.ToString() + Convert.ToInt32(DateTime.Now.Second * 19)
            + DateTime.Now.Second.ToString()).Substring(0, 3);

            //4  İşlemci Id         

            var deger4 = sayiDeger.ToString().Substring(0, 4);
            return
                 Convert.ToString(deger1 + deger2 + deger3 + deger4);
        }
        public string Lisans(string Veri)
        {//Gelen Veri 111 111 111 1111
            string _deger1 = null
                    , _deger2 = null
                    , _deger3 = null
                    , _deger4 = null
                    , _deger5 = null
                    , _deger6 = null
                    , _deger7 = null
                    , _deger8 = null
                    , _deger9 = null
                    , _deger10 = null
                    , _deger11 = null
                    , _deger12 = null;



            //  (Math.Abs((Seri10 - Seri1 + Seri5 +Seri4 + Seri7) * 19 * (seri8 + seri2))) % 10)

            _deger1 = (Math.Abs(

                 (Convert.ToInt16(Veri.Substring(13, 1))
                - Convert.ToInt16(Veri.Substring(0, 1))
                + Convert.ToInt16(Veri.Substring(6, 1))
                + Convert.ToInt16(Veri.Substring(5, 1))
                + Convert.ToInt16(Veri.Substring(9, 1)))
                * 19
                * (Convert.ToInt16(Veri.Substring(10, 1))
                + Convert.ToInt16(Veri.Substring(1, 1)))) % 10).ToString();



            //  (Math.Abs(( Seri10 + Seri11 – Seri12 + Seri8) - (Seri8 + (Seri5 + Seri3)))* 7) % 10)
            _deger2 = (Math.Abs(

                 (Convert.ToInt16(Veri.Substring(13, 1))
                + Convert.ToInt16(Veri.Substring(14, 1))
                - Convert.ToInt16(Veri.Substring(15, 1))
                + Convert.ToInt16(Veri.Substring(10, 1)))

                - (Convert.ToInt16(Veri.Substring(10, 1))
                + (Convert.ToInt16(Veri.Substring(6, 1))
                + Convert.ToInt16(Veri.Substring(2, 1)))) * 7) % 10).ToString();

            _deger3 = (Math.Abs(
                 (Convert.ToInt16(Veri.Substring(1, 1))
                * Convert.ToInt16(Veri.Substring(5, 1))
                * Convert.ToInt16(Veri.Substring(9, 1)))

                + (Convert.ToInt16(Veri.Substring(2, 1))
                + (Convert.ToInt16(Veri.Substring(6, 1))
                + (Convert.ToInt16(Veri.Substring(10, 1))
                - Convert.ToInt16(Veri.Substring(0, 1))))) * 6) % 10).ToString();

            _deger4 = (Math.Abs(
                            (Convert.ToInt16(Veri.Substring(12, 1))
                           - Convert.ToInt16(Veri.Substring(0, 1))
                           + Convert.ToInt16(Veri.Substring(6, 1))
                           + Convert.ToInt16(Veri.Substring(5, 1))
                           + Convert.ToInt16(Veri.Substring(8, 1)))
                           - 19
                           - (Convert.ToInt16(Veri.Substring(10, 1))
                           + Convert.ToInt16(Veri.Substring(1, 1)))) % 10).ToString();


            //
            _deger5 = (Math.Abs(

                  (Convert.ToInt16(Veri.Substring(10, 1))
                 + Convert.ToInt16(Veri.Substring(14, 1))
                 * Convert.ToInt16(Veri.Substring(5, 1))
                 + Convert.ToInt16(Veri.Substring(0, 1)))

                 - (Convert.ToInt16(Veri.Substring(5, 1))
                 + Convert.ToInt16(Veri.Substring(6, 1))
                 - Convert.ToInt16(Veri.Substring(8, 1))
                 + Convert.ToInt16(Veri.Substring(0, 1))
                 - Convert.ToInt16(Veri.Substring(1, 1))) + 19) % 10).ToString();


            //
            _deger6 = (Math.Abs(

                 (Convert.ToInt16(Veri.Substring(1, 1))
                * Convert.ToInt16(Veri.Substring(4, 1))
                * Convert.ToInt16(Veri.Substring(6, 1))
                * Convert.ToInt16(Veri.Substring(9, 1)))

                + (Convert.ToInt16(Veri.Substring(2, 1))
                + Convert.ToInt16(Veri.Substring(6, 1))
                + Convert.ToInt16(Veri.Substring(10, 1))
                + Convert.ToInt16(Veri.Substring(14, 1))
                + Convert.ToInt16(Veri.Substring(15, 1))) - 19) % 10).ToString();


            //
            _deger7 = (Math.Abs(

               (Convert.ToInt16(Veri.Substring(12, 1))
              + Convert.ToInt16(Veri.Substring(14, 1))
              + Convert.ToInt16(Veri.Substring(15, 1)))
              * Convert.ToInt16(Veri.Substring(13, 1))

              + (Convert.ToInt16(Veri.Substring(8, 1))
              + Convert.ToInt16(Veri.Substring(4, 1))
              + Convert.ToInt16(Veri.Substring(0, 1))
              - Convert.ToInt16(Veri.Substring(2, 1))
              - Convert.ToInt16(Veri.Substring(6, 1))
              - Convert.ToInt16(Veri.Substring(15, 1))) * 6) % 10).ToString();

            //
            _deger8 = (Math.Abs(

                             (Convert.ToInt16(Veri.Substring(13, 1))
                            + Convert.ToInt16(Veri.Substring(14, 1))
                            - Convert.ToInt16(Veri.Substring(15, 1))
                            + Convert.ToInt16(Veri.Substring(10, 1)))

                            + (Convert.ToInt16(Veri.Substring(10, 1))
                            + (Convert.ToInt16(Veri.Substring(6, 1))
                            + Convert.ToInt16(Veri.Substring(2, 1)))) * 19) % 10).ToString();

            //
            _deger9 = (Math.Abs(

              (Convert.ToInt16(Veri.Substring(12, 1))
             + Convert.ToInt16(Veri.Substring(14, 1))
             + Convert.ToInt16(Veri.Substring(15, 1)))

             * Convert.ToInt16(Veri.Substring(13, 1))

             + (Convert.ToInt16(Veri.Substring(8, 1))
             + Convert.ToInt16(Veri.Substring(4, 1))
             + Convert.ToInt16(Veri.Substring(0, 1))
             - Convert.ToInt16(Veri.Substring(2, 1))
             - Convert.ToInt16(Veri.Substring(6, 1))
             - Convert.ToInt16(Veri.Substring(15, 1))) * 6) % 10).ToString();


            //          
            _deger10 = (Math.Abs(

                (Convert.ToInt16(Veri.Substring(13, 1))
               + Convert.ToInt16(Veri.Substring(14, 1))
               - Convert.ToInt16(Veri.Substring(15, 1))
               + Convert.ToInt16(Veri.Substring(10, 1)))

               - (Convert.ToInt16(Veri.Substring(10, 1))
               + (Convert.ToInt16(Veri.Substring(6, 1))
               + Convert.ToInt16(Veri.Substring(2, 1)))) * 7) % 10).ToString();



            //

            _deger11 = (Math.Abs(
               (Convert.ToInt16(Veri.Substring(6, 1))
              * Convert.ToInt16(Veri.Substring(8, 1))
              * Convert.ToInt16(Veri.Substring(9, 1))
              + Convert.ToInt16(Veri.Substring(1, 1)))

              * (Convert.ToInt16(Veri.Substring(9, 1))
              * (Convert.ToInt16(Veri.Substring(4, 1))
              * (Convert.ToInt16(Veri.Substring(8, 1))
              * (Convert.ToInt16(Veri.Substring(4, 1))
              + Convert.ToInt16(Veri.Substring(9, 1)))))) + 4) % 10).ToString();

            //
            _deger12 = (Math.Abs(
               (Convert.ToInt16(Veri.Substring(5, 1))
              * Convert.ToInt16(Veri.Substring(8, 1))
              * Convert.ToInt16(Veri.Substring(6, 1))
              + Convert.ToInt16(Veri.Substring(4, 1)))

              - (Convert.ToInt16(Veri.Substring(10, 1))
              * (Convert.ToInt16(Veri.Substring(8, 1))
              + (Convert.ToInt16(Veri.Substring(2, 1))
              * (Convert.ToInt16(Veri.Substring(1, 1))
              + Convert.ToInt16(Veri.Substring(0, 1)))))) * 19) % 10).ToString();


            //  Anahtar MaskedTexbox umuza değerlerimi atayalım.

            var Cevap = _deger1 + _deger2 + _deger3 + _deger4 + _deger5
                             + _deger6 + _deger7 + _deger8 + _deger9 + _deger10
                             + _deger11 + _deger12;
            return Convert.ToString(Cevap);

        }
    }
}
