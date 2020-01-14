using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Medical
{
    class Connection
    {
        static SqlConnection sc;
        public static SqlConnection GetConnection()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = @"Server= DESKTOP-QQ8I8AR\SQLEXPRESS; Initial Catalog=POS_DB; Integrated Security= True";
                sc.Open();

            }
            return sc;

        }
    }
}
