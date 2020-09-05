using Application.Games.DTOs;
using AutoMapper;
using Domain.Models;
using project.Application.Interfaces;
using System;
using System.Collections.Generic;


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
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Game, GameItemListDTO>();
            //});
            //IMapper iMapper = config.CreateMapper();
            //var source = _database.Games.ToList();
            //var destination = iMapper.Map<List<Game>, List<GameItemListDTO>>(source);
            //return destination;
            _database.Players.Add(new Player() { Name = "Maciek" });
            _database.Save();
            var player = _database.Players.Find(1);
            throw new Exception();

        }
    }
}
