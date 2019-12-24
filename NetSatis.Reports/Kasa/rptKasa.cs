using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Context;
using DevExpress.DataAccess.ObjectBinding;
using System.Collections.Generic;
using NetSatis.Entities.Tables;

namespace NetSatis.Reports.Kasa
{
    public partial class rptKasa : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKasa(int KasaID, DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            KasaHareketDAL kasatDal = new KasaHareketDAL();
            var kasaEntity = kasatDal.GetByFilter(context, c => c.Id == KasaID);
            ObjectDataSource kasaHareketDataSource = new ObjectDataSource { DataSource = kasatDal.kasaHareket(context, KasaID, baslangic, bitis) };

            this.DataSource = kasaHareketDataSource;
            colOdemeTuru.DataBindings.Add("Text", this.DataSource, "OdemeTuru.OdemeTuruAdi");
            colKasaAdi.DataBindings.Add("Text", this.DataSource, "Kasa.KasaAdi");
            colTipi.DataBindings.Add("Text", this.DataSource, "Hareket");            
            colTarih.DataBindings.Add("Text", this.DataSource, "Tarih", "{0:dd.MM.yyyy}");
            colTutar.DataBindings.Add("Text", this.DataSource, "Tutar");
            colAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");

           


        }

    }
}
