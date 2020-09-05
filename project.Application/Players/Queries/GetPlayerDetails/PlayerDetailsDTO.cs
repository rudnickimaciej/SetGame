
using Domain.Models;

namespace Application.Players.Queries.GetPlayerDetails
{
    public class PlayerDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Gender Sex { get; set; }
    }
}