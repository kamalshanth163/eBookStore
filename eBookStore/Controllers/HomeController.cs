using eBookStore.Data;
using eBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eBookStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly eBookStoreContext _context;
        public HomeController(eBookStoreContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Books(string searchTerm)
        {
            return View(_context.Books.Where(x => x.Title.Contains(searchTerm) || searchTerm == null || searchTerm == "").ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public async Task<IActionResult> Index()
        {
            return View(_context.Books.ToList().Take(5));
        }
    }
}
