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
using WindowsFormsBD.DAL;

namespace WindowsFormsBD
{
    public partial class FormBDConexion : Form
    {

        public FormBDConexion()
        {
            InitializeComponent();

        }
        DALBDConexion Conn = new DALBDConexion();
        private void butConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                labMessage.Text = "Conexión OK!";
                butConectar.Enabled = false;
                butDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                labMessage.Text = "Fallo en la conexión!";
            }
        }

        private void butDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conn.State != ConnectionState.Closed)
                    Conn.Close();
                labMessage.Text = ("Conexión cerrada!");
                butConectar.Enabled = true;
                butDesconectar.Enabled = false;
            }
            catch (Exception ex)
            {
                labMessage.Text = ("Fallo en la desconexión!");
            }
        }
    }
}
