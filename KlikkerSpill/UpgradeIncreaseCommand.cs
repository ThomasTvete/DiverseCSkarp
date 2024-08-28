namespace KlikkerSpill;

public class UpgradeIncreaseCommand : ICommand
{
    public char Command { get; } = 's';
    private ClickerGame _game;

    public UpgradeIncreaseCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.UpgradeIncrease();
    }
}