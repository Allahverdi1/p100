﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    internal class Order
    {
        private static int _no;
        public int No { get; }
        public Order()
        {
            _no++;
            No = _no;
        }
       
        public int TotalPrice { get; set; }
        public DateTime date { get; set; }
    }
}
