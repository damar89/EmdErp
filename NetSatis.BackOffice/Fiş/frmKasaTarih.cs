using System;
using DevExpress.XtraEditors.Mask;
using NetSatis.BackOffice.Kasa_Hareketleri;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmKasaTarih : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KasaDAL kasaDal = new KasaDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();

        private int secilen;
        public frmKasaTarih()
        {
            InitializeComponent();
            //_kasaId = Convert.ToInt32(gridLookKasa.Text);
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            gridControl1.DataSource = kasaDal.KasaListele(context);





        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;

            //dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);

            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            string secilenAd = gridView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            frmTarihKasaHareket form = new frmTarihKasaHareket(secilen, dtBaslangic, dtBitis);
            form.Show();
            this.Close();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookKasa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void dtpBaslangic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                 dtpBaslangic.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 0,0,0);
            }
        }

        private void dtpBitis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
            if (e.Button.Index == 1)
            {

                dtpBitis.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 23,59,59);
            }
        }
    }
}