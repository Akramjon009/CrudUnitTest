using MarketPlace.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Infrastructure.Persistance
{
    public class MpDbContext : DbContext
    {
        public MpDbContext(DbContextOptions<MpDbContext> ops)
            : base(ops)
            => Database.Migrate();

        public DbSet<Product> Products { get; set; }
    }
}
