using Catan.Loggers;
using Catan.Massages;

namespace Catan.Players;

public class WorkingPlayer : IPlayer
{
    public WorkingPlayer(ILogger logger)
    {
        Logger = logger;
    }

    public ILogger Logger { get; set; }

    public void Play()
    {
        Logger.Log(new WorkingMassage("Player is playing"));
    }
}