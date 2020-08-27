using Application.Games.DTOs;
using Application.Players.Queries.GetPlayerDetails;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using Domain.Games;
using Domain.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Game, GameDetailsDTO>()
                .ForMember(dest => dest.CityName, act => act.MapFrom(src => src.Field.City))
                .ForMember(dest => dest.StreetName, act => act.MapFrom(src => src.Field.Street))
                .ForMember(dest => dest.StreetName, act => act.MapFrom(src => src.Field.Street));
                cfg.CreateMap<Player, PlayerDetailsModel>();

            });
            IMapper iMapper = config.CreateMapper();
            var source = _database.Games.Where(g => g.Id == id).FirstOrDefault();
            var destination = iMapper.Map<Game, GameDetailsDTO>(source);


            return destination;
        }
    }
}
