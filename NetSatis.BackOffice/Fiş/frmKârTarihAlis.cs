﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Context;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmKârTarihAlis : DevExpress.XtraEditors.XtraForm
    {
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
            KategoriDAL kategoriDal = new KategoriDAL();
        AnaGrupDAL anagrupDal = new AnaGrupDAL();
        AltGrupDAL altgrupDal = new AltGrupDAL();
        StokDAL stokDal = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        public frmKârTarihAlis()
        {
            InitializeComponent();
            lokKategori.Properties.DataSource = kategoriDal.GetAll(context);
            lookAnaGrup.Properties.DataSource = anagrupDal.GetAll(context);
            lookAltGrup.Properties.DataSource = altgrupDal.GetAll(context);
            lookMarka.Properties.DataSource = stokDal.GetAll(context);
            lookUretici.Properties.DataSource = stokDal.GetAll(context);
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1,00,00,00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31,23,59,59);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;

            frmKarZaraAlisFiyat form = new frmKarZaraAlisFiyat(dtBaslangic, dtBitis);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}