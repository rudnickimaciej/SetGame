﻿using project.Application.Games;
using Application.Players.Queries.GetPlayerDetails;
using AutoMapper;
using project.Application.Interfaces;
using Domain.Models;
using System;
using System.Linq;

namespace project.Application.Games
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
            var source2 = _database.Players.Find(1);
            var source = _database.Games.Where(g => g.Id.Equals(id)).FirstOrDefault();
            var destination = iMapper.Map<Game, GameDetailsDTO>(source);

            return destination;
        }
    }
}
