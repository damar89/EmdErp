using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetSatisAdmin
{
    public partial class frmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        DepoDAL depoDal = new DepoDAL();
        KasaDAL kasaDal = new KasaDAL();
        NetSatisContext context = new NetSatisContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        private Kullanici _entity;
        public bool saved = false;
        private string parola, cevap;

        public frmKullaniciIslem(Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            gridlookDepo.Properties.DataSource = depoDal.GetAll(context);
            gridLookKasa.Properties.DataSource = kasaDal.GetAll(context);

            if (entity != null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Cevap = null;
                entity.Parola = null;
            }

            _entity = entity;
            gridLookKasa.EditValue = entity.KasaId;
            gridlookDepo.EditValue = entity.DepoId;


            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSoyAdi.DataBindings.Add("Text", _entity, "SoyAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false,
                DataSourceUpdateMode.OnPropertyChanged);
 
            txtParola.DataBindings.Add("Text", _entity, "Parola", false,
              DataSourceUpdateMode.OnPropertyChanged);


            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false,
                DataSourceUpdateMode.OnPropertyChanged);
            AyarYukle();
        }

        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {
                        context.KullaniciRolleri.Add(new KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked,

                        });
                    }
                    else
                    {
                        context.KullaniciRolleri.SingleOrDefault(c =>
                                  c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki =
                              treeList1.Nodes[i].Nodes[j].Checked;

                    }
                }
            }

            context.SaveChanges();

        }

        private void frmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrari.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtParola.Text = cevap;
                txtParolaTekrari.Text = cevap;
            }
            if (txtParola.Text != txtParolaTekrari.Text)
            {
                MessageBox.Show("Girilmiş olan Parola alanları aynı olmak zorundadır.");
            }
            else
            {

                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;

                }
                if (gridLookKasa.EditValue != null)
                {
                    _entity.KasaId = Convert.ToInt32(gridLookKasa.EditValue);

                }
                if (gridlookDepo.EditValue != null)
                {
                    _entity.DepoId = Convert.ToInt32(gridlookDepo.EditValue);
                }
                if (kullaniciDal.AddOrUpdate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    this.Close();
                }


            }

        }

        private void frmKullaniciIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
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