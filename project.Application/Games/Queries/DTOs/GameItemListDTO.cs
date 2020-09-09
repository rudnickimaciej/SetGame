
using System;

namespace project.Application.Games
{
    public class GameItemListDto
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public string Discipline { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }

        public string CityName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }

        public int SlotsCount { get; set; }
        public int SlotsTakenCount { get; set; }

        public int AuthorId { get; set; }
        public string  AuthorName { get; set; }
        public string AuthorLastName { get; set; }
       
    }
}
