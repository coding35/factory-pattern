namespace FactoryMethodPattern.Loggers;

public class FileLogger : Logger
{
    private readonly Configuration _configurationFactory;
    
    public FileLogger(ConfigurationFactory configurationFactory)
    {
        _configurationFactory =configurationFactory.GetConfiguration(LoggerType.File);
    }

    public override void Log(string message)
    {
        var path = ((FileConfiguration)_configurationFactory).Path;
        Console.WriteLine($"FileLogger Path: {path}");
        Console.WriteLine($"FileLogger: {message}");
    }
}