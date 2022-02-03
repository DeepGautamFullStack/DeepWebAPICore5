using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepWebAPICore5.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string AadharNumber { get; set; }
    }
}
