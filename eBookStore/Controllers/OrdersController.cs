using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eBookStore.Data;
using eBookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;

namespace eBookStore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly eBookStoreContext _context;

        public OrdersController(eBookStoreContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public async Task<IActionResult> Create(int? id)
        {
            var book = await _context.Books.FindAsync(id);
            return View(book);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int bookId, int quantity)
        {
            Order order = new Order();
            order.BookId = bookId;
            order.Quantity = quantity;

            order.UserId = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            order.Orderdate = DateTime.Today;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\eBookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
            string sql;
            sql = "UPDATE Books  SET Bookquantity  = Bookquantity   - '" + order.Quantity + "'  where (Id ='" + order.BookId + "' )";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();


            _context.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyOrders));
        }

        public async Task<IActionResult> MyOrders()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            var orderItems = await _context.Orders.FromSqlRaw("select * from Orders where UserId = '" + id + "'  ").ToListAsync();
            return View(orderItems);
        }

        public async Task<IActionResult> CustomerOrders(int? id)
        {
            var orderItems = await _context.Orders.FromSqlRaw("select * from Orders where UserId = '" + id + "'  ").ToListAsync();
            return View(orderItems);
        }

        public async Task<IActionResult> CustomerReport()
        {
            var orderItems = await _context.Reports.FromSqlRaw("select Users.Id as Id, Name as Customername, Sum (Quantity * Price) as Total from Books, Orders,Users where Users.Id = Orders.UserId  and BookId = Books.Id group by Name,Users.Id ").ToListAsync();
            return View(orderItems);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,UserId,Quantity,Orderdate")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
