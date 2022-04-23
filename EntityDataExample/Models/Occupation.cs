#nullable disable
using System.Collections.Generic;

namespace EntityDataExample.Models
{
    public partial class Occupation
    {
        public Occupation()
        {
            Person = new HashSet<Person>();
        }

        public int OccupationIdentifier { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}