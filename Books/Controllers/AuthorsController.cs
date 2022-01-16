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
    public class AuthorsController : Controller
    {
        private readonly BookContext _context;
        public AuthorsController(BookContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new AuthorsViewModel
            {
                Authors = _context.Authors.Include(x => x.Genres).ToList()
            };
            return View(model);
        }
        public IActionResult Details(int id)
        {
            return View(_context.Authors.Include(x => x.Books).Include(x => x.Genres).FirstOrDefault(x => x.Id == id));
        }
    }
}
