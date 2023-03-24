using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAdapterFormApp.Extensions
{
    public static class GenericExtensions
    {
        public static List<TSource> ToList<TSource>(this DataTable table) where TSource : new()
        {
            List<TSource> list = new List<TSource>();

            var typeProperties = typeof(TSource).GetProperties().Select(propertyInfo => new
            {
                PropertyInfo = propertyInfo,
                Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
            }).ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {

                TSource current = new TSource();

                foreach (var typeProperty in typeProperties)
                {
                    if (!table.Columns.Contains(typeProperty.PropertyInfo.Name))
                    {
                        continue;
                    }
                    object value = row[typeProperty.PropertyInfo.Name];
                    object safeValue = value is null || DBNull.Value.Equals(value) ?
                        null :
                        Convert.ChangeType(value, typeProperty.Type);

                    typeProperty.PropertyInfo.SetValue(current, safeValue, null);
                }

                list.Add(current);

            }

            return list;
        }
    }
}
