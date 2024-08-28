namespace KlikkerSpill;

public class ExitCommand : ICommand
{
    public char Command { get; } = 'x';
    public void Run()
    {
        Environment.Exit(0);
    }
}