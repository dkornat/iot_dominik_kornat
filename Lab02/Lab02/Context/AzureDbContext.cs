using Lab02.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Context
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options) : base(options)
        {

        }

        protected AzureDbContext()
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
