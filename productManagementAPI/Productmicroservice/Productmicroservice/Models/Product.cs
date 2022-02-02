using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productmicroservice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }
    }
}
