using FrontToBack2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack2.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Course> courses { get;set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<StaffQuotes> quotes { get; set; }


    }
}
