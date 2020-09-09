using project.Application.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Application.Games
{
    public interface IGetGameDetailsByIdQuery
    {
        GameDetailsDTO Execute(int id);
    }
}
