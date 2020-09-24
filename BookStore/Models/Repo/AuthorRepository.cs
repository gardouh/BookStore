using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repo
{
    public class AuthorRepository : IBookstoreRepository<Author>

    {
        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author {Id=1, FullName="Gardouh Khalil"},
                new Author {Id=2, FullName="Hamid MAKBOUL"},
                new Author {Id=3, FullName="Said HAMRI"}

            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            authors.Remove(Find(id));
        }

        public Author Find(int id)
        {
            return authors.SingleOrDefault(author => author.Id == id);
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName
        }
    }
}
