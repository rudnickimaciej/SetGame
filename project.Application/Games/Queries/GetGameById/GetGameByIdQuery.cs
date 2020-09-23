using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Games
{
    public class GetGameByIdQuery:IQuery<GameDetailsDto>
    {
        public GetGameByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
