using Microsoft.EntityFrameworkCore;

namespace Ders1.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\TEW_SQLEXPRESS;Database=TESTDB;User ID=sa;Password=1;Trusted_Connection=False;TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Book> Books_ { get; set; }

    }
}
