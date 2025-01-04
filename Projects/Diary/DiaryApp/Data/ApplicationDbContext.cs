using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id=1,
                    Title="Watched a movie",
                    Content="Watched Snow white and the axe man",
                    Created=DateTime.Now
                },
                 new DiaryEntry
                 {
                     Id = 2,
                     Title = "Went for a walk",
                     Content = "Did an 8km walk",
                     Created = DateTime.Now
                 },
                  new DiaryEntry
                  {
                      Id = 3,
                      Title = "Visited Hillary",
                      Content = "Visited Hillary to discuss his bricked phone",
                      Created = DateTime.Now
                  }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }


        /*
         Four steps to add a table
        1. Create a model class
        2. Add DB Set
        3. add-migration AddDiaryEntryTable
        4. update-database
         */
    }
}
