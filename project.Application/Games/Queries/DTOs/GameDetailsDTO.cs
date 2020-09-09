using Application.Players.Queries.GetPlayerDetails;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Application.Games
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
        public PlayerDetailsDTO Author{ get; set; }
        public List<PlayerDetailsDTO> Players{ get; set; }
    }

}
