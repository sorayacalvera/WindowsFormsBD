using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBD.DAL;
using WindowsFormsBD.MODELO;

namespace WindowsFormsBD
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void listBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(0, textBoxFirst_name.Text, textBoxLast_name.Text, textBoxEmail.Text, textBoxPhone_number.Text, Convert.ToDateTime(dateTimeHire_date.Value.Date), numericUpDownManager_id.Value, Convert.ToInt16(numericUpDownSalary.Value), Convert.ToInt16(numericUpDownDepartment_id.Value), Convert.ToInt16(numericUpDownJob_id.Value));

            DALEmployee dal = new DALEmployee();
            
            dal.Insertar(emp);
        }
    }
}
