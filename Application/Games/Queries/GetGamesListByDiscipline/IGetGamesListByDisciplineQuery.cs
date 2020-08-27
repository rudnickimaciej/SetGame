using Application.Games.DTOs;
using System.Collections.Generic;


namespace Application.Games.Queries
{
    public interface IGetGamesListByDisciplineQuery
    {
        List<GameItemListDTO> Execute(string discipline);
    }
}
