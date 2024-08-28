using System.Security.Cryptography.X509Certificates;

namespace KlikkerSpill;

public class PointsIncreaseCommand : ICommand
{
    public char Command { get; } = ' ';
    private ClickerGame _game;

    public PointsIncreaseCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.PointsIncrease();
    }
}