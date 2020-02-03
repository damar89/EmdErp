using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.Personel;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using System.IO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Mask;
using System.Threading;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.OleDb;
namespace NetSatis.BackOffice.Fiş
{
    public partial class frmCariVirman : XtraForm
    {
        //NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
        //List<NetSatis.EDonusum.Models.Donusum.Details> dlist = new List<EDonusum.Models.Donusum.Details>();
        private int sec;
        NetSatisContext context = new NetSatisContext();
        FisAyarlari ayarlar = new FisAyarlari();
        FisDAL fisDal = new FisDAL();
        bool stoklarYuklendi = false;
        MasrafHareketDAL masrafHareketDal = new MasrafHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();
        CariDAL cariDal = new CariDAL();
        private int? _cariId;
        Fis _fisentity = new Fis();
        CariBakiye _entityBakiye = new CariBakiye();
        private CodeTool kodOlustur;
        StokDAL stokDAL = new StokDAL();
        CariBakiye entityBakiye = new CariBakiye();
        private Entities.Tables.Cari _entity;
     
        private bool basariylaKaydedildi = false;
        bool duzenle = false;
        int frontOfficeUserId = 0;
        public frmCariVirman(string fisKodu = null, string fisTuru)
        {
            InitializeComponent();
           
            if (fisKodu != null)
            {
                duzenle = true;
            }
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            kodOlustur.BarButonOlustur();
            cmbTarih.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();
             
            }
         
            }
        }
    }

