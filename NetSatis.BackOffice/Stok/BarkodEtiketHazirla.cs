using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System.IO;
using DevExpress.XtraReports.UI;

namespace NetSatis.BackOffice.Stok
{
    public partial class BarkodEtiketHazirla : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        BarkodEtiketDAL barkodEtiket = new BarkodEtiketDAL();
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokEtiket_SavedLayout.xml";
        public BarkodEtiketHazirla()
        {
            InitializeComponent();
            gridView1.OptionsSelection.MultiSelect = true;
            context.BarkodEtiketOlustur.Load();
            gridControl1.DataSource = context.BarkodEtiketOlustur.Local.ToBindingList();


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    if (context.BarkodEtiketOlustur.Count(c => c.StokKodu == itemStok.Barkodu) == 0)
                    {
                        barkodEtiket.AddOrUpdate(context, new BarkodEtiket
                        {
                            StokKodu = itemStok.StokKodu,
                            StokAdi = itemStok.StokAdi,
                            Aciklama = itemStok.Aciklama,
                            AlisFiyati1 = itemStok.AlisFiyati1,
                            AlisFiyati2 = itemStok.AlisFiyati2,
                            AlisFiyati3 = itemStok.AlisFiyati3,
                            AltGrup = itemStok.AltGrup,
                            AnaGrup = itemStok.AnaGrup,
                            Barkodu = itemStok.Barkodu,
                            Birim = itemStok.Birim,
                            Kategori = itemStok.Kategori,
                            Marka = itemStok.Marka,
                            Uretici = itemStok.Uretici,
                            Modeli = itemStok.Modeli,
                            SatisFiyati1 = itemStok.SatisFiyati1,
                            SatisFiyati2 = itemStok.SatisFiyati2,
                            SatisFiyati3 = itemStok.SatisFiyati3,
                            SatisKdv = itemStok.SatisKdv,
                            OzelKodu = itemStok.OzelKodu,
                            Pozisyon = itemStok.Pozisyon,
                            Proje = itemStok.Proje,
                            SezonYil = itemStok.SezonYil



                        });
                        barkodEtiket.Save(context);
                    }
                }
            }
            gridView1.RefreshData();
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            gridView1.OptionsSelection.MultiSelect = true;
            if (MessageBox.Show("Seçili olan ürünleri listeden çıkarmak istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                barkodEtiket.Save(context);
            }
            gridView1.RefreshData();
        }

        private void BarkodEtiketHazirla_Load(object sender, EventArgs e)
        {
            txtBarkod.Focus();
            gridControl1.ForceInitialize();
            if (File.Exists(DosyaYolu)) gridControl1.MainView.RestoreLayoutFromXml(DosyaYolu);
        }

        private void BarkodEtiketHazirla_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.ClearColumnsFilter();
            gridControl1.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            barkodEtiket.Save(context);
            MessageBox.Show("Kayıt işlemi Tamamlandı");
        }

        private void BarkodEtiketHazirla_Shown(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDal indirimDal = new IndirimDal();
            CariDAL cariDal = new CariDAL();
            var Barkod = context.Barkodlar.FirstOrDefault(c => c.StokId == entity.Id);
            stokHareket.StokId = entity.Id;
            return stokHareket;
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Barkod entity;
                 entity = context.Barkodlar.Where(c => c.Barkodu == txtBarkod.Text).SingleOrDefault();
                var entityStok = context.Stoklar.FirstOrDefault(x => x.Barkodu == txtBarkod.Text);
               
                if (context.BarkodEtiketOlustur.Count(c => c.StokKodu == entityStok.Barkodu) == 0)
                {
                    barkodEtiket.AddOrUpdate(context, new BarkodEtiket
                    {
                        StokKodu = entityStok.StokKodu,
                        StokAdi = entityStok.StokAdi,
                        Aciklama = entityStok.Aciklama,
                        AlisFiyati1 = entityStok.AlisFiyati1,
                        AlisFiyati2 = entityStok.AlisFiyati2,
                        AlisFiyati3 = entityStok.AlisFiyati3,

                        AltGrup = entityStok.AltGrup,
                        AnaGrup = entityStok.AnaGrup,
                        Barkodu = entityStok.Barkodu,
                        Birim = entityStok.Birim,
                        Kategori = entityStok.Kategori,
                        Marka = entityStok.Marka,
                        Uretici = entityStok.Uretici,
                        Modeli = entityStok.Modeli,
                        SatisFiyati1 = entityStok.SatisFiyati1,
                        SatisFiyati2 = entityStok.SatisFiyati2,
                        SatisFiyati3 = entityStok.SatisFiyati3,
                        SatisFiyati4 = entityStok.SatisFiyati4,
                        SatisKdv = entityStok.SatisKdv,
                        OzelKodu = entityStok.OzelKodu,
                        Pozisyon = entityStok.Pozisyon,
                        Proje = entityStok.Proje,
                        SezonYil = entityStok.SezonYil



                    });
                    barkodEtiket.Save(context);
                }
            }
            gridView1.RefreshData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptBarkodRaf r=new rptBarkodRaf();
            using (NetSatisContext db = new NetSatisContext())
            {
                var list=db.BarkodEtiketOlustur.ToList();
                r.DataSource=list;
                r.LoadLayout(@"C:\De\rptBarkodRaf.repx");
                r.ShowDesigner();
               // r.ShowDesigner();
            }
        }
    }
}
