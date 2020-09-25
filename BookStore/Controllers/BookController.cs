using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Models.Repo;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller

    {
        private readonly IBookstoreRepository<Book> bookstoreRepository;
        private readonly IBookstoreRepository<Author> authorstoreRepository;

        public BookController(IBookstoreRepository<Book> bookstoreRepository, IBookstoreRepository<Author> authorstoreRepository)
        {
            this.bookstoreRepository = bookstoreRepository;
            this.authorstoreRepository = authorstoreRepository;

        }
        // GET: BookController
        public ActionResult Index()
        {
            return View(bookstoreRepository.List());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            var model = new BookAuthorView
            {
                Authors = FillSelectList()
            };

            return View(model);
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                var model = new BookAuthorView
                {
                    Authors = FillSelectList()
                };
                bookstoreRepository.Add(book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        List<Author> FillSelectList()
        {
            var authors = authorstoreRepository.List().ToList();
            authors.Insert(0, new Author { Id = -1, FullName = "--- Please select an author ---" });

            return authors;
        }
    }
}
