using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataExample.Classes
{
    public enum Occupations
    {

        [Description("Doctor")]
        Doctor = 1,
        [Description("Actor")]
        Actor = 2,
        [Description("Plumber")]
        Plumber = 3
    }
}
