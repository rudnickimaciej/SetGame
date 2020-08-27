using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Games.Commands
{
   public class AddGameModel
    {
        public int SlotsCount { get; set; }
        public int AuthorId { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public int SteetNumber { get; set; }
        public DateTime StartDateTime { get; set; }

    }
}
