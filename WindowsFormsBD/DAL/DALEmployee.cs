using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBD.MODELO;

namespace WindowsFormsBD.DAL
{
    public class DALEmployee
    {
        BDConexion Cnx = new BDConexion();

        public void Insertar(Employee employee)
        {
            try
            {
                Cnx.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Cnx.Conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = @"
INSERT INTO employees(
            [first_name]
            ,[last_name]
            ,[email]
            ,[hire_date]
            ,[job_id]
            ,[salary])
VALUES (@fn, @ln, @em, @hd, @jid, @sal)";

                //diferentes formas de añadir los parametros
                sqlCommand.Parameters.AddWithValue("@fn", employee.First_name);
                sqlCommand.Parameters.AddWithValue("@ln", employee.Last_name);
                sqlCommand.Parameters.AddWithValue("@sal", employee.Salary);
                sqlCommand.Parameters.AddWithValue("@jid", employee.Job_id);

                SqlParameter p1 = new SqlParameter("@hd", employee.Hire_date);
                sqlCommand.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@em", SqlDbType.VarChar, 100);
                p2.Value = employee.Email;
                sqlCommand.Parameters.Add(p2);


                int num = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Fallo en la inserción!!");
            }
            Cnx.Close();
        }
    }
}

