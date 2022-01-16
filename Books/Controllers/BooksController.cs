using Books.Models;
using Books.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookContext _context;
        public BooksController(BookContext context)
        {
            _context = context;
        }
        public IActionResult Index(string q)
        {
            var model = new BooksViewModel
            {
                Books = _context.Books.Include(x => x.Author).Include(x => x.Genres).ToList()
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            
            return View(_context.Books.Include(b => b.Author).Include(b => b.Genres).FirstOrDefault(b=>b.Id==id));
        }
        [HttpGet]
        public IActionResult Genres(int id)
        {


            var model = new BooksViewModel
            {
                Books = _context.Books.Include(x => x.Author).Include(x => x.Genres).Where(x => x.Genres.Any(x => x.Id == id)).ToList()
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Search(string q)
        {
            var books = _context.Books.Include(x => x.Genres).Include(x => x.Author).AsQueryable();

            if (!string.IsNullOrEmpty(q))
            {
                books = books.Where(x => x.Name.ToLower().Contains(q.ToLower()));
            }
            var model = new BooksViewModel
            {
                Books = books.ToList()
            };
            return View("Books", model);
        }
    }
}
