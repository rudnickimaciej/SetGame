using project.Application.Interfaces;

namespace project.Application.Games
{
    public class RegisterPlayerCommand : ICommand
    {
        public RegisterPlayerCommand(int playerId, int gameId)
        {
            PlayerId = playerId;
            GameId = gameId;
        }

        public int PlayerId { get; set; }
        public int GameId { get; set; }

    }
}
