using CleanArchitecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
    public class DeleteGameCommand : IDeleteGameCommand
    {
        private readonly IDatabaseService _databaseService;

        public DeleteGameCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void Execute(int id)
        {
            var game = _databaseService.Games.Where(g => g.Id == id).FirstOrDefault();
            _databaseService.Games.Remove(game);

        }
    }
}
