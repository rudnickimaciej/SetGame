

namespace project.Application.Games.Commands
{
    class UnregisterPlayerCommand : IUnregisterPlayerCommand
    {
        //private readonly IDatabaseService _database;

        //public UnregisterPlayerCommand(IDatabaseService database)
        //{
        //    _database = database;
        //}

        public void Execute(int gameId, int playerId)
        {
            //var game = _database.Games.Where(g => g.Id == gameId).FirstOrDefault();
            //var player = _database.Players.Where(p => p.Id == playerId).FirstOrDefault();

            //game.RemovePlayer(playerId);
        }
    }
}
