using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    internal class Dependents
    {
        private int dependent_id;
        private string first_name;
        private string last_name;
        private string relationship;
        private int employee_id;

        public int Dependent_id { get => dependent_id; set => dependent_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Relationship { get => relationship; set => relationship = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }

        public Dependents(int dependent_id, string first_name, string last_name, string relationship, int employee_id)
        {
            this.Dependent_id = dependent_id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Relationship = relationship;
            this.Employee_id = employee_id;
        }
    }
}
