using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
namespace NetSatis.FrontOffice
{
    public partial class frmFiyatGor : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private BarkodDAL barkodDal = new BarkodDAL();
        public NetSatisContext context;
        public bool saved = false;
        public frmFiyatGor(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            context = new NetSatisContext();
            txtBarkod.Focus();
      
                   }
        private void frmFiyatGor_Load(object sender, EventArgs e)
        {
            txtBarkod.Focus();


        }
        private void bindingSource()
        {
            txtKod.DataBindings.Clear();
            txtStokAdi.DataBindings.Clear();
            lblUretici.DataBindings.Clear();
            lblMarka.DataBindings.Clear();
            calcSatisFiyat1.DataBindings.Clear();


            context.Barkodlar.Where(c => c.StokId == _entity.Id).Load();
            txtKod.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            lblUretici.DataBindings.Add("Text", _entity, "Uretici", false, DataSourceUpdateMode.OnPropertyChanged);
            lblMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat1.DataBindings.Add("Text", _entity, "SatisFiyati1", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcSatisFiyat1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyat1.DataBindings[0].FormatString = "C2";
            var r = stokDal.StokAdetler(context, _entity.Id);
            if (r.HasValue)
                lblMiktar.Text = r.Value.ToString("n2");
        }
        private void txtBarkod_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            saved = true;
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok kodentity;
                //Entities.Tables.Barkod barkodEntity = context.Barkodlar.FirstOrDefault();
                kodentity = context.Stoklar.FirstOrDefault(c => c.Barkodu == txtBarkod.Text);
                if (kodentity == null)
                    kodentity = context.Barkodlar.FirstOrDefault(c => c.Barkodu == txtBarkod.Text)?.Stok;
                if (kodentity != null)
                {
                    _entity = kodentity;
                    bindingSource();
                }
                else
                {
                    MessageBox.Show("Barkod veya Stok Kodu Bulunamadı..");
                }
                txtBarkod.Text = "";
                txtBarkod.Focus();
            }
        }
        private void frmFiyatGor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}