namespace FactoryMethodPattern.Loggers;

public class DatabaseLogger : Logger
{
    private readonly Configuration _configurationFactory;
    
    public DatabaseLogger(ConfigurationFactory configurationFactory)
    {
        _configurationFactory = configurationFactory.GetConfiguration(LoggerType.Database);
    }

    public override void Log(string message)
    {
        var connectionString = ((DatabaseConfiguration)_configurationFactory).ConnectionString;
        Console.WriteLine($"DatabaseLogger ConnectionString: {connectionString}");
        Console.WriteLine($"DatabaseLogger: {message}");
    }
}