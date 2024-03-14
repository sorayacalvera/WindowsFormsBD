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

        public List<Employee> Select() 
        { 
            List<Employee> listEmployee = new List<Employee>();
            string sql = " SELECT * FROM employees";
            SqlCommand sqlCommand = new SqlCommand(sql, Cnx.Conn);
            Cnx.Conn.Open();
            
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Employee miemployee = new Employee();
                miemployee.Employee_id = (int)reader["employee_id"];
                miemployee.First_name = reader.GetString(1);
                miemployee.Last_name = reader.GetString(2);
                miemployee.Email = reader.GetString(3);
                miemployee.Phone_number = reader.IsDBNull(4) ? (string)null : (string)reader.GetString(4);
                miemployee.Hire_date = reader.GetDateTime(5);
                miemployee.Job_id = (int)reader["job_id"];
                miemployee.Salary = (decimal)reader["salary"];
                miemployee.Manager_id = reader.IsDBNull(8) ? (int?)null : (int?)reader[8];
                miemployee.Department_id = reader.IsDBNull(9) ? (int?)null : (int?)reader[9];

                listEmployee.Add(miemployee);
            }
            Cnx.Conn.Close();
            return listEmployee;

        }
    }
}

