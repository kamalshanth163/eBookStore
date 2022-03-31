using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eBookStore.Models;

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
    }
}
