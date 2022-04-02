using System.Collections.Generic;
using System.IO;
using BasicReadWriteJson.Models;
using Newtonsoft.Json;

namespace BasicReadWriteJson.Classes
{
    public class DataOperations
    {
        public static string FileName => "Products.json";

        public static List<Products> ReadProductsList() 
            => JsonConvert.DeserializeObject<List<Products>>(File.ReadAllText(FileName));

        public static void WriteProducts(List<Products> products)
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(products));
        }
    }
}