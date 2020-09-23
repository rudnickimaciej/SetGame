using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Players.Queries.GetPlayerDetails;
using AutoMapper;
using Domain.Models;
using project.Application.Games;

namespace project.API.Profiles
{

    public class GameProfile : Profile
    {
        
        public GameProfile()
        {
            CreateMap<Player, PlayerDetailsDTO>();
            CreateMap<Game, GameDetailsDto>()
                .ForMember(
                dest => dest.CityName,
                opt => opt.MapFrom(src => src.Field.SportFacility.City))
                .ForMember(
                dest => dest.StreetName,
                opt => opt.MapFrom(src => src.Field.SportFacility.Street))
              .ForMember(
                dest => dest.Discipline,
                opt => opt.MapFrom(src => src.Discipline.Name));

        }
    }


}
