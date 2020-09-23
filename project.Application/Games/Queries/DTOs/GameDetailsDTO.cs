using Application.Players.Queries.GetPlayerDetails;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Application.Games
{
    public class GameDetailsDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }

        public DateTime Start { get; set; }
        public int Duration { get; set; }
        public float Price { get; set; }

        public string Status { get; set; }
        public string Discipline { get; set; }
        public int SlotsCount { get; set; }
        public List<PlayerDetailsDTO> Players{ get; set; }
    }

}
