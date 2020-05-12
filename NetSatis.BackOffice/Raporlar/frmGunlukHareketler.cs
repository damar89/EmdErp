using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmGunlukHareketler : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext _context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaDAL kasaDal = new KasaDAL();
        public frmGunlukHareketler(NetSatisContext context, System.DateTime dtBaslangic, System.DateTime dtBitis)
        {
            context = _context;

            InitializeComponent();

            gridContKasaHareket.DataSource =
                kasaDal.OdemeTuruToplamKasaTariheGoreListele(context,
                    x => x.Tarih >= dtBaslangic && x.Tarih <= dtBitis);

        }
    }
}