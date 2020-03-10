using DevExpress.DataProcessing;
using DevExpress.XtraGrid;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Kod
{
    public partial class frmKodlar : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KodDAL kodDal = new KodDAL();
      
        private string _tablo;

        public frmKodlar(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            context.Kodlar.Where(c => c.Tablo == _tablo).Load();
            gridContTanim.DataSource = context.Kodlar.Local.ToBindingList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.Kodlar.Local.ForEach(c => c.Tablo = _tablo);
            context.SaveChanges();
            this.Close();

        }


        private void gridTanim_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridTanim.FocusedRowHandle != GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gridTanim_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Entities.Tables.Kod row = (Entities.Tables.Kod)e.Row;
            if (context.Kodlar.Local.Any(c => c.OnEki == row.OnEki))
            {
                MessageBox.Show("Aynı Ön Ekle Kod Kaydedilemez. ");
                gridTanim.CancelUpdateCurrentRow();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}