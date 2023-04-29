namespace FactoryMethodPattern
{
    // the concept of the factory method pattern is to define an
    // interface for creating an object, but let subclasses decide
    // which class to instantiate. 
    
    // In this case we have a factory method that creates a logger
    // based on the type of logger we want to create as decided upon
    // by the Process subclasses.
    internal static class Program
    {
        static void Main(string[] args)
        {
            Process process2 = new SynchronizeData();
            process2.ProcessData();   
            
            Process process = new Reconciliation();
            process.ProcessData();
        }
    }
}