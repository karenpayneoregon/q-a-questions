using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListExample.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Force each implementer to override ToString
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    }
}
