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
using DevExpress.XtraPrinting;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmBsRapor : DevExpress.XtraEditors.XtraForm
    {
        public frmBsRapor()
        {
            InitializeComponent();
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