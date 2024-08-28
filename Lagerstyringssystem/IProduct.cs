namespace Lagerstyringssystem;

public interface IProduct
{
    string Name { get; set; }
    double Price { get; set; }

    void PrintInfo(); //brukes ikke da jeg ville øve meg på switch og lambda expressions
}