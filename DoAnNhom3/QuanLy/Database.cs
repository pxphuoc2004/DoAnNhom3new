using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DoAnNhom3.QuanLy
{
    public class Database
    {
        //private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QuanLyBanHangOnline;Integrated Security=True";
<<<<<<< Updated upstream
        //private static string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyBanHangOnline.mdf;Integrated Security=True";
        private static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=QuanLyBanHangOnline1;Trusted_Connection=True;";

=======
<<<<<<< HEAD
        private static string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Encrypt=True";
=======
        //private static string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyBanHangOnline.mdf;Integrated Security=True";
        private static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=QuanLyBanHangOnline1;Trusted_Connection=True;";

>>>>>>> 3926876c5777b8b8a104f868dc196ae1256a2a8a
>>>>>>> Stashed changes
        public static DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
