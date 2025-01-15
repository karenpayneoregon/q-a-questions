using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace DemoApp.Classes
{
    public static class GenericExtensions
    {
        public static DataTable ToDataTable<T>(this IList<T> list) 
            => (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(list), (typeof(DataTable)));
    }
}