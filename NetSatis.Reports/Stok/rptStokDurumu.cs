using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.Reports.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumu()
        {
            InitializeComponent();
            NetSatisContext context=new NetSatisContext();
            StokDAL stokDal=new StokDAL();
            ObjectDataSource stokDataSource=new ObjectDataSource{DataSource=stokDal.StokListele(context)};
            this.DataSource = stokDataSource;
          
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirim.DataBindings.Add("Text", this.DataSource, "Birim");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");
            

            XRSummary sumStokToplam=new XRSummary();
            sumStokToplam.Func = SummaryFunc.Sum;
            sumStokToplam.Running = SummaryRunning.Group;
            sumStokToplam.FormatString = "{0:N2}";
            
            lblToplamStok.DataBindings.Add("Text", null, "MevcutStok");
            lblToplamStok.Summary = sumStokToplam;
            


        }
       

    }
}
