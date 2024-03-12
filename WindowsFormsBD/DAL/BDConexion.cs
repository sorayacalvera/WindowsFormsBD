using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.DAL
{
    public class BDConexion
    {
        SqlConnection conn = null;
        public SqlConnection Conn { get => conn; set => conn = value; }
        public BDConexion()
        {
            Conn = new SqlConnection("Server=85.208.20.69,54321;Database=SorayaEmpleados;User Id=sa;Password=Sql#123456789;");
        }
        public void Open()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }
  
    }
}
