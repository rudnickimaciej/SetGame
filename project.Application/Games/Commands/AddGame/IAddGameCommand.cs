using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
   public interface IAddGameCommand:ICommand
    {
        int Execute(AddGameModel model);
    }
}
