using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models.Other
{
    public class Address
    {
        public Country Country { get; set; }
        public Town Town { get; set; }
        public City City { get; set; }
        public string LocalAddress { get; set; }
        public string PostalCode { get; set; }
        public Coordinate coordinate { get; set; }
    }
}
