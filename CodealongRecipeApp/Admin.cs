using System.Threading.Channels;

namespace CodealongRecipeApp;

public class Admin
{
    protected List<Recipe> Recipes = new List<Recipe>();

    public void Run()
    {
        Console.WriteLine("Velkommen til dine oppskrifter");
        Console.WriteLine("Velg ett tall:");
        Console.WriteLine("1. Se alle oppskrifter");
        Console.WriteLine("2. Se alle kategorier");
        Console.WriteLine("3. Søk etter ingrediens");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        MenuChoice(userChoice);
    }

    public void MenuChoice(int userChoice)
    {
        switch (userChoice)
        {
            case 1: ChooseRecipes();
                break;
            case 2: SeeCategories();
                break;
            case 3: IngredientSearch();
                break;
            default: Console.WriteLine("Velg ett gyldig tall");
                Run();
                break;
        }
    }

    public void ChooseRecipes()
    {
        for (int i = 0; i < Recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Recipes[i].Name}");
        }

        string input = Console.ReadLine().ToLower();
        Recipe validInput = Recipes.Where(x => x.Name.ToLower() == input).FirstOrDefault();
    }

    public void SeeCategories()
    {
        Console.WriteLine("Velg kategori:");
        Console.WriteLine("1. Kjøttretter");
        Console.WriteLine("2. Vegetarretter");
        Console.WriteLine("3. Kjapp lunsj");

    }
}