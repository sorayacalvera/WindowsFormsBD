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
        public void Insertar3(Employee employee)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Conn;
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
                sqlCommand.Parameters.AddWithValue("@ln", ln);
                sqlCommand.Parameters.AddWithValue("@sal", salary);
                sqlCommand.Parameters.AddWithValue("@jid", jobid);

                SqlParameter p1 = new SqlParameter("@hd", hire);
                sqlCommand.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@em", SqlDbType.VarChar, 100);
                p2.Value = email;
                sqlCommand.Parameters.Add(p2);


                int num = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{num} filas insertadas!");

            }
            catch (Exception ex)
            {

                labMessage.Text = "Fallo en la 3r inserción!!";
            }
        }
    }
}
}
