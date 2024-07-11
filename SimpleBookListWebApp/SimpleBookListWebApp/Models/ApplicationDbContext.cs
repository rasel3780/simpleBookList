using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SimpleBookListWebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
    
}
