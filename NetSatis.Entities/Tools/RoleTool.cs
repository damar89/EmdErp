using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Linq;

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
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi == "fmrAnaMenu" ||c.FormAdi=="frmFrontOffice" && c.Yetki == false).ToList())
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
