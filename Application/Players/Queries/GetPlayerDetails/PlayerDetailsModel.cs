using Domain.Players;

namespace Application.Players.Queries.GetPlayerDetails
{
    public class PlayerDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
    }
}