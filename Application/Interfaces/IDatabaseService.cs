using System.Data.Entity;
using Domain.Cities;
using Domain.Disciplines;
using Domain.Games;
using Domain.Players;
using Domain.Fields;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IDatabaseService
    {
        
        //IDbSet<Discipline> Disciplines { get; set; }
        List<City> Cities { get; set; }
        List<Player> Players { get; set; }
        List<Game> Games { get; set; }

        void Save();
    }
}