using Application.Players.Queries.GetPlayerDetails;
using Domain.Disciplines;
using Domain.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.DTOs
{
    public class GameDetailsDTO
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }

        public DateTime GameDateTime { get; set; }
        public int GameDuration { get; set; }
        public float Price { get; set; }

        public GameStatus Status { get; set; }
        public Discipline Discipline { get; set; }

        public int SlotsCount { get; set; }
        public PlayerDetailsModel Author{ get; set; }
        public List<PlayerDetailsModel> Players{ get; set; }
    }


    public class GameDetailsModelComplex
    {

    }
}
