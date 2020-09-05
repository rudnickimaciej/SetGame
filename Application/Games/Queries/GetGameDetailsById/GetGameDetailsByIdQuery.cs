using Application.Games.DTOs;
using Application.Players.Queries.GetPlayerDetails;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using Domain.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Application.Games.Queries
{
    public class GetGameDetailsByIdQuery : IGetGameDetailsByIdQuery
    {

        private readonly IDatabaseService _database;

        public GetGameDetailsByIdQuery(IDatabaseService database)
        {
            _database = database;
        }

        public GameDetailsDTO Execute(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Game, GameDetailsDTO>(); 
                cfg.CreateMap<Player, PlayerDetailsDTO>();
               

            });
            IMapper iMapper = config.CreateMapper();
            var source2 = _database.Games.Take(3);
            var source = _database.Games.Where(g => g.Id.Equals(id)).FirstOrDefault();
            var destination = iMapper.Map<Game, GameDetailsDTO>(source);

            return destination;
        }
    }
}
