using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    internal class Regions
    {
        private int region_id;
        private string region_name;

        public int Region_id { get => region_id; set => region_id = value; }
        public string Region_name { get => region_name; set => region_name = value; }

        public Regions(int region_id, string region_name)
        {
            this.region_id = region_id;
            this.region_name = region_name;
        }
    }
}
