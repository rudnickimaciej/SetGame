using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Persistance
{
    public class DatabaseInitializer
        : CreateDatabaseIfNotExists<DatabaseService>
    {
        protected override void Seed(DatabaseService database)
        {
            base.Seed(database);

            CreatePlayers(database);

            CreateSportFacilities(database);

            CreateFields(database);

            CreateGames(database);
        }

        private void CreatePlayers(DatabaseService database)
        {
            database.Players.Add(new Player() { Name = "Maciek", LastName = "Rudnicki", Gender = new Gender() { Name = "Male" } });
            database.Players.Add(new Player() { Name = "Piotr", LastName = "Pietrucha", Gender = new Gender() { Name = "Male" } });
            database.Players.Add(new Player() { Name = "Karol", LastName = "Wojtyła", Gender = new Gender() { Name = "Male" } });
            database.Players.Add(new Player() { Name = "Franek", LastName = "Polkowski", Gender = new Gender() { Name = "Female" } });



            database.SaveChanges();
        }





    }

    private void CreateGames(DatabaseService database)
    {
        var players = database.Players.ToList();
        var fields = database.Fields.ToList();

        database.Games.Add(new Game()
        {
            Start = DateTime.Now,
            Duration = 90,
            Price = 12.5f,
            SlotsCount = 12,
            Status = new GameStatus() { Status = "ACTIVE" },
            Author = players[0],
            Discipline = new Discipline() { Name = "Soccer" },
            Field = fields[0]
        }
        );
    }



    var customers = database.Customers.ToList();

    var employees = database.Employees.ToList();

    var products = database.Products.ToList();

    database.Sales.Add(new Sale()
    {
        Date = DateTime.Now.Date.AddDays(-3),
                Customer = customers[0],
                Employee = employees[0],
                Product = products[0],
                UnitPrice = 5m,
                Quantity = 1
            });

            database.Sales.Add(new Sale()
    {
        Date = DateTime.Now.Date.AddDays(-2),
                Customer = customers[1],
                Employee = employees[1],
                Product = products[1],
                UnitPrice = 10m,
                Quantity = 2
            });

            database.Sales.Add(new Sale()
    {
        Date = DateTime.Now.Date.AddDays(-1),
                Customer = customers[2],
                Employee = employees[2],
                Product = products[2],
                UnitPrice = 15m,
                Quantity = 3
            });

            database.SaveChanges();
        }
    }
}
