namespace WinFormsApp1;

public static class Extensions
{
    public static bool IsNull1(this object sender) 
        => sender == null || sender == DBNull.Value || Convert.IsDBNull(sender);
}