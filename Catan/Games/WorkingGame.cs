using Catan.Loggers;
using Catan.Massages;
using Catan.Players;

namespace Catan.Games;

public class WorkingGame : IGame
{
    public WorkingGame(ILogger logger, IPlayer player)
    {
        Logger = logger;
        Player = player;
    }

    public ILogger Logger { get; set; }

    public IPlayer Player { get; set; }
    public void Play()
    {
        Logger.Log(new WorkingMassage("Game starts."));
        Player.Play();
    }
}