using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SqlServerAsyncReadCore.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Split sender by an int value
        /// </summary>
        /// <typeparam name="T">source type</typeparam>
        /// <param name="enumerable">source to chunk</param>
        /// <param name="chunkSize">How many items per chunk</param>
        public static IEnumerable<IEnumerable<T>> ToChunks<T>(this IEnumerable<T> enumerable, int chunkSize)
        {
            int itemsReturned = 0;
            var list = enumerable.ToList(); // Prevent multiple execution of IEnumerable.
            int count = list.Count;

            while (itemsReturned < count)
            {
                int currentChunkSize = Math.Min(chunkSize, count - itemsReturned);
                yield return list.GetRange(itemsReturned, currentChunkSize);
                itemsReturned += currentChunkSize;
            }
        }
    }

    public class SequenceHelper
    {
        /// <summary>
        /// Given a string which ends with a number, increment the number by 1
        /// </summary>
        /// <param name="sender">string ending with a number</param>
        /// <returns>string with ending number incremented by 1</returns>
        public static string NextValue(string sender)
        {
            string value = Regex.Match(sender, "[0-9]+$").Value;
            return sender[..^value.Length] + (long.Parse(value) + 1)
                .ToString().PadLeft(value.Length, '0');
        }
        /// <summary>
        /// Given a string which ends with a number, increment the number by  <seealso cref="incrementBy"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="incrementBy">increment by</param>
        /// <returns>string with ending number incremented by <seealso cref="incrementBy"/></returns>
        public static string NextValue(string sender, int incrementBy)
        {
            string value = Regex.Match(sender, "[0-9]+$").Value;
            return sender[..^value.Length] + (long.Parse(value) + incrementBy)
                .ToString().PadLeft(value.Length, '0');
        }
    }

    public class DataHelper
    {
        /// <summary>
        /// Create delimited text files from <see cref="dataTable"/>
        /// </summary>
        /// <param name="dataTable">DataTable with rows</param>
        /// <param name="useHeader">Include column headers</param>
        /// <param name="chunkSize">How many rows per file</param>
        /// <param name="fileName">Initial files name e.g. File1, .txt will be appended</param>
        /// <param name="delimited">Character to delimit with</param>
        public static void DataTableToFiles(DataTable dataTable, bool useHeader, int chunkSize, string fileName, string delimited = ",")
        {
            var headers = string.Join(delimited, dataTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName));

            IEnumerable<DataTable> tables = dataTable.AsEnumerable().ToChunks(chunkSize)
                .Select(rows => rows.CopyToDataTable());

            
            foreach (var table in tables)
            {
                
                List<string> lines = table.Rows.Cast<DataRow>().Select(row => string.Join(delimited, row.ItemArray)).ToList();

                if (useHeader)
                {
                    lines.Insert(0, headers);
                }
                
                File.WriteAllLines(fileName + ".txt", lines);
                fileName = SequenceHelper.NextValue(fileName);
            }
        }
    }
}
