namespace Domain.Models
{
    public class GameEnrollment:Entity
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
    }
}
