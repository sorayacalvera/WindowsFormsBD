﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBD.DAL;
using WindowsFormsBD.MODELO;

namespace WindowsFormsBD
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.ShowDialog();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(0, "Soraya", "Calvera", "dfkjfkjd@cdc.es", "698547125", new DateTime(2020, 01, 2), 10000, 4, 3, 2);
            DALEmployee dal = new DALEmployee();
            dal.Insertar(emp);

        }
        /*
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
       }*/
    }
}
