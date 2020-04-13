using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Snap.Core.API;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Context;

namespace NetSatis.Utils.Raporlama
{
    public partial class FrmRaporTasarlaXtra : DevExpress.XtraEditors.XtraForm
    {
        string DizaynIsmi = string.Empty;
        DizaynTipi dizaynTipi;
        RaporTasarimlari _raporTasarimlari = new RaporTasarimlari();
        private object dataSource { get; set; }
        RaporlamaDAL raporDal = new RaporlamaDAL();
        UtilsRaporlama util = new UtilsRaporlama();
        NetSatisContext context = new NetSatisContext();
        private XtraReport seciliRapor = new XtraReport();
        public FrmRaporTasarlaXtra(object datasource, DizaynTipi _dizaynTipi, bool OnIzle = false, bool Yazdir = false, int DesingID = 0, int copiesCount = 1)
        {
            InitializeComponent();
            dizaynTipi = _dizaynTipi;
            dataSource = datasource;
            if (OnIzle)
            {
                util.OnIzle(DesingID, dataSource);
            }
            else if (Yazdir)
            {
                util.Yazdir(DesingID, dataSource, copiesCount);
            }
            else
            {
                seciliRapor = new XtraReport();
                seciliRapor.DataSource = dataSource;
                reportDesigner1.OpenReport(seciliRapor);
            }
        }
        public RaporTasarimlari raporTasarimlari
        {
            get
            {
                MemoryStream memoryStream = new MemoryStream();
                seciliRapor.SaveLayout(memoryStream);
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

                seciliRapor = XtraReport.FromStream(new MemoryStream(_raporTasarimlari.Dizayn));
                seciliRapor.DataSource = dataSource;
                reportDesigner1.OpenReport(seciliRapor);
            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (raporTasarimlari.Id == 0)
                {
                    raporTasarimlari.DuzenlemeTarihi = (DateTime?)null;
                    FrmRaporUstBilgi frmRaporUstBilgi = new FrmRaporUstBilgi();
                    frmRaporUstBilgi.ShowDialog();
                    if (frmRaporUstBilgi.Vazgecildi)
                    {
                        XtraMessageBox.Show("Kayıt işlemi başarısız!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DizaynIsmi = frmRaporUstBilgi.RaporIsmi;
                }
                else
                    raporTasarimlari.DuzenlemeTarihi = DateTime.Now;

                raporTasarimlari.DizaynAraci = this.Name;
                raporDal.AddOrUpdate(context, raporTasarimlari);
                raporDal.Save(context);

                XtraMessageBox.Show("Kayıt işlemi başarılı", "Rapor Tasarımı Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                throw err;
            }

        }

        private void btnKayitliRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmKayitliRaporlar(dizaynTipi, this.Name);
            frm.ShowDialog();
            if (frm.secilenRaporTasarimi != null)
                raporTasarimlari = frm.secilenRaporTasarimi;

        }

        private void FrmRaporTasarla_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (raporTasarimlari.Id == 0)
                return;

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
}