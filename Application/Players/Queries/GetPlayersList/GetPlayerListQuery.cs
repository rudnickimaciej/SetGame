using CleanArchitecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Players.Queries.GetPlayersList
{
    public class GetPlayerListQuery : IGetPlayerListQuery
    {
        private readonly IDatabaseService _database;

        public GetPlayerListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<PlayerItemListModel> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
