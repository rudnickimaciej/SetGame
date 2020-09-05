using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Players.Queries.GetPlayerDetails
{
    public interface IGetPlayerDetailsQuery
    {
        PlayerDetailsDTO Execute(int id);
    }
}
