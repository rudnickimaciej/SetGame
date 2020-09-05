using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Persistance.Migrations
{
    public class DbService :  IDbService
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory
        = LoggerFactory.Create(builder =>
        {
            builder
              .AddFilter((category, level) =>
                  category == DbLoggerCategory.Database.Command.Name
                  && level == LogLevel.Information)
              .AddConsole();
        });


        public void Save()
        {
            
        }
    }
}
