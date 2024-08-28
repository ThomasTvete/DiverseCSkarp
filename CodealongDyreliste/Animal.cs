namespace CodealongDyreliste;

public class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Species { get; private set; }

    public List<Animal> Pets { get; private set; } = new List<Animal>() ;

    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }


    public Animal()
    {

    }

    public void AddPet(Animal pet)
    {
        Pets.Add(pet);
    }

}