using Microsoft.EntityFrameworkCore;
using razor.Models;

namespace razor
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Định nghĩa các DbSet cho các bảng trong database của bạn
        public DbSet<Product> Products { get; set; }
    }
}
