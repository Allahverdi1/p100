using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    internal class OrderItem
    {
        private static int _count;
        public int Count { get; set; }
        public OrderItem()
        {
            _count++;
            Count = _count;
        }
        
    }
}