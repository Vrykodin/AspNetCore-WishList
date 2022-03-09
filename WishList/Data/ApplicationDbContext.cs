using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Item> Items;
    }
}
