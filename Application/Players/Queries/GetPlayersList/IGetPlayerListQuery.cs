using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Players.Queries.GetPlayersList
{
    public interface IGetPlayerListQuery
    {
        List<PlayerItemListModel>Execute();
    }
}
