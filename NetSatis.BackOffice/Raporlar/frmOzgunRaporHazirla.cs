using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmOzgunRaporHazirla : DevExpress.XtraEditors.XtraForm
    {
        private List<object> veriListesi = new List<object>();

        NetSatisContext context = new NetSatisContext();
     

        public frmOzgunRaporHazirla()
        {
            InitializeComponent();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            foreach (var itemChecked in checkedListBoxControl1.Items.Where(c => c.CheckState == CheckState.Checked).ToList())
            {
                Type tip = Assembly.Load("NetSatis.Entities").GetTypes()
                    .SingleOrDefault(c => c.Name == itemChecked.Value.ToString());
                object veri = Activator.CreateInstance(tip);

                MethodInfo info = tip.GetMethod(itemChecked.Tag.ToString());

                try
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context }));
                }
                catch (Exception)
                {

                    veriListesi.Add(info.Invoke(veri, new object[] { context,null }));
                }
                


            }
            frmOzgunRaporlar form = new frmOzgunRaporlar(veriListesi);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void frmOzgunRaporHazirla_Load(object sender, EventArgs e)
        {

        }
    }
}