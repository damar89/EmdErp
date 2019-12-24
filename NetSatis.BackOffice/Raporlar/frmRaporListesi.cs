using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using NetSatis.Reports.Stok;
using NetSatis.Reports.Cari;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmRaporListesi : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor;
        public frmRaporListesi()
        {
            InitializeComponent();
        }

       
        private void navBarLink_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            filterControl1.FilterString = null;
            var buton = sender as NavBarItem;

            Type tip = Assembly.Load("NetSatis.Reports").GetTypes()
                .SingleOrDefault(c => c.Name == buton.Name.Replace("link", ""));

             rapor = (XtraReport)Activator.CreateInstance(tip);
            txtRaporAdi.Text = buton.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : txtAciklama.Text = buton.Tag.ToString();
            filterControl1.SourceControl = rapor.DataSource;


        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            frmRaporGoruntule form = new frmRaporGoruntule(rapor);
            rapor.FilterString = filterControl1.FilterString;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarItem4_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            rptCariBakiye rpr = new rptCariBakiye();
            rpr.ShowPreview();
        }
    }
}