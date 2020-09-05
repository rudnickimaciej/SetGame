using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class Player : Entity
    {
        public Player()
        {
        }

        public Player(string name, string lastName, Gender gender):this()
        {
            Name = name;
            LastName = lastName;
            Gender = gender;
        }

        public  string Name { get; set; }
        public  string LastName { get; set; }

        public  Gender Gender { get;set; }

        private readonly IList<Game> _games = new List<Game>();


        private readonly IList<GameEnrollment> _enrollments = new List<GameEnrollment>();
        public virtual IReadOnlyCollection<GameEnrollment> Enrollments => _enrollments.ToList();
    }

}
