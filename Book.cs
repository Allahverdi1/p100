using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Book
    {
        public enum GenreType
        {
            Genre
        }
        public GenreType Genre { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        private static int _no;
        
        public int No { get; }

        public Book()
        {
            _no++;
            No = _no;
        }




    }
}
