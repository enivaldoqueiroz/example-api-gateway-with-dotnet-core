using API.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Persistence
{
    public class ApiGatewayDBContext : IdentityDbContext
    {
        public ApiGatewayDBContext()
        {
        }

        public ApiGatewayDBContext(DbContextOptions<ApiGatewayDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=db_api_gateway001;";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(conn);
            }
        }
    }
}
