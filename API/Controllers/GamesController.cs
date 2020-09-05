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
        public ActionResult<GameDetailsDTO> GetGameById(int id)
        {
            var game = _getGamesDetailsQuery.Execute(id);
            if (game==null) return BadRequest("Nie ma gry o takim id");

            return game;
        }


        [HttpGet]
        [Route("~/api/disciplines/{discipline:alpha}/games")]
        public ActionResult<IEnumerable<GameItemListDTO>> GetGameByDiscipline(string discipline)
        {
          //TODO: sprawdzić czy discipline istnieje
            return _getGamesByDisciplineQuery.Execute(discipline);
        }


        [HttpPost]
        [Route("add")]
        public ActionResult<GameDetailsDTO> AddGame([FromBody] AddGameModel game)
        {
            var newGameId = _addGameCmd.Execute(game);

            if (newGameId!>0)
            {
                return  BadRequest("Nie udało się stworzyć gry");

            }
            else
            {
                return CreatedAtAction("GetGame", new { id = newGameId });
            };


        }
        [HttpPut]
        [Route("update/{id:int}")]
        public async Task<IActionResult> PutGame([FromBody] UpdateGameModel game)
        {
            if (id != samurai.Id)
            {
                return BadRequest();
            }

            _context.Entry(samurai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamuraiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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

