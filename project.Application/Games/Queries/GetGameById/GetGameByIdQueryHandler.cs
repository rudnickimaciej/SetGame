using System;
using System.Collections.Generic;
using System.Text;
using project.Application.Games;
using project.Application.Interfaces;
using AutoMapper;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace project.Application.Games
{
    public class GetGameByIdQueryHandler : IQueryHandler<GetGameByIdQuery, GameDetailsDto>
    {
        private readonly IDatabaseService _database;
        private readonly IMapper _mapper;
        public GetGameByIdQueryHandler(IDatabaseService database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public GameDetailsDto Handle(GetGameByIdQuery query)
        {

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<GameProfile>();
            //});
            //var game = _database.Games.Find(query.Id);

            var game =_database.Games.Include(g => g.Field.SportFacility).Include(g => g.Discipline).Include(g=>g.Enrollments).FirstOrDefault();
            return _mapper.Map<GameDetailsDto>(game);
        }
    }

    //public class GameProfile : Profile
    //{
    //    public GameProfile()
    //    {
    //        CreateMap<Game, GameDetailsDto>()
    //            .ForMember(
    //            dest => dest.CityName,
    //            opt => opt.MapFrom(src => "TEST"))
    //            .ForMember(
    //            dest => dest.StreetName,
    //            opt => opt.MapFrom(src => src.Field.SportFacility.Street));
    //    }
    //}
}
