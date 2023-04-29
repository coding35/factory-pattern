namespace FactoryMethodPattern;

public class ConfigurationFactory
{
    public Configuration GetConfiguration(LoggerType loggerType)
    {
        switch (loggerType)
        {
            case LoggerType.File:
                return new FileConfiguration();
                break;
            case LoggerType.Database:
                return new DatabaseConfiguration();
                break;
            case LoggerType.Console:
                return new ConsoleConfiguration();
                break;
            case LoggerType.Udp:
                return new UdpConfiguration();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(loggerType), loggerType, null);
        }
    }
}

public abstract class Configuration
{
    
}

public class FileConfiguration : Configuration
{
    public FileConfiguration()
    {
        Path = "C:\\Logs\\";
    }
    
    public string Path { get; set; }
}

public class DatabaseConfiguration : Configuration
{
    public DatabaseConfiguration()
    {
        ConnectionString = "localhost:8080";
    }
    
    public string ConnectionString { get; set; }
}

public class UdpConfiguration : Configuration
{
    public UdpConfiguration()
    {
        Host = "localhost";
        Port = "8080";
    }
    
    public string Host { get; set; }
    public string Port { get; set; }
}

public class ConsoleConfiguration : Configuration
{
    public ConsoleConfiguration()
    {
        BackGroundColor = ConsoleColor.Black;
        ForeGroundColor = ConsoleColor.Green;
    }
    
    public ConsoleColor BackGroundColor { get; set; }
    public ConsoleColor ForeGroundColor { get; set; }
}