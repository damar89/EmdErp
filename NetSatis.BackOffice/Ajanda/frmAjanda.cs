using NetSatis.Entities.Context;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Ajanda
{
    public partial class frmAjanda : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public frmAjanda()
        {
            InitializeComponent();
            context.EFAppointments.Load();
            context.EFResources.Load();

            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();
            schedulerControl1.Start = DateTime.Now;
        }

        private void frmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }

        private void frmAjanda_TextChanged(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }


}