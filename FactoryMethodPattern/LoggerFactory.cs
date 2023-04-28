using FactoryMethodPattern.Interface;
using FactoryMethodPattern.Loggers;

namespace FactoryMethodPattern;

// responsible for creating the correct logger
public class LoggerFactory : ILoggerFactory
{
    public Logger CreateLogger(LoggerType loggerType)
    {
        switch (loggerType)
        {
            case LoggerType.File:
                return new FileLogger();
                break;
            case LoggerType.Database:
                return new DatabaseLogger();
                break;
            case LoggerType.Udp:
                return new UdpLogger();
                break;
            case LoggerType.Console:
                return new ConsoleLogger();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(loggerType), loggerType, null);
        }
    }
}