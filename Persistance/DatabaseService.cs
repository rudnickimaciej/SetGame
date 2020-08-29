using CleanArchitecture.Application.Interfaces;
using Domain.Cities;
using Domain.Disciplines;
using Domain.Fields;
using Domain.Games;
using Domain.Players;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DatabaseService : IDatabaseService, 
    {
       
        //public IDbSet<Discipline> Disciplines { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<City> Cities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Player> Players { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Game> Games { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Field> Fields{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void Save()
        {
            throw new NotImplementedException();
        }


    }
}
