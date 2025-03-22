using Microsoft.EntityFrameworkCore;
using SuperFolio.Api.DAL.Entity;

namespace SuperFolio.Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\hasan;Database=SuperFolioApiDB; Integrated security=true; Trusted_Connection=True;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
