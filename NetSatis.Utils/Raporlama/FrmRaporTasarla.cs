using DevExpress.Snap.Core.API;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Utils.Raporlama;
using System;
using System.IO;
using System.Windows.Forms;

namespace NetSatis.Utils.Raporlama
{
    public partial class FrmRaporTasarla : XtraForm
    {
        string DizaynIsmi = string.Empty;
        DizaynTipi dizaynTipi;
        RaporlamaDAL raporDal = new RaporlamaDAL();
        NetSatisContext context = new NetSatisContext();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasource">veri kaynağı</param>
        /// <param name="_dizaynTipi"></param>
        /// <param name="Yazdir">Direkt yazdır</param>
        /// <param name="DesingID">e.item.tag</param>
        public FrmRaporTasarla(object datasource, DizaynTipi _dizaynTipi, bool Yazdir = true, int DesingID = 0)
        {
            InitializeComponent();
            dizaynTipi = _dizaynTipi;
            snapControl1.DataSource = datasource;
            if (Yazdir)
            {
                raporTasarimlari = raporDal.GetByFilter(context, x => x.Id == DesingID);// repo.Rapor.Getir(DesingID);

                snapControl1.ShowPrintPreview();

            }
        }

        RaporTasarimlari _raporTasarimlari = new RaporTasarimlari();
        public RaporTasarimlari raporTasarimlari
        {
            get
            {
                MemoryStream memoryStream = new MemoryStream();
#pragma warning disable CS0618 // 'SnapControl.SaveDocument(Stream, DocumentFormat)' is obsolete: 'This method overload has become obsolete. Use the SaveDocument method with the "fileName" parameter to save your documents in the native Snap format (.snx), and the ExportDocument(string, DocumentFormat) method - to store your documents in other formats.'
                snapControl1.SaveDocument(memoryStream, SnapDocumentFormat.Snap);
#pragma warning restore CS0618 // 'SnapControl.SaveDocument(Stream, DocumentFormat)' is obsolete: 'This method overload has become obsolete. Use the SaveDocument method with the "fileName" parameter to save your documents in the native Snap format (.snx), and the ExportDocument(string, DocumentFormat) method - to store your documents in other formats.'
                memoryStream.Seek(0, SeekOrigin.Begin);
                var str = memoryStream.ToArray();
                memoryStream.Close();
                _raporTasarimlari.Dizayn = str;
                _raporTasarimlari.DizaynIsmi = DizaynIsmi;
                _raporTasarimlari.DizaynTipi = dizaynTipi.ToString();
                return _raporTasarimlari;
            }
            set
            {
                _raporTasarimlari = value;
                DizaynIsmi = _raporTasarimlari.DizaynIsmi;

                MemoryStream memoryStream = new MemoryStream(_raporTasarimlari.Dizayn);
                memoryStream.Seek(0, SeekOrigin.Begin);
                snapControl1.LoadDocument(memoryStream, SnapDocumentFormat.Snap);
                memoryStream.Close();

            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (raporTasarimlari.Id == 0)
                {
                    FrmRaporUstBilgi frmRaporUstBilgi = new FrmRaporUstBilgi();
                    frmRaporUstBilgi.ShowDialog();
                    if (frmRaporUstBilgi.Vazgecildi)
                    {
                        XtraMessageBox.Show("Kayıt işlemi başarısız!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DizaynIsmi = frmRaporUstBilgi.RaporIsmi;
                }

                raporDal.AddOrUpdate(context, raporTasarimlari);
                raporDal.Save(context);
                //raporTasarimlari.Id = repo.Rapor.KaydetID(raporTasarimlari);

                XtraMessageBox.Show("Kayıt işlemi başarılı", "Rapor Tasarımı Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                throw err;
            }

        }

        private void btnKayitliRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmKayitliRaporlar(dizaynTipi);
            frm.ShowDialog();
            if (frm.secilenRaporTasarimi != null)
                raporTasarimlari = frm.secilenRaporTasarimi;
            degisiklik = false;

        }

        private void FrmRaporTasarla_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (raporTasarimlari.Id == 0)
                return;

            if (degisiklik)
            {
                var dr = XtraMessageBox.Show("Son Değişiklikleri Kaydetmek istermisiniz?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    btnKaydet_ItemClick(null, null);
                }
            }
        }

        bool degisiklik = false;
        private void snapControl1_TextChanged(object sender, EventArgs e)
        {
            degisiklik = true;
        }
    }
}
