using Microsoft.Data.SqlClient;


namespace DatabaseSettingsLibrary
{
    public class DataOperations
    {

        public static (bool success, Exception exception) TestConnection()
        {
            try
            {
                using var cn = new SqlConnection(Helpers.ConnectionString());
                cn.Open();
                return (true, null)!;
            }
            catch (Exception localException)
            {
                return (false, localException);
            }


        }
    }
}
