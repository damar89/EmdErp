﻿using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using NetSatis.Utils.Raporlama;
namespace NetSatis.BackOffice.Stok
{
    public partial class BarkodEtiketHazirla : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
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
                    if (context.BarkodEtiketOlustur.Count(c => c.Barkodu == itemStok.Barkodu) == 0)
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
                            SezonYil = itemStok.SezonYil,

                            MevcutStok = (context.StokHareketleri.Where(c => c.StokId == itemStok.Id && c.Hareket == "Stok Giriş")
                                      .Sum(c => c.Miktar) ?? 0) -
                                 (context.StokHareketleri.Where(c => c.StokId == itemStok.Id && c.Hareket == "Stok Çıkış")
                                      .Sum(c => c.Miktar) ?? 0)



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

            YazdirSecenekleriEkle();
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
                //Barkod entity;
                //entity = context.Barkodlar.Where(c => c.Barkodu == txtBarkod.Text).SingleOrDefault();
                var entityStok = context.Stoklar.Include("Barkod").FirstOrDefault(x => x.Barkodu.Equals(txtBarkod.Text) || x.Barkod.Any(q => q.Barkodu.Equals(txtBarkod.Text)));
                if (entityStok == null)
                {
                    MessageBox.Show("Aradığınız barkoda ait ürün bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!context.BarkodEtiketOlustur.Any(c => c.Barkodu.Equals(entityStok.Barkodu)))
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
                        Barkodu = txtBarkod.Text,
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
                    txtBarkod.Text = "";
                }
                else
                {
                    MessageBox.Show("Bu barkod daha önce oluşturulmuş", "Barkod oluşturulmuş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            gridView1.RefreshData();
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    if (gridView1.RowCount == 0)
        //        return;

        //    var r = new rptBarkodRaf();
        //    var row = gridView1.GetRow(gridView1.FocusedRowHandle) as BarkodEtiket;

        //    r.xrBarCode1.Text = row.Barkodu;
        //    r.ShowPreview();

        //    //Report rpr = new Report();
        //    //rpr.Load($@"{Application.StartupPath}\degisimfisi.frx");
        //    //rpr.SetParameterValue("StokAdi","test1StokAdi");
        //    //NetSatisContext db = new NetSatisContext();
        //    //var list = db.BarkodEtiketOlustur.ToList();

        //    ////rpr.RegisterData();
        //    //rpr.Design();

        //    //List<string> fields = new List<string>();
        //    //using (NetSatisContext db = new NetSatisContext()) {
        //    //    FisDAL f2 = new FisDAL();
        //    //    var liste = f2.Listelemeler(db, "Toptan Satış Faturası");

        //    //    foreach (var obj in (IList)liste) {
        //    //        Type type = obj.GetType();

        //    //        foreach (PropertyInfo prop in type.GetProperties()) {
        //    //            fields.Add(prop.Name);
        //    //        }
        //    //        break;
        //    //    }


        //    //    var list = db.BarkodEtiketOlustur.ToList();
        //    //    r.DataSource = list;
        //    //var fileName = $@"{Application.StartupPath}\rptBarkodRaf.repx";
        //    //if (File.Exists(fileName))
        //    //    r.LoadLayout(fileName);
        //    //else {
        //    //    MessageBox.Show("Barkod raporu dizayn dosyası bulunamadı. Dosya adı: " + new FileInfo(fileName).Name);
        //    //    return;
        //    //}
        //    // r.ShowDesigner();

        //}

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                popupMenu1.ShowPopup(MousePosition);
            }
        }

        void YazdirSecenekleriEkle()
        {
            new UtilsRaporlama().YazdirmaSecenekleriniEkle(popupMenu1, DizaynTipi.BarkodEtiket, Br_ItemClick);
        }

        private void Br_ItemClick(object sender, ItemClickEventArgs e)
        {
            //tüm grid
            var r = ((IEnumerable<BarkodEtiket>)gridControl1.DataSource).ToList();
            if (r == null)
                return;

            new FrmRaporTasarlaXtra(r, DizaynTipi.BarkodEtiket, true, true, Convert.ToInt32(e.Item.Tag));

        }

        private void btnRaporlaTasarla_ItemClick(object sender, EventArgs e)
        {
            var rp = new FrmRaporTasarlaXtra(new List<BarkodEtiket>(), DizaynTipi.BarkodEtiket);
            rp.ShowDialog();
            YazdirSecenekleriEkle();
        }
    }
}
