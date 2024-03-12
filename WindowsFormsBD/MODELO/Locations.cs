using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODELO
{
    internal class Locations
    {
        private int location_id;
        private string street_address;
        private string postal_code;
        private string city;
        private string state_province;
        private int country_id;

        public int Location_id { get => location_id; set => location_id = value; }
        public string Street_address { get => street_address; set => street_address = value; }
        public string Postal_code { get => postal_code; set => postal_code = value; }
        public string City { get => city; set => city = value; }
        public string State_province { get => state_province; set => state_province = value; }
        public int Country_id { get => country_id; set => country_id = value; }

        public Locations(int location_id, string street_address, string postal_code, string city, string state_province, int country_id)
        {
            this.Location_id = location_id;
            this.Street_address = street_address;
            this.Postal_code = postal_code;
            this.City = city;
            this.State_province = state_province;
            this.Country_id = country_id;
        }


    }
}
