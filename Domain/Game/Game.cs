using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Domain.Models
{
    public class Game : Entity
    {
        public Game()
        {
        }
       
        public  DateTime Start { get; set; }
        public  int Duration { get; set; }
        public  float Price { get; set; }
        public virtual GameStatus Status { get; set; }
        public virtual  Discipline Discipline { get; set; }
        public  int SlotsCount { get; set; }
        public virtual Player Author { get; set; }
        public virtual Field Field { get; set; }




        private readonly IList<GameEnrollment> _enrollments = new List<GameEnrollment>();
        public virtual IReadOnlyList<GameEnrollment> Enrollments => _enrollments.ToList();

        public void AddPlayer(GameEnrollment player)
        {

            if (Enrollments.Where<GameEnrollment>(p => p.Id.Equals(player.Id)).First<GameEnrollment>() != null)
            {
                throw new Exception("This player is already signed up");
            }
            if (Enrollments.Count() == SlotsCount)
            {
                throw new Exception("There are no free slots");
            }

            _enrollments.Add(player);
        }

        public void RemovePlayer(int playerId)
        {
            if (Enrollments.Where<GameEnrollment>(p => p.Id.Equals(playerId)).First<GameEnrollment>() == null)
            {
                throw new Exception("There is no such a player signed up to the game");
            }

            _enrollments.Remove(Enrollments.Where<GameEnrollment>(p => p.Id.Equals(playerId)).First<GameEnrollment>());
        }

       // public void Cancel() => Status = GameStatus.CANCELLED; //todo: notify players
    }
}
