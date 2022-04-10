using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    internal class MenuItem
    {
        private static int _no;
        public int No { get; }
        public MenuItem()
        {
            _no++;
            No = _no;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public Catagory catagory { get; set; }
    }
}
