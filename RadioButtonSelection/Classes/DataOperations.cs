using System.Collections.Generic;

namespace RadioButtonSelection.Classes
{
    public class DataOperations
    {
        public static readonly Dictionary<int, int> FeeDictionary = new Dictionary<int, int>()
        {
            [0] = 595,
            [1] = 695,
            [2] = 995,
            [3] = 1295,
            [4] = 395
        };
    }
}
