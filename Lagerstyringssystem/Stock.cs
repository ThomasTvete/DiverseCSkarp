namespace Lagerstyringssystem;

public class Stock
{
    private List<IProduct> _inStock;

    public Stock()
    {
        _inStock = new List<IProduct>();
    }

    public void AddToStock(IProduct product)
    {
        _inStock.Add(product);
    }

    public void RemoveFromStock(string name)
    {
        IProduct item = _inStock.Where(x => x.Name == name).FirstOrDefault();
        _inStock.Remove(item);
    }

    public void PrintProducts()
    {
        foreach (var product in _inStock)
        {
            string varInfo = GetUniqueInfo(product);
            Console.WriteLine($"{product.Name} koster {product.Price} og {varInfo}");
        }
    }

    private string GetUniqueInfo(IProduct product) => product switch
    {
        Electronics electro => $"har {electro.MonthsOfWarranty} måneder med garantitid",
        Perishables food => $"går ut på dato {food.BestByDate}",
        Garments clothes => $"er i størrelse {clothes.Size}",
        _ => $"eksisterer ikke"
    };
}