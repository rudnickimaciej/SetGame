
using project.Application.Interfaces;
using System;

namespace Application.Games.Commands
{
    public class AddGameCommand : IAddGameCommand
    {
        private readonly IDatabaseService _database;

        public AddGameCommand(IDatabaseService database)
        {

            _database = database;
        }

        public int Execute(AddGameModel model)
        {
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<AddGameModel, Game>();
            //});
            //IMapper iMapper = config.CreateMapper();
            //var destination = iMapper.Map< AddGameModel, Game> (model);
            //destination.Author = _database.Players.Find(p => p.Id.Equals(model.AuthorId));
            //destination.Field = _database.Fields.FindLast(f => f.Id.Equals(model.FieldId));
            //var result = _database.Games.Add(destination);

            throw new Exception();

        }
    }
}
