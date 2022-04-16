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
    public class AdminController : Controller
    {
        private readonly eBookStoreContext _context;

        public AdminController(eBookStoreContext context)
        {
            _context = context;
        }

        public IActionResult CreateAdmin()
        {
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(LoginAdmin));
        }

        public IActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost, ActionName("LoginAdmin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAdmin(string name, string pass)
        {
            var user = _context.Users.FirstOrDefault(x => x.Name == name && x.Pass == pass && x.Role == "admin");

            ViewData["Message"] = "";

            if (user != null)
            {
                HttpContext.Session.SetString("Name", user.Name);
                HttpContext.Session.SetString("Role", user.Role);
                HttpContext.Session.SetString("UserId", user.Id.ToString());

                return RedirectToAction("Index", "books");
            }
            else
            {
                ViewData["Message"] = "wrong user name password";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAdmin([Bind("Id,Name,Pass,Email")] User user)
        {
            user.Role = "admin";
            _context.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(LoginAdmin));
        }
    }
}
