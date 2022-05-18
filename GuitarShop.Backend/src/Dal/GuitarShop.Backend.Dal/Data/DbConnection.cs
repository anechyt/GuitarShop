using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Backend.Dal.Data
{
    public class DbConnection
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Data Source=Andrey-PC100;Initial Catalog=GuitarShop;Integrated Security=True;");
        }
    }
}
