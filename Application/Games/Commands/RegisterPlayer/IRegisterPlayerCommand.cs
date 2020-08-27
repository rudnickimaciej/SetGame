using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
   public interface IRegisterPlayerCommand
    {
        void Execute(int playerId, int gameId);
    }
}
