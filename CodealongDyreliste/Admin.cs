namespace CodealongDyreliste;

public class Admin
{
    public Animal animals = new Animal();

    public void RunPetKennel()
    {
        while (true)
        {
            ConsoleMessages.WelcomeMenu();
            int userChoice = Convert.ToInt32(ConsoleMessages.RequestInfo("Hva vil du gjøre? Velg ett tall: "));
            UserAction(userChoice);
        }
    }

   

    public void UserAction(int input)
    {
        switch (input)
        {
            case 1:
                DropOffPet();
                break;
            case 2:
                ConsoleMessages.ShowPets(animals.Pets);
                break;
            case 3:
                SearchPets();
                break;
            default:
                ConsoleMessages.ErrorMessage();
                UserAction(input);
                break;
        }
    }

    private void DropOffPet()
    {
        string petName = ConsoleMessages.RequestInfo("Hva heter dyret ditt? ");
        int petAge = Convert.ToInt32(ConsoleMessages.RequestInfo("Hvor gammel er den? Skriv i tall: "));
        string petSpecies = ConsoleMessages.RequestInfo("Hva slags dyr er det? ");

        Animal pet = new Animal(petName, petAge, petSpecies);

        animals.AddPet(pet);
        RunPetKennel();
    }

    public void SearchPets()
    {
        List<Animal> searchedAnimals = new List<Animal>();
        string userSearch = ConsoleMessages.RequestInfo("Hvilken art er det du ser etter? ").ToLower();

        foreach (Animal pet in animals.Pets)
        {
            if(pet.Species.ToLower() == userSearch) searchedAnimals.Add(pet);
        }

        if (searchedAnimals.Count > 0) ConsoleMessages.ShowPets(searchedAnimals);
        else ConsoleMessages.NoAnimals();

    }
}