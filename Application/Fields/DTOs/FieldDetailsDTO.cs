using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fields.DTOs
{
    public class FieldDetailsDTO
    {
        public long FieldID { get; set; }
        public string FieldType { get; set; }
        public string FacilityName { get; set; }
        public string FacilityType { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
    }
}
