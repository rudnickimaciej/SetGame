using CleanArchitecture.Application.Interfaces;
using Domain.Cities;
using Domain.Disciplines;
using Domain.Fields;
using Domain.Games;
using Domain.Players;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DatabaseServiceMock : IDatabaseService
    {

        //public IDbSet<Discipline> Disciplines { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<City> Cities { get; set; }
        public List<Player> Players { get; private set; }
        public List<Field> Fields { get; set; }

        public List<Game> Games { get; set; }
        public DatabaseServiceMock()
        {
            this.Players = new List<Player>()
            {
                new Player(){Id=1,Name="Maciek",LastName="Rudnicki",Sex=Sex.Male },
                new Player(){Id=2,Name="Piotr",LastName="Kak",Sex=Sex.Male },
                new Player(){Id=3,Name="Stefan",LastName="Kakdw",Sex=Sex.Male },
                new Player(){Id=4,Name="Paweł",LastName="Fonto",Sex=Sex.Male },
                new Player(){Id=5,Name="Karol",LastName="Ponto",Sex=Sex.Female },
                new Player(){Id=6,Name="Kuba",LastName="Kulaws",Sex=Sex.Female },
                new Player(){Id=7,Name="Bogdan",LastName="Bod",Sex=Sex.Male },
                new Player(){Id=8,Name="Adrian",LastName="Pento",Sex=Sex.Male },
                new Player(){Id=9,Name="Emilian",LastName="Siera",Sex=Sex.Female },
                new Player(){Id=10,Name="Mateusz",LastName="Sarkow",Sex=Sex.Male },
                new Player(){Id=11,Name="Stan",LastName="Pula",Sex=Sex.Female }

            };

            this.Fields = new List<Field>()
            {
                new Field(){Id=1,City="Kraków",Street = "Popławska",StreetNumber = 23,Name= "Boisko przy szkole podstawowej numer 3"},
                new Field(){Id=2,City="Kraków",Street = "Zielona",StreetNumber = 13,Name= "Boisko przy Parku"},

            };

            this.Games = new List<Game>()
            {
                new Game(){
                    Author=Players.Where(p=>p.Id==1).FirstOrDefault(),
                    Id=1,
                    Discipline=Discipline.Soccer,
                    Price=10.5f,
                    SlotsCount=10,
                    GameDuration=90,
                    GameDateTime=new DateTime(2020,08,23,18,00,00),
                    Players = this.Players.Where(p=>p.Id%2==0).ToList(),
                    Field = Fields[0]
                },
                 new Game(){
                    Author=Players.Where(p=>p.Id==8).FirstOrDefault(),
                    Id=2,
                    Discipline=Discipline.Basketball,
                    SlotsCount=8,
                    Price=20,
                    GameDuration=60,
                    Field = Fields[1],
                    GameDateTime = new DateTime(2020,08,25,12,00,00),
                    Players = this.Players.Where(p=>p.Id%3==0).ToList()
                    
                }
            };
        }



        public void Save()
        {
            throw new NotImplementedException();
        }


    }
}
