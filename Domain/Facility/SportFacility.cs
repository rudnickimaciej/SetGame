namespace Domain.Models
{
    public class SportFacility:Entity
    {
        public virtual FacilityType Type{ get; set; }
        public virtual string  City{ get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Street { get; set; }
    }
}
