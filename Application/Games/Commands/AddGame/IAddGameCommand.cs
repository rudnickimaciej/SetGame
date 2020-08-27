using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
   public interface IAddGameCommand
    {
        void Execute(AddGameModel model);
    }
}
