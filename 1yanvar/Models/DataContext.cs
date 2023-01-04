using Microsoft.EntityFrameworkCore;

namespace _1yanvar.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {

        }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Catagori> Catagori { get; set; }
        public DbSet<PortfolioImage> portfolioImages { get; set; }
    }
}
