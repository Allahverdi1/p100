using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Library
    {
        List<Book> books = new List<Book>();

        public List<Book> FilterByPrice(int minPrice, int maxPrice)
        {
            return books.FindAll(filter => filter.Price > minPrice && filter.Price < maxPrice);
        }

        public List<Book> FilterByGenre(string genre)
        {
            return books.FindAll(filter => filter.genre == Genre);

        }
        public Book FindBookByNo(int no)
        {
            foreach (var item in books)
            {
                if (item.No == no)
                {
                    return books.FindAll(find => find.no == books);
                }



            }
            return null;

        }
    }

      
}
