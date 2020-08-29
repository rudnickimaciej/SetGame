using Domain.Cities;
using Domain.Common;
using Domain.Disciplines;
using Domain.Players;
using Domain.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Fields;

namespace Domain.Games
{
    public class Game : IEntity
    {
        //public Game(Player author, DateTime gameDateTime, int slotsCount,Discipline discipline )
        //{
        //    Author = author;
        //    GameDateTime = gameDateTime;
        //    SlotsCount = slotsCount;
        //    Discipline = discipline;
        //}
        //public Game(Player author, DateTime gameDateTime, int slotsCount, Discipline discipline, List<Player> players)
        //{
        //    Author = author;
        //    GameDateTime = gameDateTime;
        //    SlotsCount = slotsCount;
        //    Discipline = discipline;
        //    Players = players;
        //}

        public int Id { get; set; }
      
        public Field Field { get; set; }
        public DateTime GameDateTime { get; set; }

        public int GameDuration { get; set; }
        public float Price { get; set; }
        public GameStatus Status{ get; set; }
        public Discipline Discipline { get; set; }
        public int SlotsCount { get; set; }
        public Player Author { get; set; }
        public List<Player> Players { get; set; }

        public void AddPlayer(Player player)
        {
           
            if (Players.Where<Player>(p => p.Id.Equals(player.Id)).First<Player>()!=null)
            {
                throw new Exception("This player is already signed up");
            }
            if (Players.Count() == SlotsCount)
            {
                throw new Exception("There are no free slots");
            }

            Players.Add(player);
        }

        public void RemovePlayer(int playerId)
        {
            if(Players.Where<Player>(p => p.Id.Equals(playerId)).First<Player>()== null)
            {
                throw new Exception("There is no such a player signed up to the game");
            }

            Players.Remove(Players.Where<Player>(p => p.Id.Equals(playerId)).First<Player>());
        }

        public void Cancel() => Status = GameStatus.CANCELLED; //todo: notify players




      

    }
}
