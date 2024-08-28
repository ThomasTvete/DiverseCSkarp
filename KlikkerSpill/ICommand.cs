namespace KlikkerSpill;

public interface ICommand
{
    char Command { get; }
    void Run();
}