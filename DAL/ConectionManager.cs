using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConectionManager
    {
        public SqlConnection Connection;

        public ConectionManager(string conection)
        {
            Connection = new SqlConnection(conection);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
