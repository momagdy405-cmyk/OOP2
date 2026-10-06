using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6
{
    internal struct Delivaryaddress
    {
       
            public string city;
            public string street;
            public int buildingnumber;

            public Delivaryaddress(string city, string street, int buildingnumber)
            {
                this.city = city;
                this.street = street;
                this.buildingnumber = buildingnumber;
            }
            public override string ToString()
            {
                return $"This order in {city} city,at {street} street,buildingnumber {buildingnumber}";
            }
        }
}
