using Microsoft.EntityFrameworkCore;


namespace NikAmozBooklet.ModelBinding.Models
{
    public class MbDbContext:DbContext
    {
        public MbDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
