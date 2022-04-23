#nullable disable
using System.Collections.Generic;

namespace EntityDataExample.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Person = new HashSet<Person>();
        }

        public int CountryIdentifier { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}