using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using System;
using System.Linq;
using System.Reflection;

namespace NetSatis.Entities.Tools
{
    public class CodeTool
    {
        BarManager manager = new BarManager();
        private PopupMenu menu;
        private XtraForm _form;
        private NetSatisContext _context = new NetSatisContext();
        private Table _table;

        public enum Table
        {
            Cari,
            Stok,
            Fis,
            Pos,
            Masraf
        }
        public CodeTool()
        {
        }
        public CodeTool(XtraForm form, Table table)
        {
            _form = form;
            _table = table;
            manager.Form = _form;
            menu = new PopupMenu(manager);
        }

        public void BarButonOlustur()
        {

            foreach (var kod in _context.Kodlar.Where(c => c.Tablo == _table.ToString()).ToList())
            {
                BarButtonItem item = new BarButtonItem
                {
                    Name = "btnKod" + kod.SonDeger,
                    Tag = kod.Id,
                    Caption = KodOlustur(kod.OnEki, kod.SonDeger),
                    ImageOptions = { Image = NetSatis.Entities.Properties.Resources.Code }
                };
                item.ItemClick += Buton_Click;
                menu.AddItem(item);
            }
            BarButtonItem YeniKodEkle = new BarButtonItem
            {
                Name = "btnYeniKodEkle",
                Caption = "Yeni Kod Oluştur",
                ImageOptions = { Image = NetSatis.Entities.Properties.Resources.CodeAdd }
            };
            YeniKodEkle.ItemClick += YeniKodEkle_Click;
            menu.AddItem(YeniKodEkle).BeginGroup = true;

            BarButtonItem guncelle = new BarButtonItem
            {
                Name = "btnGuncelle",
                Caption = "Güncelle",
                ImageOptions = { Image = Properties.Resources.CodeReflesh }
            };
            guncelle.ItemClick += Guncelle_Click;
            menu.AddItem(guncelle);

            DropDownButton buton = (DropDownButton)_form.Controls.Find("btnKod", true).SingleOrDefault();
            buton.MenuManager = manager;
            buton.DropDownControl = menu;

        }

        private void Guncelle_Click(object sender, ItemClickEventArgs e)
        {
            BarButonSil();
            BarButonOlustur();
        }

        private void BarButonSil()
        {
            menu.ItemLinks.Clear();
        }

        private void YeniKodEkle_Click(object sender, ItemClickEventArgs e)
        {
            Type tip = Assembly.Load("NetSatis.BackOffice").GetTypes().SingleOrDefault(c => c.Name == "frmKodlar");
            XtraForm form = (XtraForm)Activator.CreateInstance(tip, _table.ToString());
            form.ShowDialog();
            BarButonSil();
            BarButonOlustur();
        }

        public void Buton_Click(object sender, ItemClickEventArgs e)
        {

            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            text.Text = e.Item.Caption;
        }

        private string KodOlustur(string kodOnEki, int kodSonDeger)
        {
            int sifirSayisi = 12 - (kodOnEki.Length + kodSonDeger.ToString().Length);
            string sifirDizisi = new string('0', sifirSayisi);
            return kodOnEki + sifirDizisi + kodSonDeger;
        }

        public void KodArttirma()
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            BarItemLink buton = menu.ItemLinks.SingleOrDefault(c => c.Caption == text.Text);
            if (buton != null)
            {
                int id = Convert.ToInt32(buton.Item.Tag.ToString());
                _context.Kodlar.SingleOrDefault(c => c.Id == id).SonDeger++;
                _context.SaveChanges();
            }
        }
        public void KodArttirma(string fis)
        {
            _context = new NetSatisContext();
            var x = _context.Kodlar.SingleOrDefault(c => c.Tablo == fis);
            x.SonDeger++;
            _context.SaveChanges();
        }

        public static string fiskodolustur(string OnEki, string Kod)
        {
            int OnEkiUzunluk = OnEki.Length;
            int KodUzunluk = Kod.Length;
            int KalanKArakter = 12 - (OnEkiUzunluk + KodUzunluk);
            string SifirDizisi = null;
            for (int i = 0; i < KalanKArakter; i++)
            {
                SifirDizisi += "0";

            }

            return OnEki + SifirDizisi + Kod;
        }

        static Context.NetSatisContext context = new NetSatisContext();
        public static string Barkodulustur(string OnEki = "2222", string Kod = "90", string donguBarkodu = null)
        {
            int OnEkiUzunluk = OnEki.Length;
            int KodUzunluk = Kod.Length;
            int KalanKArakter = 13 - (OnEkiUzunluk + KodUzunluk);
            string SifirDizisi = null;

            var result = string.Empty;
            if (string.IsNullOrEmpty(donguBarkodu))
            {
                for (int i = 0; i < KalanKArakter; i++)
                {
                    SifirDizisi += "0";
                }
                result = OnEki + SifirDizisi + Kod;
            }
            else
            {
                var deger = Convert.ToDecimal(donguBarkodu);
                deger++;
                result = deger.ToString();
            }

            var r = context.Barkodlar.Any(x => x.Barkodu.Equals(result)) || context.Stoklar.Any(x => x.Barkodu.Equals(result));
            if (r)
                return Barkodulustur(donguBarkodu: result);

            return result;
        }

        //public static string ToptanFisKodOlustur(string OnEki, string Kod)
        //{
        //    int OnEkiUzunluk = OnEki.Length;
        //    int KodUzunluk = Kod.Length;
        //    int KalanKArakter = 12 - (OnEkiUzunluk + KodUzunluk);
        //    string SifirDizisi = null;
        //    for (int i = 0; i < KalanKArakter; i++)
        //    {
        //        SifirDizisi += "0";

        //    }

        //    return OnEki + SifirDizisi + Kod;
        //}
    }
}
