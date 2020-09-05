using CleanArchitecture.Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Persistance
{
    public class DatabaseService : DbContext, IDatabaseService
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }

        public DatabaseService() : base("Data Source=.;Initial Catalog=SOCCER3;Integrated Security=True")
        {
            //Database.SetInitializer(new DatabaseInitializer());
        }

        public void Save()
        {
            this.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
