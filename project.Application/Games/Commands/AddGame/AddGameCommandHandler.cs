using project.Application.Games;
using CSharpFunctionalExtensions;
using Domain.Models;
using project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Games
{
    public class AddGameCommandHandler : ICommandHandler<AddGameCommand>
    {
        private readonly IDatabaseService _database;

        public AddGameCommandHandler(IDatabaseService database)
        {
            _database = database;
        }

        public  Result Handle(AddGameCommand command)
        {
            var result = _database.Games.Add(new Game()
            {
                Field = _database.Fields.Find(command.FieldId),
                Author = _database.Players.Find(command.AuthorId),
                Discipline = new Discipline() { Name = command.Discipline },
                Duration = command.GameDuration,
                Price= command.Price,
                SlotsCount = command.SlotsCount,
                Start=  DateTime.Parse(command.GameDateTime)    
            });

            _database.Save();

            if (result is null) return Result.Failure("Nie udało się dodać gry");
            return Result.Success();
        }
    }
}
