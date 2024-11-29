using cairo_library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace cairo_library.data
{
    public class myappdpcontext:DbContext
    {
        public myappdpcontext(DbContextOptions<myappdpcontext> options) : base(options)
        {
        }
            
        public DbSet<books>books { get; set; }
        public DbSet<checkout>checkouts { get; set; }
        public DbSet<librarian>librarians { get; set; }
        public DbSet<member> members { get; set; }
        public DbSet<penality> penalities { get; set; }

            
        
    }
}
