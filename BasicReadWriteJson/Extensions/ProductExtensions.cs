using BasicReadWriteJson.Models;

namespace BasicReadWriteJson.Extensions
{
    public static class ProductExtensions
    {
        public static void UnitsInStockUpDown(this Products sender, bool up = true)
        {
            if (up)
            {
                sender.UnitsInStock += 1;
            }
            else
            {
                sender.UnitsInStock -= 1;
            }
        }
    }
}