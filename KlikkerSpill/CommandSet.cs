namespace KlikkerSpill;

public class CommandSet
{
    private ICommand[] _commands;
    public CommandSet(ClickerGame game)
    {

     _commands = new ICommand[]
    {
        new PointsIncreaseCommand(game),
        new PointsUpgradeCommand(game),
        new UpgradeIncreaseCommand(game),
        new ExitCommand()
    };
}

public void RunCommand(char command)
    {
        foreach (var commando in _commands)
        {
            if(commando.Command == command)commando.Run();
        }
    }
}