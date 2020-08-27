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
    public class GetGamesListByDisciplineQuery : IGetGamesListByDisciplineQuery
    {
        private readonly IDatabaseService _database;

        public GetGamesListByDisciplineQuery(IDatabaseService database)
        {

            _database = database;
        }

        public List<GameItemListDTO> Execute(string discipline)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<List<Game>, List<GameItemListDTO>>();
            });
            IMapper iMapper = config.CreateMapper();
            var source = _database.Games.Where<Game>(g=>g.Discipline.ToString().Equals(discipline,StringComparison.OrdinalIgnoreCase)).ToList();
            var destination = iMapper.Map<List<Game>, List<GameItemListDTO>>(source);
            return destination;

        }
    }
}
