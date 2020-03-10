using System;
using System.Data.SqlClient;

namespace NetSatis.Entities.Tools
{
    public static class ConnectionTool
    {


        public static bool CheckConnetion(string SqlServerConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(SqlServerConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
