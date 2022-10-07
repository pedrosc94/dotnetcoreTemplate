using Microsoft.EntityFrameworkCore;

namespace dotnetcoreTemplate {
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<User>? User { get; set; }
    }
}