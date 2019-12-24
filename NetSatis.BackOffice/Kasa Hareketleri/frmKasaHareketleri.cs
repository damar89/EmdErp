using System;
using System.Windows.Forms;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Kasa_Hareketleri
{
    public partial class frmKasaHareketleri : Form
    {
        NetSatisContext context = new NetSatisContext();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
       
        public frmKasaHareketleri(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();

            gridContKasaHareket.DataSource = kasaHareketDal.MasrafHareket(context, "Masraf Fişi", baslangic, bitis);
        }

        
        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {
        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
        
        }

       

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFisIslem form = new frmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }

        private void frmKasaHareketleri_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

    }}
