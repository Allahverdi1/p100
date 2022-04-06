using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Library
    {
        List<Book> books = new List<Book>();
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null-dir");
            }
            return books.Find(Book => Book.Id == id);

        }

        public void RemoveBook(int id)
        {
            var result = books.Find(Book => Book.Id == id);
            if (id == null)
            {
                throw new NullReferenceException("null-dir");
            }
            books.Remove(result);


        }

    }


}
