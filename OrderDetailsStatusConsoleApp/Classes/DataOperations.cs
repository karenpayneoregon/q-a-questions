using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OrderDetailsStatusConsoleApp.Data;
using OrderDetailsStatusConsoleApp.Models;

namespace OrderDetailsStatusConsoleApp.Classes
{
    public class DataOperations
    {
        /// <summary>
        /// Get order detail status for products in an order
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="identifiers">statues</param>
        /// <returns></returns>
        public static List<OrderDetails> OrdersDetailsList(int orderId, int[] identifiers)
        {
            using var context = new NorthContext();
            return context
                .OrderDetails
                .Include(x => x.Product)
                .Include(x => x.Status)
                .Where(x => x.OrderId == orderId && identifiers.Contains(x.Status.StatusId))
                .ToList();
        }
    }
}