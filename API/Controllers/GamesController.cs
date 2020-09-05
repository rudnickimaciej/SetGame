using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Games.Commands;
using Application.Games.DTOs;
using Application.Games.Queries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : BaseController
    {
  

        private readonly IGetGamesListQuery _getGamesQuery;
        private readonly IGetGamesListByDisciplineQuery _getGamesByDisciplineQuery;
        private readonly IGetGameDetailsByIdQuery _getGamesDetailsQuery;
        private readonly IAddGameCommand _addGameCmd;
        private readonly IDeleteGameCommand _deleteGameCmd;

        public GamesController( IGetGamesListQuery query, IGetGamesListByDisciplineQuery getGamesByDisciplineQuery, IGetGameDetailsByIdQuery getGamesDetailsQuery, IAddGameCommand addGameCmd, IDeleteGameCommand deletGameCmd)
        {


            _getGamesQuery = query;
            _getGamesByDisciplineQuery = getGamesByDisciplineQuery;

            _getGamesDetailsQuery = getGamesDetailsQuery;

            _addGameCmd = addGameCmd;
            _deleteGameCmd = deletGameCmd;
        }
   
        public IEnumerable<GameItemListDTO> GetGames()
        {
            return _getGamesQuery.Execute();
        }


        [HttpGet]
        [Route("{id:int}")]
        public GameDetailsDTO GetGameById(int id)
        {
            return _getGamesDetailsQuery.Execute(id);
        }


        [HttpGet]
        [Route("~/api/disciplines/{discipline:alpha}/games")]
        public IEnumerable<GameItemListDTO> GetGameByDiscipline(string discipline)
        {
            return _getGamesByDisciplineQuery.Execute(discipline);
        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage AddGame([FromBody] AddGameModel game)
        {
            var result = _addGameCmd.Execute(game);

            if(result == 0)
            {
             return new HttpResponseMessage(HttpStatusCode.Created);

            }
            else if( result==1)
            {
                return new HttpResponseMessage();
            }
            return new HttpResponseMessage();

        }


        [HttpDelete]
        [Route("delete/{gameId}")]
        public HttpResponseMessage DeleteGame(int gameId)
        {
            _deleteGameCmd.Execute(gameId);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
    }
}

