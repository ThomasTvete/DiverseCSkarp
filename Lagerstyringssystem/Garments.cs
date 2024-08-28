namespace Lagerstyringssystem;

public class Garments : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }

    public Garments(string name, double price, string size)
    {
        Name = name;
        Price = price;
        Size = size;
    }
    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}