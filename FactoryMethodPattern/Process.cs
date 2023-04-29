using FactoryMethodPattern.Interface;
using FactoryMethodPattern.Loggers;

namespace FactoryMethodPattern;

public abstract class Process
{
    public abstract void ProcessData();
}

public class Reconciliation : Process
{
    private readonly ILoggerFactory _loggerFactory = new LoggerFactory();
    private readonly Logger _logger;
    public Reconciliation()
    {
        _logger = _loggerFactory.CreateLogger(LoggerType.Console);
    }
    
    public override void ProcessData()
    {
        _logger.Log("Reconciliation Process Started");
    }
}

public class SynchronizeData : Process
{
    private readonly ILoggerFactory _loggerFactory = new LoggerFactory();
    private readonly Logger _logger;
    public SynchronizeData()
    {
        _logger = _loggerFactory.CreateLogger(LoggerType.Udp);
    }
    public override void ProcessData()
    {
        _logger.Log("Synchronize Data Process Started");
    }
}
