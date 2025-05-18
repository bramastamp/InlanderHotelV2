using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InlanderHotel
{
    public class Koneksi
    {
        private readonly string connectionString = "Data Source = LAPTOP-TTQ6FMD5\\SQLEXPRESS; " +
                                                   "Initial Catalog = db_hotel; " +
                                                   "Integrated Security = true ";
        
        public SqlConnection GetConn()
        {
            return new SqlConnection(connectionString);
        }
    }
}
