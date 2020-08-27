using Application.Games.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Queries
{
    public interface IGetGameDetailsByIdQuery
    {
        GameDetailsDTO Execute(int id);
    }
}
