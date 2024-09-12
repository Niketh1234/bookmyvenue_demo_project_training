using Microsoft.EntityFrameworkCore;

namespace BookMyVenueApi.Models
{
    public class Details : DbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=bmvdemo;user id=sa;password=Pass@123;trustservercertificate = true");
        }

    }
}
