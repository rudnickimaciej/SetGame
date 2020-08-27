using CleanArchitecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
    public class RegisterPlayerCommand : IRegisterPlayerCommand
    {
        private readonly IDatabaseService _database;
        public void Execute(int playerId, int gameId)
        {
            var game = _database.Games.Where(g => g.Id == gameId).FirstOrDefault();
            var player = _database.Players.Where(p => p.Id == playerId).FirstOrDefault();

            game.AddPlayer(player);
        }
    }
}
