using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmVerilenTeklif : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();


        public frmVerilenTeklif()
        {
            InitializeComponent();
        }

        private void frmVerilenTeklif_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            context = new NetSatisContext();
            gridContFisler.DataSource = fisDal.Listelemeler(context, "Verilen Teklif Fişi");

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

        private void gridFisler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }
        void SiparisdenFaturaOlustur()
        {
              string cariKodu = gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[0], "CariKodu").ToString();
            for (int i = 0; i < gridFisler.GetSelectedRows().Length; i++)
            {
                if (cariKodu != gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "CariKodu").ToString())
                {
                    MessageBox.Show("Farklı cari hesaplara ait Teklifler birleştirilemez.");
                    return;
                }

                if (gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FaturaFisKodu") != null &&
                    gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FaturaFisKodu").ToString() != "")
                {
                    MessageBox.Show(gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "FisKodu").ToString() + " fiş kodlu Teklif daha önce faturalandırıldığı için tekrar faturalandıramazsınız.");
                    return;
                }
            }

            var yeniFisKodu = "";
            var fis = new Fis();
            decimal fisKdvToplam = 0;
            decimal fisAraToplam = 0;
            decimal fisToplamTutar = 0;
            for (int i = 0; i < gridFisler.GetSelectedRows().Length; i++)
            {
                var irsaliyeId = Convert.ToInt32(gridFisler.GetRowCellValue(gridFisler.GetSelectedRows()[i], "Id"));
                var tempFis = context.Fisler.Where(x => x.Id == irsaliyeId).FirstOrDefault();
                fis.CariId = tempFis.CariId;
                fis.Aciklama = tempFis.Aciklama;
                fis.Adres = tempFis.Adres;
                fis.CepTelefonu = tempFis.CepTelefonu;
                fis.FaturaUnvani = tempFis.FaturaUnvani;
                fis.Il = tempFis.Il;
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


                //BURASI---------------------------------------------------


                if (i == 0)
                {
                    if (tempFis.FisTuru == "Verilen Teklif Fişi")
                    {
                        fis.FisTuru = "Toptan Satış Faturası";

                    }
                    else if (tempFis.FisTuru == "Alınan Teklif Fişi")
                    {
                        fis.FisTuru = "Alış Faturası";

                    }

                    var firstIndexZero = tempFis.FisKodu.IndexOf('0');
                    var onEk = tempFis.FisKodu.Substring(0, firstIndexZero);

                    var no = Convert.ToInt32(tempFis.FisKodu.Substring(firstIndexZero + 1, tempFis.FisKodu.Length - 1 - firstIndexZero));
                    no++;

                    var kod = context.Kodlar.Where(c => c.Tablo == "fis").First();
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

                var stokHareketleri = context.StokHareketleri.Where(x => x.FisKodu == referansIrsaliyeKodu);

                if (stokHareketleri != null)
                {
                    foreach (var item in stokHareketleri)
                    {
                        if (item.FisTuru == "Alınan Sipariş Fişi")
                        {
                            item.FisTuru = "Toptan Satış Faturası";
                            item.Hareket = "Stok Çıkış";

                        }
                        else if (item.FisTuru == "Verilen Sipariş Fişi")
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

            MessageBox.Show("Seçilen Siparişler başarıyla faturalandırılmıştır.");
            Listele();

        }
        private void btnFaturalandır_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SiparisdenFaturaOlustur();
        }
    }
}
