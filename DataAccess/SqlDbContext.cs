using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SqlDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=reactApi;Integrated Security=True");
        }
        public DbSet<User> Users { get; set; }
    }
}
