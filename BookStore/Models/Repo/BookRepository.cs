using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repo
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1,
                    Title ="C# Programming",
                    Description ="No description",
                    Author = new Author{Id = 2 }
                },
                new Book
                {
                    Id=2,
                    Title ="Java Programming",
                    Description ="Nothing",
                    Author = new Author()
                },
                new Book
                {
                    Id=3,
                    Title ="Python Programming",
                    Description ="No data",
                    Author = new Author()
                },
            };
        }
        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Delete(int id)
        {
            books.Remove(Find(id));
        }

        public Book Find(int id)
        {
           return books.SingleOrDefault(b => b.Id == id);
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newbook)
        {
            var book = Find(id);
            book.Title = newbook.Title;
            book.Description = newbook.Description;
            book.Author = newbook.Author;
        }
    }
}
