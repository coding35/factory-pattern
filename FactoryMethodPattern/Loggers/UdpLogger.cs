namespace FactoryMethodPattern.Loggers;

public class UdpLogger : Logger
{
    private readonly Configuration _configurationFactory;
    
    public UdpLogger(ConfigurationFactory configurationFactory)
    {
        _configurationFactory = configurationFactory.GetConfiguration(LoggerType.Udp);
    }

    public override void Log(string message)
    {
        var configuration = (UdpConfiguration)_configurationFactory;
        Console.WriteLine($"UdpLogger: Host {configuration.Host}:{configuration.Port}");
        Console.WriteLine($"UdpLogger: {message}");
    }
}