using project.Application.Games;
using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Games
{
    public class GetGameListQuery:IQuery<List<GameItemListDto>>
    {
        public GetGameListQuery(int count)
        {
            Count = count;
        }

        public int Count { get;  }
        
    }
}
