using FactoryMethodPattern.Interface;
using FactoryMethodPattern.Loggers;

namespace FactoryMethodPattern;

// responsible for creating the correct logger
public class LoggerFactory : ILoggerFactory
{
    public Logger CreateLogger(LoggerType loggerType)
    {
        ConfigurationFactory configurationFactory = new ConfigurationFactory();
        switch (loggerType)
        {
            case LoggerType.File:
                return new FileLogger(configurationFactory);
                break;
            case LoggerType.Database:
                return new DatabaseLogger(configurationFactory);
                break;
            case LoggerType.Udp:
                return new UdpLogger(configurationFactory);
                break;
            case LoggerType.Console:
                return new ConsoleLogger(configurationFactory);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(loggerType), loggerType, null);
        }
    }
}