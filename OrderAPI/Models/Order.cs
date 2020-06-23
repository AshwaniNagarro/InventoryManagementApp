using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Decimal OrderAmount { get; set; }
        public string OrderDate { get; set; }
    }
}
