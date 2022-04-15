using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundWorker1
{
    public class BackgroundWorkerCustom : BackgroundWorker
    {
        /// <summary>
        /// Identifier 
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Indicates an instance was cancelled, for demo purposes only
        /// </summary>
        public bool Cancelled { get; set; }
    }
}
