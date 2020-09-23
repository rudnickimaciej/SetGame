using project.Application.Interfaces;
using project.Application.Games;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace project.Application.Games
{
    public class RegisterPlayerCommandHandler : ICommandHandler<RegisterPlayerCommand>
    {
        private readonly IDatabaseService _database;

        public RegisterPlayerCommandHandler(IDatabaseService database)
        {
            _database = database;
        }

        public Result Handle(RegisterPlayerCommand command)
        {
            var player = _database.Players.Find(command.PlayerId);
            var game = _database.Games.Find(command.GameId);

            if (player != null && game != null)
                game.RegisterPlayer(player);
            return Result.Success();
        }
    }
}
