using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class DatabaseConnection
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abdul\OneDrive\Documents\CodeDatabase.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
