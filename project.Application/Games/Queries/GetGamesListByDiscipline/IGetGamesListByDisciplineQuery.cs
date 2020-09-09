using project.Application.Games;
using System.Collections.Generic;


namespace project.Application.Games
{
    public interface IGetGamesListByDisciplineQuery
    {
        List<GameItemListDto> Execute(string discipline);
    }
}
