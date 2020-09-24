﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBookstoreRepository<Author> authorRepository;

        // GET: AuthorController

        public AuthorController(IBookstoreRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public ActionResult Index()
        {
            var authors = authorRepository.List();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            var author = authorRepository.Find(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorController/Edit/5
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

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorController/Delete/5
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
    }
}
