using System;

namespace project.Application.Games.Commands
{
   public class UpdateGameModel
    {
        public DateTime Start { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public int DisciplineId { get; set; }
        public int SlotsCount { get; set; }
        public int AuthorId { get; set; }
        public int FieldId { get; set; }

    }
}
