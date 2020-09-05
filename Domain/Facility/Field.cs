
namespace Domain.Models
{
    public class Field : Entity
    {
        public virtual SportFacility SportFacility { get; set; }
        public virtual FieldType FieldType { get; set; }

    }

}