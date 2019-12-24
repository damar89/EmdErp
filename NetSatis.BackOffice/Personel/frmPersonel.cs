using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Personel
{
    public partial class frmPersonel : Form
    {
        NetSatisContext context = new NetSatisContext();
        PersonelDal personelDal = new PersonelDal();
        private int _secilen ;

        public frmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContPersonel.DataSource = personelDal.PersonelListele(context);
        }
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFltKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _secilen =Convert.ToInt32(gridPersonel.GetFocusedRowCellValue(colId)) ;
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                personelDal.Delete(context, c => c.Id == _secilen);
                personelDal.Save(context);Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPersonelIslem form = new frmPersonelIslem(new Entities.Tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            _secilen =Convert.ToInt32(gridPersonel.GetFocusedRowCellValue(colId)) ;
            frmPersonelIslem form = new frmPersonelIslem(personelDal.GetByFilter(context, c => c.Id == _secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnPersonelHareket_Click(object sender, EventArgs e)
        {
            _secilen =Convert.ToInt32(gridPersonel.GetFocusedRowCellValue(colId)) ;
            frmPersonelHareket form=new frmPersonelHareket(_secilen);
            form.ShowDialog();}

        private void btnHakedis_Click(object sender, EventArgs e)
        {
            frmFisIslem form=new frmFisIslem(null,"Hakediş Fişi");
            form.ShowDialog();
        }
    }
}
