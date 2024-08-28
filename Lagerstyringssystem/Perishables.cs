namespace Lagerstyringssystem;

public class Perishables : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string BestByDate { get; set; }

    public Perishables(string name, double price, string bestByDate)
    {
        Name = name;
        Price = price;
        BestByDate = bestByDate;
    }
    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}