using Catan.Massages;

namespace Catan.Loggers;

public class WorkingLogger : ILogger
{
    public void Log(IMassage massage)
    {
        Console.WriteLine(massage);
    }
}