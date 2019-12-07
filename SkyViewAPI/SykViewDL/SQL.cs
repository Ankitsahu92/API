using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SykViewDL
{
    public class SQL
    {
        private string conStr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        private SqlConnection con;
        private SqlCommand com;
        private DataSet ds;
        private SqlDataAdapter da;

        public DataSet getDataSet(string sqlQur)
        {
            try
            {
                using (con = new SqlConnection(conStr))
                {
                    using (com = new SqlCommand(sqlQur))
                    {
                        com.CommandType= CommandType.StoredProcedure;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ds;
        }

        
    }
}
