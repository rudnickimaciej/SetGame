using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using project.Application.Interfaces;
using project.Application;
using project.Application.Games;
using AutoMapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : BaseController
    {
        private readonly Messages _messages;

        private readonly IDatabaseService _database;

        private readonly IMapper _mapper;


        public GamesController(Messages messages, IDatabaseService database, IMapper mapper) 
        { 
            _messages = messages;
            _database = database;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetGames(int count=10)
        {
            return Ok(_messages.Dispatch<List<GameItemListDto>>(new GetGameListQuery(count)));    
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetGameById(int id)
        {
            var game = _messages.Dispatch<GameDetailsDto>(new GetGameByIdQuery(id));

            if (game == null) return NotFound();

            return Ok(game);
        }


        [HttpGet]
        [Route("~/api/disciplines/{discipline:alpha}/games")]
        public IActionResult GetGameByDiscipline(string discipline)
        {
            //TODO: sprawdzić czy discipline istnieje
            return Ok(_messages.Dispatch<List<GameItemListDto>>(new GetGamesListByDisciplineQuery(discipline)));
        }


        [HttpPost]
        [Route("add")]
        public IActionResult AddGame([FromBody] AddGameDto dto)
        {

            var command = new AddGameCommand(
                dto.FieldId,
                dto.GameDateTime,
                dto.GameDuration,
                dto.Price,
                dto.Discipline,
                dto.SlotsCount,
                dto.AuthorId
                );
            Result result= _messages.Dispatch(command);
            return result.IsSuccess ? Ok() : Error(result.Error);
        }


        //[HttpPut]
        //[Route("update/{id:int}")]
        //public async Task<IActionResult> PutGame([FromBody] UpdateGameModel game)
        //{
        //    if (id != samurai.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(samurai).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SamuraiExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        [HttpDelete]
        [Route("delete/{gameId}")]
        public HttpResponseMessage DeleteGame(int gameId)
        {
          
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpPost]
        [Route("games/{gameId}/register")]
        public IActionResult RegisterPlayer(int gameId, int playerId)
        {
            var command = new RegisterPlayerCommand(playerId, gameId);
            var result = _messages.Dispatch(command);

            return result.IsSuccess ? Ok() : Error(result.Error);
        }
    }
}

