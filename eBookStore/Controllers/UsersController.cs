using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eBookStore.Data;
using eBookStore.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using eBookStore.Common;

namespace eBookStore.Controllers
{
    public class UsersController : Controller
    {
        private readonly eBookStoreContext _context;

        public UsersController(eBookStoreContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ActionName("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string name, string pass)
        {
            var user = _context.Users.FirstOrDefault(x => x.Name == name && x.Pass == pass && x.Role == "customer");

            ViewData["Message"] = "";

            if (user != null)
            {
                HttpContext.Session.SetString("Name", user.Name);
                HttpContext.Session.SetString("Role", user.Role);
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetComplexData("CartItems", new List<CartItem>());

                return RedirectToAction("catalogue", "books");
            }
            else
            {
                ViewData["Message"] = "wrong user name password";
                return View();
            }
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Pass,Email")] User user)
        {
            user.Role = "customer";
            _context.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var user = await _context.Users.FindAsync(id);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Pass,Role,Email")] User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public async Task<IActionResult> AdminDashboard()
        {
            var dashboard = new AdminDashboard
            {
                Id = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                TotalBooks = _context.Books.Count(),
                TotalAdmins = _context.Users.Where(u => u.Role == "admin").Count(),
                TotalCustomers = _context.Users.Where(u => u.Role == "customer").Count(),
                TotalOrders = _context.Orders.Count(),
                TotalPendingOrders = _context.Orders.Where(u => u.Status == "pending").Count(),
                TotalCompletedOrders = _context.Orders.Where(u => u.Status == "completed").Count(),
            };

            return View(dashboard);
        }


        // GET: Users/Edit/5
        public async Task<IActionResult> EditUserbyAdmin()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var user = await _context.Users.FindAsync(id);
            return View(user);
        }
    }
}
