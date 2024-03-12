using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    internal class Jobs
    {
        private int job_id;
        private string job_title;
        private decimal min_salary;
        private decimal max_salary;
        public int Job_id { get => job_id; set => job_id = value; }
        public string Job_title { get => job_title; set => job_title = value; }
        public decimal Min_salary { get => min_salary; set => min_salary = value; }
        public decimal Max_salary { get => max_salary; set => max_salary = value; }

        public Jobs(int job_id, string job_title, decimal min_salary, decimal max_salary)
        {
            this.Job_id = job_id;
            this.Job_title = job_title;
            this.Min_salary = min_salary;
            this.Max_salary = max_salary;
        }


    }
}
