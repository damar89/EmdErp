using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Hızlı_Satış
{
    public partial class frmHizliSatis : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        HizliSatisGrupDAL hizliSatisGrupDal = new HizliSatisGrupDAL();
        HizliSatisDAL hizliSatisDal = new HizliSatisDAL();

        public frmHizliSatis()
        {InitializeComponent();
            context.HizliSatisGruplari.Load();
            gridUrunEkle.OptionsSelection.MultiSelect = true;
            context.HizliSatislar.Load();
            gridContGrupEkle.DataSource = context.HizliSatisGruplari.Local.ToBindingList();
            gridContUrunEkle.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHizliSatis_Load(object sender, EventArgs e)
        {

        }

        private void KayitAc()
        {
            grupBilgi.Enabled = true;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            gridContUrunEkle.Enabled = false;
            btnUrunEkle.Enabled = false;
            btnUrunSil.Enabled = false;

        }
        private void KayitKapat()
        {
            grupBilgi.Enabled = false;
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            gridContUrunEkle.Enabled = true;
            btnUrunEkle.Enabled = true;
            btnUrunSil.Enabled = true;

        }

        private void gridGrupEkle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridUrunEkle.ActiveFilterString = $"GrupId='{gridGrupEkle.GetFocusedRowCellValue(colId)}'";

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hizliSatisGrupDal.AddOrUpdate(context, new HizliSatisGrup
            {
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
            });
            hizliSatisGrupDal.Save(context);
            txtGrupAdi.Text = null;
            txtAciklama.Text = null;

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtGrupAdi.Text = null;
            txtAciklama.Text = null;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan Grup ile birlikte bu gruba eklenmiş tüm hızlı satış ürünleri silinecektir.", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int grupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId);
                hizliSatisDal.Delete(context, c => c.GrupId == grupId);
                gridGrupEkle.DeleteSelectedRows();
                hizliSatisDal.Save(context);
            }


        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    if (context.HizliSatislar.Count(c => c.StokKodu == itemStok.Barkodu) == 0)
                    {
                        hizliSatisDal.AddOrUpdate(context, new HizliSatis
                        {
                            Resim = itemStok.Resim,
                            StokKodu = itemStok.StokKodu,
                            UrunAdi = itemStok.StokAdi,
                            Fiyati=Convert.ToDecimal(itemStok.SatisFiyati1),
                            GrupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId)
                        });
                        hizliSatisDal.Save(context);
                    }
                }
            }
            gridUrunEkle.RefreshData();}

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            gridUrunEkle.OptionsSelection.MultiSelect = true;
            if (MessageBox.Show("Seçili olan ürünleri listeden çıkarmak istediğinize emin misiniz ? ","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
               gridUrunEkle.DeleteSelectedRows();
            hizliSatisDal.Save(context); 
            }
            gridUrunEkle.RefreshData();
        }

        private void frmHizliSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}