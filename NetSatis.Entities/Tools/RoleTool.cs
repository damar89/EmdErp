using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using DevExpress.XtraBars.Ribbon;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Tools
{
    public static class RoleTool
    {
        public static Kullanici KullaniciEntity;

        public static void RolleriYukle(XtraForm form)
        {
            NetSatisContext context = new NetSatisContext();
            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi == form.Name && c.Yetki == false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();
                if (bulunan != null)
                {
                    bulunan.Enabled = false;

                }
            }
        }
        public static void RolleriYukle(RibbonControl form)
        {
            try
            {
                NetSatisContext context = new NetSatisContext();
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi == "fmrAnaMenu" && c.Yetki == false).ToList())
                {
                    form.Items.SingleOrDefault(c => c.Name == item.KontrolAdi).Enabled = false;

                }
            }
            catch (Exception)
            {

                
            }
        }
    }


}
