using eBookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eBookStore.Data
{
    public class eBookStoreContext : DbContext
    {
        public eBookStoreContext (DbContextOptions<eBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Report> Reports { get; set; }
        public DbSet<AdminDashboard> AdminDashboard { get; set; }
        public DbSet<eBookStore.Models.CartItem> CartItem { get; set; }
    }
}
