using project.Application.Games;
using AutoMapper;
using Domain.Models;
using System.Data.SqlClient;
using Dapper;
using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace project.Application.Games
{
    public class GetGameListQueryHandler : IQueryHandler<GetGameListQuery, List<GameItemListDto>>
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public GetGameListQueryHandler(IConfiguration configuration, IMapper mapper)
        {
            _mapper = mapper;
            _configuration = configuration;
        }

        public List<GameItemListDto> Handle(GetGameListQuery query)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Game, GameItemListDto>();
            });

            IMapper iMapper = config.CreateMapper();


            // var destination = iMapper.Map<IQueryable<Game>, List<GameItemListDto>> (source);


            //var gamesDto = new List<GameItemListDto>(); //TODO: USE AUTOMAPPER
            //games.ForEachAsync(g=>games)

            string sql = @"
                    SELECT TOP (@Count) g.Id as [Id], g.Start as [Start], g.Duration as [Duration], g.Price as [Price], gs.Status as [Status], d.Name as [Discipline], g.SlotsCount as [SlotsCountTaken], p.Id as [AuthorId], p.Name as [AuthorName], p.LastName as [AuthorLastName],sf.City as [CityName],sf.Street as [StreetName] FROM dbo.Games g
                    LEFT JOIN dbo.GameStatus gs ON g.StatusId=gs.Id
                    LEFT JOIN dbo.Disciplines d ON g.DisciplineId = d.Id
                    LEFT JOIN dbo.Players p ON g.AuthorId = p.Id
                    LEFT JOIN dbo.Fields f ON g.FieldId = f.Id
                    LEFT JOIN dbo.SportFacilities sf ON f.SportFacilityId = sf.Id";

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SoccerConnectionRead")))
            {
                List<GameItemListDto> games = connection
                    .Query<GameItemListDto>(sql, new
                    {
                        Count = query.Count
                    })
                    .ToList();

                return games;
            }
        }
    }
}

