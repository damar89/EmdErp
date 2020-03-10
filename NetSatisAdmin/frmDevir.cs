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