using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Players.Queries.GetPlayerDetails
{
    public class GetPlayerDetailsQuery : IGetPlayerDetailsQuery
    {
        //private readonly IDatabaseService _database;

        //public GetPlayerDetailsQuery(IDatabaseService database)
        //{
        //    _database = database;
        //}

        public PlayerDetailsDTO Execute(int id)
        {
            throw new NotImplementedException();
        }
    }
}
