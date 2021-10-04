using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImg { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImg = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImg = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImg = "Assets/3.png" });

            return books;
        }
    }
}
