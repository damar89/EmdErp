using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmBaRapor : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();

        public frmBaRapor(int ay, int yil, string tip)
        {
            InitializeComponent();
            var data = context.Fisler.Where(x =>
            x.Tipi == tip &&
            (x.FisTuru == "Alış Faturası" || x.FisTuru == "Satış İade Faturası")
            && x.Tarih.Value.Month == ay
            && x.Tarih.Value.Year == yil
            && x.CariId != null
            ).ToList();

           var res = data.GroupBy(x => x.CariId).Select(x =>
             new
             {
               BaTutar = x.Sum(a => a.ToplamTutar - (a.IskontoTutari1+a.DipIskNetTutari+a.KdvToplam_)).Value,
               CariAdi = x.FirstOrDefault().CariAdi,
               CariKodu = x.FirstOrDefault().Cari.CariKodu,
               FaturaUnvani = x.FirstOrDefault().Cari.FaturaUnvani,
               BelgeMiktari = Convert.ToInt32(x.Count())
             }
            ).Where(b => b.BaTutar >= 5000).ToList();

            gridControl1.DataSource = res;
        }





        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridView1.ExportToPdf(save.FileName + ".xls");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridView1.ExportToPdf(save.FileName + ".xls");
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridControl1;
            link.Landscape = true;
            link.Landscape = true;
            link.Margins.Left = 3;
            link.Margins.Right = 3;
            link.Margins.Top = 6;
            link.Margins.Bottom = 3;
            link.ShowPreview();
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridView1.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void cvsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridView1.ExportToPdf(save.FileName + ".csv");
            }
        }
    }
}