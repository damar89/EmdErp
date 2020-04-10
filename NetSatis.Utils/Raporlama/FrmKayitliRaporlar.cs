using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Utils.Raporlama;

namespace NetSatis.Utils
{
    public partial class FrmKayitliRaporlar : XtraForm
    {

        DizaynTipi dizaynTipi;
        public RaporTasarimlari secilenRaporTasarimi { get; set; }

        RaporlamaDAL raporDal = new RaporlamaDAL();
        NetSatisContext context = new NetSatisContext();
        public FrmKayitliRaporlar(DizaynTipi _dizaynTipi)
        {
            InitializeComponent();
            dizaynTipi = _dizaynTipi;
        }


        private void btnCik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmKayitliRaporlar_Load(object sender, EventArgs e)
        {
            var res = raporDal.GetAll(context, x => x.DizaynTipi == dizaynTipi.ToString());// repo.Rapor.Getir(x => x.DizaynTipi == dizaynTipi.ToString()).ToList();
            grRaporlar.DataSource = res;
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dr = XtraMessageBox.Show("Silmek istediğinizden emin misiniz?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                return;
            var resID = Convert.ToInt32(gvRaporlar.GetRowCellValue(gvRaporlar.FocusedRowHandle, "ID"));
            raporDal.Delete(context, x => x.Id == resID);
                raporDal.Save(context);

                gvRaporlar.DeleteRow(gvRaporlar.FocusedRowHandle);
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var resID = Convert.ToInt32(gvRaporlar.GetRowCellValue(gvRaporlar.FocusedRowHandle, "ID"));
            secilenRaporTasarimi = raporDal.GetByFilter(context, x => x.Id == resID);
            this.Close();
        }

        private void btnDizaynIsmiDegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmRaporUstBilgi();
            frm.ShowDialog();
            if (frm.Vazgecildi)
                return;
            var resID = Convert.ToInt32(gvRaporlar.GetRowCellValue(gvRaporlar.FocusedRowHandle, "ID"));
            secilenRaporTasarimi = raporDal.GetByFilter(context, x => x.Id == resID);

            secilenRaporTasarimi.DizaynIsmi = frm.RaporIsmi;
            raporDal.AddOrUpdate(context, secilenRaporTasarimi);
            raporDal.Save(context);

            XtraMessageBox.Show("Rapor ismi güncellendi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            secilenRaporTasarimi = null;
            var res = raporDal.GetAll(context, x => x.DizaynTipi == dizaynTipi.ToString());// repo.Rapor.Getir(x => x.DizaynTipi == dizaynTipi.ToString()).ToList();
            grRaporlar.DataSource = res;
        }
    }
}
