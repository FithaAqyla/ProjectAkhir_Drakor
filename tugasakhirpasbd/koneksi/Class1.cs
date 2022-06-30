using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasakhirpasbd.koneksi
{
    class Class1
    {
        public SqlConnection GetConn() 
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=exeCRUD;User ID=sa;Password=123");
            return con;
        }
    }
}
