using Microsoft.Extensions.Configuration;

namespace ConfigurationFormSample.Classes;

public class AppSettings
{
    private static ConfigurationBuilder _configBuilder;
    public static Logging GetLogOptions()
    {
        Build();
        return InitOptions<Logging>("LogOptions");
    }

    public static Role Role()
    {
        Build();
        return InitOptions<Role>("Role");
    }

    public static FormSettings Settings()
    {
        Build();
        return InitOptions<FormSettings>("FormSettings");
    }
    private static IConfigurationRoot Build()
    {
        if (_configBuilder is not null) return _configBuilder.Build();
        _configBuilder = new ConfigurationBuilder();
        _configBuilder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true);
        return _configBuilder.Build();
    }
    public static T InitOptions<T>(string section) where T : new() 
        => Build().GetSection(section).Get<T>();
}