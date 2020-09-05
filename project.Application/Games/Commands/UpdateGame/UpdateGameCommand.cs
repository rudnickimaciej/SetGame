using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Games.Commands
{
    public class UpdateGameCommand : IUpdateGameCommand
    {
        private readonly IDatabaseService _database;

        public UpdateGameCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(UpdateGameModel model, int gameId)
        {
            var game = _database.Games.Find(gameId);
          //  if(game==null) return
           
            throw new NotImplementedException();
        }
    }
}
