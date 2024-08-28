namespace CodealongRecipeApp;

public class Recipe
{
    protected List<string> IngredientList;
    public string Name;
    protected string Category;
    protected List<Recipe> Recipes = new List<Recipe>();

    public virtual void MakeDish()
    {
        Console.WriteLine($"Hvordan lage {Name}");
        Console.WriteLine("Ingredienser");
        foreach (var ingredient in IngredientList)
        {
            Console.WriteLine($"{ingredient}");
        }
    }

    
}