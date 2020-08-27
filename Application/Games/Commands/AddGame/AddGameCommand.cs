using CleanArchitecture.Application.Interfaces;
using Domain.Games;
using Domain.Players;
using System;

namespace Application.Games.Commands
{
    public class AddGameCommand : IAddGameCommand
    {
        private readonly IDatabaseService _database;

        public AddGameCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(AddGameModel model)
        {
           
              

        }
    }
}
