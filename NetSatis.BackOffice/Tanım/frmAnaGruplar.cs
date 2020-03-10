using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmAnaGruplar : Form
    {
        NetSatisContext context = new NetSatisContext();
        AnaGrupDAL anagrupDal = new AnaGrupDAL();

        private string _kategorikodu;
        public AnaGrup _entity;
        public bool secildi = false;
        public frmAnaGruplar(string kategorikodu = "")
        {
            InitializeComponent();
            _kategorikodu = kategorikodu;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnaGruplar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            var fullList = anagrupDal.GetAll(context);
            if (_kategorikodu != "")
            {
                gridContAnaGruplar.DataSource = fullList.Where(x => x.Kod.StartsWith(_kategorikodu + "."));
            }
            else
            {
                gridContAnaGruplar.DataSource = fullList;

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        public enum AnaGrupTuru
        {

            AnaGrup


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridAnaGruplar.GetFocusedRowCellValue(colId));
                anagrupDal.Delete(context, c => c.Id == secilen);
                anagrupDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmAnaGrup form = new frmAnaGrup(new Entities.Tables.AnaGrup());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridAnaGruplar.GetFocusedRowCellValue(colId));
            frmAnaGrup form = new frmAnaGrup(anagrupDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void gridAnaGruplar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridAnaGruplar.RowCount != 0)
                {
                    int secilen = Convert.ToInt32(gridAnaGruplar.GetFocusedRowCellValue(colId));
                    _entity = context.AnaGruplar.Where(c => c.Id == secilen).SingleOrDefault();
                    secildi = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
