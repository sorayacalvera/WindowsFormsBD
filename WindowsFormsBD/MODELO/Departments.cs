using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    internal class Departments
    {
        private int department_id;
        private string department_name;
        private int location_id;

        public int Department_id { get => department_id; set => department_id = value; }
        public string Department_name { get => department_name; set => department_name = value; }
        public int Location_id { get => location_id; set => location_id = value; }

        public Departments(int department_id, string department_name, int location_id)
        {
            this.department_id = department_id;
            this.department_name = department_name;
            this.location_id = location_id;
        }


    }
}
