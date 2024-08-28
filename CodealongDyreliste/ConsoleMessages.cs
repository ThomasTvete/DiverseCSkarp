using System.Xml;

namespace CodealongDyreliste;

public static class ConsoleMessages
{
    public static string RequestInfo(string message)
    {
        var output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.WriteLine(message);
            output = Console.ReadLine();
        }
        return output;
    }

    public static void WelcomeMenu()
    {
        Console.WriteLine("Velkommen til dyrepasseren!");
        Console.WriteLine("1. Lever inn et dyr");
        Console.WriteLine("2. Vis alle dyr");
        Console.WriteLine("3. Søk etter dyrearter");
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("Vennligst velg ett gyldig tall");
    }

    public static void ShowPets(List<Animal> animals)
    {
        Console.WriteLine("Dette er dyrene i klassen i dag:");
        foreach (Animal pet in animals)
        {
            Console.WriteLine($"{pet.Name} er en {pet.Age} år gammel {pet.Species}");
        }
    }

    public static void NoAnimals()
    {
        Console.WriteLine("Vi har ingen av dyrene du ser etter her i dag");
    }
}