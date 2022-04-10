using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eBookStore.Data;
using eBookStore.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using eBookStore.Common;

namespace eBookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly eBookStoreContext _context;

        public BooksController(eBookStoreContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }
        public async Task<IActionResult> Catalogue(string searchTerm)
        {
            return View(_context.Books.Where(x => x.Title.Contains(searchTerm) || searchTerm == null || searchTerm == "").ToList());
        }

        // GET: Books/Details/5
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

        public async Task<IActionResult> Feedbacks(int? bookId, int? userId)
        {
            var feedbacks = new List<Feedback>();

            if(userId == 0)
            {
                feedbacks = _context.Feedbacks.Where(x => x.BookId == bookId).ToList();
            }
            else
            {
                feedbacks = _context.Feedbacks.Where(x => x.BookId == bookId && x.UserId == userId).ToList();
            }

            feedbacks = Enumerable.Reverse(feedbacks).ToList();

            var feedbackDisplays = FeedbackDisplays(feedbacks);

            HttpContext.Session.SetString("BookId", bookId.ToString());

            return View(feedbackDisplays);
        }

        public List<FeedbackDisplay> FeedbackDisplays(List<Feedback> feedbacks)
        {
            var models = new List<FeedbackDisplay>();

            foreach (var fb in feedbacks)
            {
                var bookFromDb = _context.Books.Find(fb.BookId);
                var userFromDb = _context.Users.Find(fb.UserId);

                var model = new FeedbackDisplay
                {
                    Id = fb.Id,
                    BookName = bookFromDb == null ? "" : bookFromDb.Title,
                    UserName = userFromDb == null ? "" : userFromDb.Name,
                    FeedbackText = fb.FeedbackText,
                    Rating = fb.Rating,
                    Imgfile = bookFromDb == null ? "" : bookFromDb.Imgfile
                };

                models.Add(model);
            }

            return models;
        }

        public async Task<IActionResult> AllFeedbacks()
        {
            var bookId = Convert.ToInt32(HttpContext.Session.GetString("BookId"));
            return RedirectToAction(nameof(Feedbacks), new { bookId = bookId, userId = 0 });
        }

        public async Task<IActionResult> MyFeedbacks()
        {
            var userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var bookId = Convert.ToInt32(HttpContext.Session.GetString("BookId"));
            return RedirectToAction(nameof(Feedbacks), new { bookId = bookId, userId = userId });
        }

        public async Task<IActionResult> CreateFeedback(string feedbackText, decimal rating)
        {
            var userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var bookId = Convert.ToInt32(HttpContext.Session.GetString("BookId"));
            rating = rating >= 0
                        ? rating > 5.0m
                            ? 5.0m : rating
                        : 0;

            var feedback = new Feedback
            {
                BookId = bookId,
                UserId = userId,
                FeedbackText = feedbackText,
                Rating = rating
            };

            _context.Add(feedback);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Feedbacks), new { bookId = bookId, userId = 0 });
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file, [Bind("Id,Title,Info,Bookquantity,Price,Category,Author")] Book book)
        {
            if (file != null)
            {
                string filename = file.FileName;
                //  string  ext = Path.GetExtension(file.FileName);
                string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images"));
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                { await file.CopyToAsync(filestream); }

                book.Imgfile = filename;
            }
            _context.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IFormFile file, int id, [Bind("Id,Title,Info,Bookquantity,Price,Category,Author,Imgfile")] Book book)
        {
            if (file != null)
            {
                string filename = file.FileName;
                //  string  ext = Path.GetExtension(file.FileName);
                string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images"));
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                { await file.CopyToAsync(filestream); }

                book.Imgfile = filename;
            }

            _context.Update(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
