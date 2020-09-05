
namespace Application.Games.DTOs
{
    public class GameItemListDTO
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int SlotsCount { get; set; }
        public int SlotsTakenCount { get; set; }
        public int AuthorId { get; set; }
    }
}
