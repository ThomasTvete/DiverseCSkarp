using Lagerstyringssystem;

Stock warehouse = new Stock();
warehouse.AddToStock(new Electronics("Siemens kjøleskap", 3999.99, 32));
warehouse.AddToStock(new Electronics("Electrolux stekeovn", 7999.99, 48));
warehouse.AddToStock(new Perishables("Cottage Cheese", 31.99, "23/06/2024"));
warehouse.AddToStock(new Perishables("Tunfisk", 13.90, "15/07/2025"));
warehouse.AddToStock(new Garments("Tufte boxer", 199.00, "XL"));
warehouse.AddToStock(new Garments("Dressmann t-skjorte", 299.99, "4XL"));

warehouse.RemoveFromStock("Tunfisk");

warehouse.PrintProducts();
