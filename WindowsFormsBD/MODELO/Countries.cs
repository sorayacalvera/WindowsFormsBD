using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    public class Countries
    {
        private int country_id; 
        private string country_name;
        private string region_id;

        public string Country_name { get => country_name; set => country_name = value; }
        public int Country_id { get => country_id; set => country_id = value; }
        public string Region_id { get => region_id; set => region_id = value; }

        public Countries(int country_id, string country_name, string region_id)
        {
            this.Country_id = country_id;
            this.country_name = country_name;
            this.region_id = region_id;
        }


    }
}
