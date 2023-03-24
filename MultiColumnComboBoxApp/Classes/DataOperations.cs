using System.Data;

namespace MultiColumnComboBoxApp.Classes;

public class DataOperations
{
    /// <summary>
    /// Mimic data coming from a database
    /// </summary>
    /// <returns></returns>
    public static DataTable Load()
    {
        DataTable dataTable = new DataTable("Employees");

        dataTable.Columns.Add("EmployeeID", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Designation", typeof(string));

        dataTable.Rows.Add(1, "Natalia", "Developer");
        dataTable.Rows.Add(2, "Jonathan", "Developer");
        dataTable.Rows.Add(3, "Jake", "Developer");
        dataTable.Rows.Add(4, "Abraham", "Developer");
        dataTable.Rows.Add(5, "Mary", "Team Lead");
        dataTable.Rows.Add(6, "Calvin", "Project Manager");
        dataTable.Rows.Add(7, "Sarah", "Team Lead");
        dataTable.Rows.Add(8, "Monica", "Developer");
        dataTable.Rows.Add(9, "Donna", "Developer");
        return dataTable;
    }
}