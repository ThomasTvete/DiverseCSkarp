namespace KlikkerSpill;

public class PointsUpgradeCommand : ICommand
{
    public char Command { get; } = 'k';
    private ClickerGame _game;

    public PointsUpgradeCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.PointsUpgrade();
    }
}