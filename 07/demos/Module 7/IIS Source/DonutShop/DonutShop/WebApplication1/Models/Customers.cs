using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customers
    {
        public IList<Order> Orders { get; set; }
    }

    public class Order
    {
        public string Name { get; set; }
        public int DonutCount { get; set; }
    }
}