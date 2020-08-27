using Application.Games.DTOs;
using System.Collections.Generic;


namespace Application.Games.Queries
{
    public interface IGetGamesListQuery
    {
        List<GameItemListDTO> Execute();
    }
}
