using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Order
    {
        public string No { get; set; }
        public int ProductCount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
