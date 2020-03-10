using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiyat_Değiştir
{
    public partial class frmFiyatDegistir : Form
    {
        public List<FiyatDegistir> list;
        public bool secildi = false;

        public frmFiyatDegistir()
        {
            InitializeComponent();
            list = new List<FiyatDegistir>
            {
                new FiyatDegistir
                {
                    FiyatTuru = "Alış Fiyatı-1",
                    KolonAdi = "AlisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,
            

                },

                //new FiyatDegistir
                //{
                //    FiyatTuru = "Alış Fiyatı-2",
                //    KolonAdi = "AlisFiyati2",
                //    Degistir = false,
                //    DegisimTuru = "Yüzde",
                //    DegisimYonu = "Arttır",
                //    Degeri = 0,
                //    Referans = "",

                //},
                //new FiyatDegistir
                //{
                //    FiyatTuru = "Alış Fiyatı-3",
                //    KolonAdi = "AlisFiyati3",
                //    Degistir = false,
                //    DegisimTuru = "Yüzde",
                //    DegisimYonu = "Arttır",
                //    Degeri = 0,
                //    Referans = "",

                //},
                new FiyatDegistir
                {
                    FiyatTuru = "Satis Fiyatı-1",
                    KolonAdi = "SatisFiyati1",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0

                },
                new FiyatDegistir
                {
                    FiyatTuru = "Satis Fiyatı-2",
                    KolonAdi = "SatisFiyati2",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,

                },
                new FiyatDegistir
                {
                    FiyatTuru = "Satis Fiyatı-3",
                    KolonAdi = "SatisFiyati3",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,

                },
                 new FiyatDegistir
                {
                    FiyatTuru = "Satis Fiyatı-4",
                    KolonAdi = "SatisFiyati4",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,

                },
                  new FiyatDegistir
                {
                    FiyatTuru = "Web Satış Fiyatı",
                    KolonAdi = "WebSatisFiyati",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,
                },
                     new FiyatDegistir
                {
                    FiyatTuru = "Web Bayi Satış Fiyatı",
                    KolonAdi = "WebBayiSatisFiyati",
                    Degistir = false,
                    DegisimTuru = "Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0,
                },

            };
            lupreffiyat.DataSource = list;

            lupreffiyat.DisplayMember = "FiyatTuru";
            lupreffiyat.ValueMember = "KolonAdi";
            lupreffiyat.PopulateColumns();

            lupreffiyat.Columns["KolonAdi"].Visible = false;
            lupreffiyat.Columns["Degistir"].Visible = false;
            lupreffiyat.Columns["DegisimTuru"].Visible = false;
            lupreffiyat.Columns["DegisimYonu"].Visible = false;
            lupreffiyat.Columns["Degeri"].Visible = false;
            lupreffiyat.Columns["Referans"].Visible = false;

            gridControl1.DataSource = list;
        }

        private void frmFiyatDegistir_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFiyatDegistir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
             DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
