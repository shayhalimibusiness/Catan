using Catan.Massages;

namespace Catan.Loggers;

public interface ILogger
{
    void Log(IMassage massage);
}