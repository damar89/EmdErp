using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmPesSatisIrsaliyesi : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();


        public frmPesSatisIrsaliyesi()
        {
            InitializeComponent();
            gridFisler.OptionsSelection.MultiSelect = true;
        }

        private void frmPesSatisIrsaliyesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            context = new NetSatisContext();
            gridContFisler.DataSource = fisDal.Listelemeler(context, "Perakende Satış İrsaliyesi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                    fisDal.Delete(context, c => c.FisKodu == secilen);
                    kasaHareketDal.Delete(context, c => c.FisKodu == secilen);
                    stokHareketDal.Delete(context, c => c.FisKodu == secilen);
                    fisDal.Save(context);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }



        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption);
            form.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
                frmFisIslem form = new frmFisIslem(secilen, fisturu);
                form.Show();
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }

        private void gridFisler_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
            frmFisIslem form = new frmFisIslem(secilen, fisturu);
            form.Show();
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
        private void FaturaOlustur(Entities.Tables.Fis fis, List<Entities.Tables.StokHareket> hareketler)   //BURADAN AŞAĞISI
        {
            string HarTipi = "SF";
            string cmbTipi = "A";


            NetSatis.EDonusum.Models.Donusum.Master m = null;
            m = new EDonusum.Models.Donusum.Master
            {
                Aciklama = fis.Aciklama,
                AlisVerisNo = fis.Id,
                DokumanKodu = "",
                EditDate = DateTime.Now,
                EditUser = frmAnaMenu.UserId,
                FisKodu = fis.FisKodu,
                FisTuru = fis.FisTuru,
                HareketTipi = 1,
                HarTip = HarTipi,
                IslemTarihi = fis.Tarih.Value,
                Kdv = fis.KdvToplam_.Value,
                MusteriKodu = fis.CariId.Value,
                Matrah = (fis.ToplamTutar - fis.KdvToplam_).Value,
                NetTutar = fis.ToplamTutar.Value,
                SaveDate = DateTime.Now,
                SaveUser = frmAnaMenu.UserId,
                SeriKodu = fis.Seri,
                SiraKodu = fis.Sira,
                Tutar = fis.AraToplam_.Value,
                VadeTarihi = fis.VadeTarihi.Value,
                DipIskonto = fis.DipIskNetTutari.Value,
            };
            DetailsDuzenle(eislem.MasterOlustur(m), HarTipi, fis, hareketler);


        }
        private void gridFisler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }
        void irsaliyedenFaturaOlustur()
        {

            if (gridFisler.RowCount == 0)
            {
                MessageBox.Show("Fiş kalemleri bulunamadı!, Lütfen tekrar Sipariş fişi oluşturunuz!", "Hatalı Fiş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cariKodu = gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[0], "CariKodu").ToString();
            for (int i = 0; i < gridFisler.GetSelectedRows().Length; i++)
            {
                if (cariKodu != gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "CariKodu").ToString())
                {
                    MessageBox.Show("Farklı cari hesaplara ait Siparişler birleştirilemez.");
                    return;
                }

                if (gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FaturaFisKodu") != null &&
                    gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FaturaFisKodu").ToString() != "")
                {
                    MessageBox.Show(gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FisKodu").ToString() + " fiş kodlu Sipariş daha önce faturalandırıldığı için tekrar faturalandıramazsınız.");
                    return;
                }
            }

            var yeniFisKodu = "";
            var fis = new Fis();
            decimal fisKdvToplam = 0;
            decimal fisAraToplam = 0;
            decimal fisToplamTutar = 0;
            IQueryable<Entities.Tables.StokHareket> hareketler = null;
            for (int i = 0; i < gridFisler.GetSelectedRows().Length; i++)
            {
                var irsaliyeId = Convert.ToInt32(gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "Id"));
                var tempFis = context.Fisler.Where(x => x.Id == irsaliyeId).FirstOrDefault();
                fis.CariId = tempFis.CariId;
                fis.CariAdi = tempFis.CariAdi;
                fis.FaturaUnvani = tempFis.FaturaUnvani;
                fis.Aciklama = tempFis.Aciklama;
                fis.Adres = tempFis.Adres;
                fis.CepTelefonu = tempFis.CepTelefonu;
                fis.FaturaUnvani = tempFis.FaturaUnvani;
                fis.Il = tempFis.Il;
                fis.Proje = tempFis.Proje;
                fis.OzelKod = tempFis.OzelKod;
                fis.Ilce = tempFis.Ilce;
                fis.KDVDahil = tempFis.KDVDahil;
                fis.PlasiyerId = tempFis.PlasiyerId;
                fis.Semt = tempFis.Semt;
                fis.VergiDairesi = tempFis.VergiDairesi;
                fis.VadeTarihi = DateTime.Now;
                fis.VergiNo = tempFis.VergiNo;
                fis.Tarih = DateTime.Now;
                fis.IskontoOrani1 = 0;
                fis.IskontoTutari1 = 0;
                fis.DipIskNetTutari = 0;
                fis.DipIskOran = 0;
                fis.DipIskTutari = 0;
                int referansIrsaliyeId = tempFis.Id;
                string referansIrsaliyeKodu = tempFis.FisKodu;
                fisKdvToplam += Convert.ToDecimal(tempFis.KdvToplam_);
                fisAraToplam += Convert.ToDecimal(tempFis.AraToplam_);
                fisToplamTutar += Convert.ToDecimal(tempFis.ToplamTutar);



                var hareketVarmi = context.StokHareketleri.Any(x => x.FisKodu == tempFis.FisKodu);
                if (!hareketVarmi)
                {
                    MessageBox.Show("Seçili siparişe ait stok bulunamamıştır, Lütfen sipariş fişini tekrar oluşturunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //BURASI---------------------------------------------------


                if (i == 0)
                {
                    if (tempFis.FisTuru == "Perakende Satış İrsaliyesi")
                    {
                        fis.FisTuru = "Pos Fatura";
                        fis.Tipi = "A";

                    }
                    else if (tempFis.FisTuru == "Perakende İade İrsaliyesi")
                    {
                        fis.FisTuru = "Alış Faturası";
                        fis.Tipi = "A";

                    }

                    //var firstIndexZero = tempFis.FisKodu.IndexOf('0');
                    var kod = context.Kodlar.Where(c => c.Tablo == "fis").First();
                    var onEk = kod.OnEki;

                    //var no = Convert.ToInt32(tempFis.FisKodu.Substring(firstIndexZero + 1, tempFis.FisKodu.Length - 1 - firstIndexZero));
                    kod.SonDeger++;

                    yeniFisKodu = CodeTool.fiskodolustur(onEk, kod.SonDeger.ToString());
                    fis.FisKodu = yeniFisKodu;

                    CodeTool ct = new CodeTool();
                    ct.KodArttirma("fis");

                }


                //buraya kadar --------------------------------------



                var tempirsaliye = context.Fisler.Where(x => x.Id == irsaliyeId).FirstOrDefault();
                tempirsaliye.FaturaFisKodu = yeniFisKodu;
                tempirsaliye.CariIrsaliye = "1";
                tempirsaliye.StokIrsaliye = "1";

                var tempirsaliyestokhar = context.StokHareketleri.Where(x => x.FisKodu == referansIrsaliyeKodu);
                foreach (var item in tempirsaliyestokhar)
                {
                    item.StokIrsaliye = "1";
                }
                context.SaveChanges();

                hareketler = context.StokHareketleri.Where(x => x.FisKodu == referansIrsaliyeKodu);

                if (hareketler != null)
                {
                    foreach (var item in hareketler)
                    {
                        if (item.FisTuru == "Perakende Satış İrsaliyesi")
                        {
                            item.FisTuru = "Pos Fatura";
                            item.Hareket = "Stok Çıkış";


                        }
                        else if (item.FisTuru == "Perakende İade İrsaliyesi")
                        {
                            item.FisTuru = "Alış Faturası";
                            item.Hareket = "Stok Giriş";

                        }
                        item.FisKodu = yeniFisKodu;
                        context.StokHareketleri.Add(item);


                    }
                }


            }
            fis.KdvToplam_ = fisKdvToplam;
            fis.AraToplam_ = fisAraToplam;
            fis.ToplamTutar = fisToplamTutar;
            fis.StokIrsaliye = "1";
            fis.CariIrsaliye = "1";
            context.Fisler.Add(fis);
            context.SaveChanges();

            FaturaOlustur(fis, hareketler.ToList());


            MessageBox.Show("Seçilen Siparişler başarıyla faturalandırılmıştır.");
            Listele();
        }
        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
        private void DetailsDuzenle(int id, string HarTipi, Fis fis, List<Entities.Tables.StokHareket> hareketler)
        {
            EDonusum.VTContext c = new EDonusum.VTContext();

            var detailsList = c.Detail.Where(x => x.MasterId == id).ToList();

            for (int i = 0; i < detailsList.Count; i++)
            {
                bool found = false;
                foreach (var item in hareketler)
                {

                    if (item.StokId == detailsList[i].StokId)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    eislem.DetailsSil(detailsList[i].Id);
                }
            }

            //EFATURA YENİ DÜZENLEME
            foreach (var stok in hareketler)
            {
                decimal fyt = stok.KdvToplam.Value;
                decimal fyt2 = stok.ToplamTutar.Value;
                NetSatis.EDonusum.Models.Donusum.Details d = null;

                d = new EDonusum.Models.Donusum.Details
                {
                    HareketTipi = 1,
                    //Magaza="",
                    HarTip = HarTipi,
                    Isk1 = stok.IndirimOrani.Value,
                    Isk2 = stok.IndirimOrani2.Value,
                    Isk3 = stok.IndirimOrani3.Value,
                    IskontoTutar = fis.DipIskNetTutari.Value,
                    Kdv = stok.KdvToplam.Value,
                    KdvOrani = stok.Kdv,
                    KdvDahilFiyat = stok.ToplamTutar.Value,
                    MasterId = id,
                    Matrah = fyt2 - fyt,
                    Miktar = stok.Miktar.Value,
                    MusteriKodu = fis.CariId.Value,
                    TempId = Guid.NewGuid(),
                    StokId = stok.StokId,
                    Tutar = stok.BirimFiyati.Value
                };

                eislem.DetailsOlustur(d);
            }


        }

        private void btnFaturayaAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            irsaliyedenFaturaOlustur();
        }

        private void btnIrsaliye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fisKodu = gridFisler.GetFocusedRowCellValue("FisKodu") as string;
            if (fisKodu == null)
                return;
            var fisKayit = fisDal.GetAll(context, x => x.FisKodu == fisKodu).FirstOrDefault();
            fisKayit.FisTuru = "Perakende Satış İrsaliyesi";
            fisDal.Save(context);
            gridFisler.SetFocusedRowCellValue("FisTuru", fisKayit.FisTuru);
        }
    }
}
