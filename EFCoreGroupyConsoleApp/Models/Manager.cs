

using System.Collections.Generic;

namespace EFCoreGroupByConsoleApp.Models
{
    public class Manager
    {
        public Employees Employee { get; set; }
        public List<Employees> Workers { get; set; } = new();
    }
}