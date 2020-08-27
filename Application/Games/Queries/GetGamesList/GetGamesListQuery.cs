using Application.Games.DTOs;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using Domain.Games;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Application.Games.Queries
{
    public class GetGamesListQuery : IGetGamesListQuery
    {
        private readonly IDatabaseService _database;

        public GetGamesListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<GameItemListDTO> Execute()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<List<Game>, List<GameItemListDTO>>();
            });
            IMapper iMapper = config.CreateMapper();
            var source = _database.Games.ToList();
            var destination = iMapper.Map<List<Game>, List<GameItemListDTO>>(source);
            return destination;

        }
    }
}
