using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiyat_Değiştir
{
    public partial class frmTopluFiyat : Form
    {
        NetSatisContext context = new NetSatisContext();
        StokDAL stokDal = new StokDAL();
        public frmTopluFiyat()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(() =>
            {
                frmStokSec form = new frmStokSec(true);
                form.ShowDialog();
                UseWaitCursor = true;
                if (form.secildi)
                {
                    foreach (var itemStok in form.secilen)
                    {
                        stokDal.AddOrUpdate(context, itemStok);
                    }
                }
                UseWaitCursor = false;
            });

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            stokDal.Save(context);
            MessageBox.Show("Kayıt işlemi Tamamlandı");



        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }



        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                MessageBox.Show("Seçilen Bir Stok Bulunamadı");
                return;
            }
            frmFiyatDegistir form = new frmFiyatDegistir();
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemDegistir in form.list)
                {
                    if (itemDegistir.Degistir)
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            decimal kolonDeger = 0;
                            decimal degisen = 0;
                            kolonDeger = Convert.ToDecimal(gridView1.GetRowCellValue(i, itemDegistir.Referans));
                            if (itemDegistir.DegisimTuru == "Yüzde")
                            {
                                //degisen = itemDegistir.DegisimYonu == "Arttır"
                                //    ? kolonDeger + kolonDeger / 100 * itemDegistir.Degeri
                                //    : kolonDeger - kolonDeger / 100 * itemDegistir.Degeri;

                                degisen = itemDegistir.DegisimYonu == "Arttır"
                                ? kolonDeger + kolonDeger / 100 * itemDegistir.Degeri
                                : kolonDeger - kolonDeger / 100 * itemDegistir.Degeri;

                            }
                            else
                            {
                                //degisen = itemDegistir.DegisimYonu == "Arttır"
                                //    ? kolonDeger + itemDegistir.Degeri
                                //    : kolonDeger - itemDegistir.Degeri;

                                degisen = itemDegistir.DegisimYonu == "Arttır"
                             ? kolonDeger + itemDegistir.Degeri
                             : kolonDeger - itemDegistir.Degeri;
                            }
                            gridView1.SetRowCellValue(i, itemDegistir.KolonAdi, degisen);

                        }
                    }
                }
            }
        }

        private void frmTopluFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
             DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
