using Microsoft.EntityFrameworkCore;
using Shop.App.Models;

namespace Shop.App.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ShopContext(DbContextOptions options) : base(options)
        {

        }
    }
}