using project.Application.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace project.Persistance
    
{
    public class DatabaseService : DbContext, IDatabaseService
    {

         public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }

        IConfiguration Configuration;

        public static readonly ILoggerFactory ConsoleLoggerFactory
         = LoggerFactory.Create(builder =>
      {
          builder
           .AddFilter((category, level) =>
               category == DbLoggerCategory.Database.Command.Name
               && level == LogLevel.Information)
           .AddConsole();
      });
        public DatabaseService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                   .UseLoggerFactory(ConsoleLoggerFactory)
                   .UseSqlServer(Configuration.GetConnectionString("SoccerConnection"));
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().ToTable("Genders");
            modelBuilder.Entity<Discipline>().ToTable("Disciplines");
            modelBuilder.Entity<Gender>().ToTable("Genders");
            modelBuilder.Entity<Field>().ToTable("Fields");
            modelBuilder.Entity<FieldType>().ToTable("FieldTypes");
            modelBuilder.Entity<FacilityType>().ToTable("FacilityTypes");
            modelBuilder.Entity<SportFacility>().ToTable("SportFacilities");
            modelBuilder.Entity<GameEnrollment>().ToTable("GameEnrollments");
        }

        public void Save()
        {
            this.SaveChanges();
        }

    }
}
