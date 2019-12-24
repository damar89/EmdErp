using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;

namespace NetSatisAdmin
{
    public partial class frmDevir : DevExpress.XtraEditors.XtraForm
    {
        //NetSatisContext kaynakContext =new NetSatisContext();
        //private List<string> dbList;


        public frmDevir()
        {
            InitializeComponent();
            //dbList=kaynakContext.Database.SqlQuery<string>("Select name from master.dbo.sysdatabases where name like")
        }
    }
}