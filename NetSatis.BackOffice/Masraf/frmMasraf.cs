using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using System;
using System.Windows.Forms;


namespace NetSatis.BackOffice.Masraf
{
    public partial class frmMasraf : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        MasrafDAL masrafDAL = new MasrafDAL();
        private int secilen;


        public frmMasraf()
        {
            InitializeComponent();
            RoleTool.RolleriYukle(this);
        }

        private void frmMasraf_Load(object sender, EventArgs e)
        {
            MasrafListele();
        }
        private void MasrafListele()
        {
            gridControl1.DataSource = masrafDAL.StokListele(context);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                masrafDAL.Delete(context, c => c.Id == secilen);
                masrafDAL.Save(context);
                MasrafListele();

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                frmMasrafIslem form = new frmMasrafIslem(masrafDAL.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
                if (form.saved)
                {
                    MasrafListele();
                }
            }
            else
            {
                MessageBox.Show("Seçili Masraf Kartı Bulunamadı");
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
       {
            if (gridView1.RowCount != 0)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Entities.Tables.Masraf masrafEntity = new Entities.Tables.Masraf();
                masrafEntity = masrafDAL.GetByFilter(context, c => c.Id == secilen);
                frmMasrafIslem form = new frmMasrafIslem(masrafEntity, true);
                form.ShowDialog();
                if (form.saved)
                {
                    MasrafListele();
                }
            }
            else
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMasrafIslem form = new frmMasrafIslem(new Entities.Tables.Masraf());
            form.ShowDialog();
            if (form.saved)
            {
                MasrafListele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MasrafListele();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasrafIslem form = new frmMasrafIslem(masrafDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                MasrafListele();
            }
        }
    }
}