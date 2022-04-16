using Microsoft.EntityFrameworkCore;
using MyBlazorServerApp.Data.Models;

namespace MyBlazorServerApp.Data
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<GuestEntry> GuestEntries { get; set; }
        public DbSet<StarWarsAffiliation> StarWarsAffiliations { get; set; }

        public DbSet<UserInfo> users { get; set; }
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Call base as well or get error
            base.OnModelCreating(modelBuilder);

            GuestEntry[] entriesToSeed = new GuestEntry[3];

            for (int i = 1; i < 4; i++)
            {
                entriesToSeed[i - 1] = new GuestEntry
                {
                    GuestEntryID = i,
                    GuestName = "John Doe " + i,
                    EntryTimeDate = DateTime.Now,
                    GuestInput = "This is entry number " + i 
                };
            }
            modelBuilder.Entity<GuestEntry>().HasData(entriesToSeed);

            UserInfo[] userSeed = new UserInfo[1];
            for (int i = 1; i < 2; i++)
            {
                userSeed[i - 1] = new UserInfo
                {
                    UserID = i,
                    UserName = "TheLordCommander",
                    UserPassword = "Loser9009!",
                    Role = "Admin",
                };
            }
            modelBuilder.Entity<UserInfo>().HasData(userSeed);
        }
    }
}
