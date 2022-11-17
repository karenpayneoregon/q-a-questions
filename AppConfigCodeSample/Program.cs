using DatabaseSettingsLibrary;

namespace AppConfigCodeSample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            
            var (success, exception) = DataOperations.TestConnection();

            if (success)
            {
                Console.WriteLine("Connected");
            }
            else
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}