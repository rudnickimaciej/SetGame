using project.Application.Games;
using AutoMapper;
using project.Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Application.Games
{
    public class GetGamesListByDisciplineQuery : IQuery<List<GameItemListDto>>
    {

        public GetGamesListByDisciplineQuery(string discipline, int count=10)
        {
            this.Discipline = discipline;
            this.Count = count;
        }

        public string Discipline { get; set; }
        public int Count { get; set; }


    }
}
