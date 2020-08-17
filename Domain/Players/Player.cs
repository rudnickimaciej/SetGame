using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Players
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public  Sex Sex { get;set; }

    }

    public enum Sex
    {
        Male=0,
        Female = 1
    }
}
