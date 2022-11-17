using Microsoft.Extensions.Configuration;

namespace DatabaseSettingsLibrary
{
    public class Helpers
    {
        public static string ConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var sections = configuration.GetSection("database").GetChildren().ToList();
            return sections[0].Value;
        }
    }
}