using FactoryMethodPattern.Loggers;

namespace FactoryMethodPattern.Interface;

public interface ILoggerFactory
{
    Logger CreateLogger(LoggerType loggerType);
}



