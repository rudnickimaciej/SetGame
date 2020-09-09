using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Domain.Models;
using Dapper;
using System.Linq;
namespace project.Application.Games
{
    public class GetGamesListByDisciplineQueryHandler : IQueryHandler<GetGamesListByDisciplineQuery, List<GameItemListDto>>
    {
 
        private readonly IConfiguration _configuration;
        public GetGamesListByDisciplineQueryHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<GameItemListDto> Handle(GetGamesListByDisciplineQuery query)
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
                    LEFT JOIN dbo.SportFacilities sf ON f.SportFacilityId = sf.Id
                        WHERE d.Name=@Discipline";

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("SoccerConnectionRead")))
            {
                
                List<GameItemListDto> games = connection
                    .Query<GameItemListDto>(sql, new
                    {
                        Count = query.Count,
                        Discipline = query.Discipline
                    })
                    .ToList();

                return games;
            }
        }
    }
}
