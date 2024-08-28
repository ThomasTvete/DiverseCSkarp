namespace Lagerstyringssystem;

public class Electronics : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int MonthsOfWarranty { get; set; }

    public Electronics(string name, double price, int monthsOfWarranty)
    {
        Name = name;
        Price = price;
        MonthsOfWarranty = monthsOfWarranty;
    }
    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}