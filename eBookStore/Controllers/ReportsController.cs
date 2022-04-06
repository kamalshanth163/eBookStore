using ClosedXML.Excel;
using eBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eBookStore.Controllers
{
    public class ReportsController : Controller
    {
        private readonly eBookStoreContext _context;

        public ReportsController(eBookStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> GenerateBookReport()
        {
            var books = _context.Books.ToList();

            using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Books");
                var currentRow = 1;

                #region Header
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Title";
                worksheet.Cell(currentRow, 3).Value = "Info";
                worksheet.Cell(currentRow, 4).Value = "Bookquantity";
                worksheet.Cell(currentRow, 5).Value = "Price";
                worksheet.Cell(currentRow, 6).Value = "Author";
                #endregion

                #region Body
                foreach (var book in books)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = book.Id;
                    worksheet.Cell(currentRow, 2).Value = book.Title;
                    worksheet.Cell(currentRow, 3).Value = book.Info;
                    worksheet.Cell(currentRow, 4).Value = book.Bookquantity;
                    worksheet.Cell(currentRow, 5).Value = book.Price;
                    worksheet.Cell(currentRow, 6).Value = book.Author;
                }
                #endregion

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Books.xlsx"
                    );
                }

            }
        }

        public async Task<IActionResult> GenerateUserReport()
        {
            var users = _context.Users.ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Users");
                var currentRow = 1;

                #region Header
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Name";
                worksheet.Cell(currentRow, 3).Value = "Pass";
                worksheet.Cell(currentRow, 4).Value = "Role";
                worksheet.Cell(currentRow, 5).Value = "Email";
                #endregion

                #region Body
                foreach (var user in users)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = user.Id;
                    worksheet.Cell(currentRow, 2).Value = user.Name;
                    worksheet.Cell(currentRow, 3).Value = user.Pass;
                    worksheet.Cell(currentRow, 4).Value = user.Role;
                    worksheet.Cell(currentRow, 5).Value = user.Email;
                }
                #endregion

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Users.xlsx"
                    );
                }

            }
        }

        public async Task<IActionResult> GenerateOrderReport()
        {
            var orders = _context.Orders.ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");
                var currentRow = 1;

                #region Header
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "BookId";
                worksheet.Cell(currentRow, 3).Value = "UserId";
                worksheet.Cell(currentRow, 4).Value = "Quantity";
                worksheet.Cell(currentRow, 5).Value = "OrderDate";
                worksheet.Cell(currentRow, 6).Value = "Status";
                #endregion

                #region Body
                foreach (var order in orders)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = order.Id;
                    worksheet.Cell(currentRow, 2).Value = order.BookId;
                    worksheet.Cell(currentRow, 3).Value = order.UserId;
                    worksheet.Cell(currentRow, 4).Value = order.Quantity;
                    worksheet.Cell(currentRow, 5).Value = order.Orderdate;
                    worksheet.Cell(currentRow, 6).Value = order.Status;
                }
                #endregion

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Orders.xlsx"
                    );
                }
            }
        }
    }
}
