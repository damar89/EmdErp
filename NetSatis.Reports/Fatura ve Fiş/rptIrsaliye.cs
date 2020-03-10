namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public partial class rptIrsaliye : DevExpress.XtraReports.UI.XtraReport
    {
     
        public rptIrsaliye()
        {
            InitializeComponent();
            //NetSatisContext context = new NetSatisContext();
            //StokHareketDAL stokHareketDal = new StokHareketDAL();

            //FisDAL fisDal = new FisDAL();


            //Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);

            //ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context, c => c.FisKodu == fisKodu) };

            ////fatura başlık

            //lblCariAdi.Text = fisBilgi.Cari.FaturaUnvani;
            //lblAdres.Text = fisBilgi.Cari.Adres;
            //lblTarih.Text = fisBilgi.Tarih.ToString();
            //lblVergiDairesi.Text = fisBilgi.Cari.VergiDairesi;
            //lblVergiNo.Text = fisBilgi.Cari.VergiNo;


            // lblIkametgah.Text =  fisBilgi.Cari.Ilce + "-" + fisBilgi.Cari.Il;
            ////fatura ürünler
            //this.DataSource = stokHareketDataSource;
            //colBarkodu.DataBindings.Add("Text", this.DataSource, "Stok.Barkodu");
            //colStokKodu.DataBindings.Add("Text", this.DataSource, "Stok.StokKodu");
            //colStokAdi.DataBindings.Add("Text", this.DataSource, "Stok.StokAdi");
            //colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar","{0:N2}");
            //colBirim.DataBindings.Add("Text", this.DataSource, "Stok.Birim");
         

        }

    }
}
