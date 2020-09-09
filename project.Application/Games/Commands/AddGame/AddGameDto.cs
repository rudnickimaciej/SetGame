namespace project.Application.Games
{
   public class AddGameDto
    {
        public int FieldId{ get; set; }
        public string GameDateTime { get; set; }
        public int GameDuration { get; set; }
        public float Price { get; set; }    
        public string Discipline { get; set; }
        public int SlotsCount { get; set; }
        public int AuthorId { get; set; }

    }
}
