using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmAltGruplar : Form
    {
        NetSatisContext context = new NetSatisContext();
        AltGrupDAL altgrupDal = new AltGrupDAL();
        public AltGrup _entity;
        public bool secildi = false;
        string _anagrupkodu ="";

        public frmAltGruplar(string anagrupkodu = "")
        {
            InitializeComponent();
            _anagrupkodu=anagrupkodu;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltGruplar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
                 var fullList = altgrupDal.GetAll(context);
            if (_anagrupkodu != "")
            {
                gridContAltGruplar.DataSource = fullList.Where(x => x.Kod.StartsWith(_anagrupkodu + "."));
            }
            else
            {
                gridContAltGruplar.DataSource = fullList;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        public enum AltGrupTuru
        {

            AltGrup


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridAltGruplar.GetFocusedRowCellValue(colId));
                altgrupDal.Delete(context, c => c.Id == secilen);
                altgrupDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmAltGrup form = new frmAltGrup(new Entities.Tables.AltGrup());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridAltGruplar.GetFocusedRowCellValue(colId));
            frmAltGrup form = new frmAltGrup(altgrupDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void gridAltGruplar_DoubleClick(object sender, EventArgs e)
        {
             try
            {
                if (gridAltGruplar.RowCount != 0)
                {
                    int secilen = Convert.ToInt32(gridAltGruplar.GetFocusedRowCellValue(colId));
                    _entity = context.AltGruplar.Where(c => c.Id == secilen).SingleOrDefault();
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
