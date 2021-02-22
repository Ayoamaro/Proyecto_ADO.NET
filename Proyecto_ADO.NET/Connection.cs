using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADO.NET
{
    class Connection
    {
        SqlConnection conn;

        public SqlConnection Con {
            get { return conn; }
            set { conn = value; }
        }

        public Connection() {
            String strConn = "Data Source=localhost;Initial Catalog=dbFutbol;Integrated Security=true";
            Con = new SqlConnection(strConn);
        }
    }
}
