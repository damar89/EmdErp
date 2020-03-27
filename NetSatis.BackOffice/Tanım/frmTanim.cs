using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmTanim : Form
    {
        NetSatisContext context = new NetSatisContext();
        TanimDAL tanimDal = new TanimDAL();
        private TanimTuru _tanimTuru;
        public Tanim _entity;
        public bool secildi = false;

        public frmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;



        }
        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            Birim,
            Kategori,
            AnaGrup,
            AltGrup,
            Marka,
            Uretici,
            Model,
            Proje,
            Pozisyon,
            SezonYil,
            OzelKod,
            PersonelUnvan,
            Grubu


        }

        private void frmTanim_Load(object sender, EventArgs e)
        {
            Listele();

        }

        void Listele()
        {
            gridContTanim.DataSource = tanimDal.StokListele(context, c => c.Turu == _tanimTuru.ToString());

        }

        void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;
            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }
        void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _entity = new Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridTanim.RowCount != 0)
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
                KayitAc();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                tanimDal.Delete(context, c => c.Id == secilen);
                tanimDal.Save(context);
                Listele();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimTuru.ToString();
            if (tanimDal.AddOrUpdate(context, _entity))
            {
                tanimDal.Save(context);
                KayitKapat();
                Listele();
            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridTanim.RowCount != 0)
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
            }
        }

        private void gridTanim_DoubleClick(object sender, EventArgs e)
        {
            if (gridTanim.RowCount != 0)
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
            }
        }

        private void frmTanim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnSec.PerformClick();
            }
        }
    }
}

