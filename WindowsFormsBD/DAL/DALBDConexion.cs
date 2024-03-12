using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.DAL
{
    public class DALBDConexion
    {
        SqlConnection Conn = null;
        public SqlConnection Conn1 { get => Conn; set => Conn = value; }
        public DALBDConexion()
        {
            Conn1 = new SqlConnection("Server=85.208.20.69,54321;Database=SorayaEmpleados;User Id=sa;Password=Sql#123456789;");
        }

  
    }
}
