using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Validations;

namespace NetSatis.BackOffice.Masraf
{
    public partial class frmMasrafIslem : DevExpress.XtraEditors.XtraForm
    {
       
        private MasrafDAL masrafDal = new MasrafDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        private Entities.Tables.Masraf _entity;
        

        public frmMasrafIslem(Entities.Tables.Masraf entity, bool kopyala = false)
        {
            InitializeComponent();
        
            if (kopyala)
            {
                _entity = new Entities.Tables.Masraf();
                _entity.Id = -1;
                _entity.MasrafKodu = "";
                _entity.Durumu = entity.Durumu;
                _entity.MasrafAdi = entity.MasrafAdi;
                _entity.Grubu = entity.Grubu;
                _entity.Aciklama = entity.Aciklama;
     
            }
            else
            {
                _entity = entity;
               
            }
            togDurum.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "MasrafKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMasrafAdi.DataBindings.Add("Text", _entity, "MasrafAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGrup.DataBindings.Add("Text", _entity, "Grubu", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        public frmMasrafIslem()
        {
        }

        private void frmMasrafIslem_Load(object sender, EventArgs e)
        {
            togDurum.EditValue = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (masrafDal.AddOrUpdate(context, _entity))
            {
                masrafDal.Save(context);
                MessageBox.Show("Masraf kartı başarılı bir şekilde kaydedilmiştir.");
                this.Close();
            }
       
     
            

         
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.Grubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        txtGrup.Text = form._entity.Tanimi;
                    }

                    break;
                case 1:
                    txtGrup.Text = null;
                    break;

            }
        }

        private void frmMasrafIslem_KeyDown(object sender, KeyEventArgs e)
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
    }
}