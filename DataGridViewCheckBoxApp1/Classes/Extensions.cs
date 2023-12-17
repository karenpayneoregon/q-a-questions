using System.Data;
using System.Reflection;
using DataGridViewCheckBoxApp1.Models;
using FastMember;

namespace DataGridViewCheckBoxApp1.Classes;
internal static class Extensions
{
    public static DataTable ToDataTable<T>(this IEnumerable<T> sender)
    {
        DataTable table = new(typeof(T).Name);
        using var reader = ObjectReader.Create(sender);
        table.Load(reader);
        return table;
    }

    public static List<Product> AllCheckedProducts(this DataTable table)
    {
        return ConvertDataTable<Product>(table);
    }

    public static List<T> ConvertDataTable<T>(this DataTable table) where T : class, new()
    {
        try
        {
            List<T> list = new List<T>();

            foreach (var row in table.AsEnumerable())
            {
                T item = new T();

                foreach (var prop in item.GetType().GetProperties())
                {
                    try
                    {
                        PropertyInfo? propertyInfo = item.GetType().GetProperty(prop.Name);
                        propertyInfo!.SetValue(item, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }

                list.Add(item);
            }

            return list;
        }
        catch
        {
            return null;
        }
    }
}


