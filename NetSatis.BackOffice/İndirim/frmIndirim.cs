using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.İndirim
{
    public partial class frmIndirim : Form
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDal indirimDal = new IndirimDal();

        public frmIndirim()
        {
            InitializeComponent();
            gridIndirim.OptionsSelection.MultiSelect = true;
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmIndirimIslem form = new frmIndirimIslem();
            form.ShowDialog();
        }

        private void Listele()
        {
            
            gridContIndirim.DataSource = indirimDal.IndirimListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridIndirim.OptionsSelection.MultiSelect = true;
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilen = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimDal.Delete(context, c => c.StokKodu == secilen);
                indirimDal.Save(context);
                Listele();
            }
           
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            var secilenStokKodu = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilen = indirimDal.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {

                secilen.Durumu = false;

                btnPasif.Text = "Pasif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu,false);
                btnPasif.ImageIndex = 8;
                indirimDal.Save(context);
                Listele();

            }
            else
            {

                secilen.Durumu = true;
                btnPasif.Text = "Aktif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu,true);
                btnPasif.ImageIndex = 6;
                indirimDal.Save(context);
                Listele();
            }

            
        }

        private void gridIndirim_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
                btnPasif.Text = "Pasif Yap";
                btnPasif.ImageIndex = 8;
            }
            else
            {
                btnPasif.Text = "Aktif Yap";
                btnPasif.ImageIndex = 6;
            }
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void frmIndirim_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void frmIndirim_KeyDown(object sender, KeyEventArgs e)
        {
              if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}

