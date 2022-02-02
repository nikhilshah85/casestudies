using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productmicroservice.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public string TrDate { get; set; }
        public double TrAmount { get; set; }
    }
}
