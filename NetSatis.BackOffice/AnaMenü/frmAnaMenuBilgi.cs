using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.Fiş;
using NetSatis.BackOffice.Raporlar;

namespace NetSatis.BackOffice.AnaMenü
{
    public partial class frmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frmStok form = new frmStok();
            form.MdiParent = frmAnaMenu.ActiveForm;
            form.Show();
        }

        private void btnCari_ItemClick(object sender, TileItemEventArgs e)
        {
            frmCari form = new frmCari();
            form.MdiParent = frmAnaMenu.ActiveForm;
            form.Show();
        }

        private void btnDepo_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepo form = new frmDepo();
            form.MdiParent = frmAnaMenu.ActiveForm;
            form.Show();
        }

        private void tnKasalar_ItemClick(object sender, TileItemEventArgs e)
        {
            frmKasa form = new frmKasa();
            form.MdiParent = frmAnaMenu.ActiveForm;
            form.Show();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            frmTahsilatlar frm = new frmTahsilatlar();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            frmRaporListesi form = new frmRaporListesi();
            form.MdiParent = frmAnaMenu.ActiveForm; ;
            form.Show();
        }
    }
}