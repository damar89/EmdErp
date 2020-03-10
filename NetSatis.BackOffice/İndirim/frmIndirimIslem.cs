using DevExpress.XtraWizard;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.İndirim
{
    public partial class frmIndirimIslem : Form
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDal indirimDal = new IndirimDal();
        public frmIndirimIslem()
        {
            InitializeComponent();
            gridContIndirimler.DataSource = context.Indirimler.Local.ToBindingList();

        }

        private Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Indirim _entity = new Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkodu = entity.Barkodu;
            _entity.StokAdi = entity.StokAdi;
            return _entity;
        }

        private void frmIndirimIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    Indirim _entity = new Indirim();
                    _entity = StokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.StokKodu == itemStok.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Seçili Olan Stoğa Daha Önceden Eklenmiş İndirim Bulunmaktadır. Var Olan İndirimi Güncellemek İstermisiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenId.Id;
                            indirimDal.AddOrUpdate(context, _entity);

                        }
                    }
                    else
                    {
                        indirimDal.AddOrUpdate(context, _entity);
                    }

                }

            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    itemIndirim.IndirimTuru = "Süresiz";
                }
                else
                {
                    itemIndirim.BaslangicTarihi = dateBaslangic.DateTime;
                    itemIndirim.BitisTarihi = dateBitis.DateTime;
                    itemIndirim.IndirimTuru = "Tarih Arası";
                }



            }
            indirimDal.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Listeden Çıkarmak İstediğinize Emin Misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilenstokKodu = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
                var secilen = indirimDal.GetByFilter(context, c => c.StokKodu == secilenstokKodu);
                context.Entry(secilen).State = EntityState.Detached;
            }



        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == completionWizardPage1 && e.Direction == Direction.Forward && gridIndirimler.RowCount == 0)
            {
                MessageBox.Show("Listeye Ürün Eklenmedi");
                e.Cancel = true;
            }
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridIndirimler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }

        private void btnTopluGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTopluOran frm = new frmTopluOran();
            frm.ShowDialog();
            if (frm.secildi == true)
            {
                if (frm.list.Count != 0)
                {
                    for (int i = 0; i < gridIndirimler.RowCount; i++)
                    {
                        gridIndirimler.SetRowCellValue(i, "IndirimOrani", frm.list[0].Degeri);
                    }
                    gridIndirimler.RefreshData();
                }
            }
        }
    }
}
