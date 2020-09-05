using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Games.Commands
{
   public interface IUpdateGameCommand
    {
        void Execute(UpdateGameModel model, int gameId);
    }
}
