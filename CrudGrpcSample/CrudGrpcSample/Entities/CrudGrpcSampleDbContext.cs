using Microsoft.EntityFrameworkCore;

namespace CrudGrpcSample.Entities
{
    public class CrudGrpcSampleDbContext : DbContext
    {
        public CrudGrpcSampleDbContext(DbContextOptions<CrudGrpcSampleDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
