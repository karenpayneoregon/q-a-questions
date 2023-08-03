using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAdapterFormApp.Classes
{
    internal class ExcelOperations
    {
        /// <summary>
        /// Save <see cref="DataTable"/> to an Excel file, in this case the 4th column is a Date so we
        /// need to format this column using a <see cref="SLStyle"/>
        /// <para></para>
        /// The data will start at A1
        /// <para></para>
        /// Usage
        /// <para></para>
        /// var (success, exception) = ExcelOperations.Export(dt, "SomeFile.xlsx");
        /// </summary>
        /// <param name="table">DataTable to import into a new Excel file</param>
        /// <param name="fileName">File name to save data</param>
        /// <returns>
        /// Success and Exception
        /// <para></para>
        /// When no errors, success is true and exception will be null, if not success, exception will
        /// contain the runtime exception
        /// </returns>
        public static (bool success, Exception exception) Export(DataTable table, string fileName)
        {
            try
            {
                using (var document = new SLDocument())
                {
                    SLStyle dateStyle = document.CreateStyle();
                    dateStyle.FormatCode = "mm-dd-yyyy";

                    // start at A1
                    document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);

                    document.SetColumnStyle(4, dateStyle);
                    
                    // auto size columns
                    var stats = document.GetWorksheetStatistics();
                    for (int index = 0; index < stats.EndColumnIndex +1; index++)
                    {
                        document.AutoFitColumn(index);
                    }

                    document.SaveAs(fileName);

                    return (true, null);
                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }

        public static (bool success, Exception exception) InsertColumnData(string fileName, int row, int column, List<string> list)
        {
            try
            {
                using (var document = new SLDocument(fileName, "Sheet1"))
                {
                    for (int index = 0; index < list.Count; index++)
                    {
                        document.SetCellValue(SLConvert.ToCellReference(row, column), list[index]);
                        
                        row++;
                    }

                    document.Save();

                    return (true, null);
                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
    }
}
