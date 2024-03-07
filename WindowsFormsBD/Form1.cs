using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class Form1 : Form
    {
        SqlConnection Conn = null;
        public Form1()
        {
            InitializeComponent();
             Conn = new SqlConnection("Server=85.208.20.69,54321;Database=SorayaEmpleados;User Id=sa;Password=Sql#123456789;");
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                labMessage.Text = "Conexión OK!";
                butOpen.Enabled = false;
                butCerrar.Enabled = true;
            }
            catch (Exception ex)
            {
                labMessage.Text = "Fallo en la conexión!";
            }
           
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conn.State != ConnectionState.Closed)
                    Conn.Close();
                labMessage.Text = ("Conexión cerrada!");
                butOpen.Enabled = true;
                butCerrar.Enabled = false;
            }
            catch (Exception ex)
            {
                labMessage.Text = ("Fallo en la desconexión!");
            }
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Insertar3("Soraya","Calvera","dfkjfkjd", new DateTime(2020,01,2),4,10000);
            //Para crear un nuevo objeto se pone new y el nombre de la clase. 
        }
        void Insertar1()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = @"
INSERT INTO employees (first_name, last_name, email, phone_number, hire_date, job_id, salary)
VALUES ('Soraya', 'Calvera', 'sorayakdjfdjf@kdfdkjfd.com', '65455555', '2020/05/20', 2,20000)";
                //Se cogen los parametros que en SQL Server se pueden modificar y no esten marcados
                int num = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{num} filas insertadas!");
            }
            catch (Exception ex)
            {
                labMessage.Text = "Fallo en la inserción!";
            }
        }
        void Insertar2(string first_name, string last_name, string email, string phone_number,DateTime hire_date, int job_id, decimal salary)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Conn;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = $@"
INSERT INTO employees (first_name, last_name, email, phone_number, hire_date, job_id, salary)
VALUES ('{first_name}', '{last_name}', '{email}', '{phone_number}', '{hire_date.ToString("yyyy-MM-dd")}', {job_id},{salary})";
                //hire_date.ToString("yyyy-MM-dd") se pone para que solo salga la fecha y no la hora
                int num = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{num} filas insertadas!");
            }
            catch (Exception ex)
            {
                labMessage.Text = "Fallo en la inserción!";
            }
        }

        void Insertar3 (string first, string ln, string email, DateTime hire, int jobid, decimal salary)
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
                sqlCommand.Parameters.AddWithValue("@fn", first);
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
