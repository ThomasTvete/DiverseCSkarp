namespace Bossfight;

public class GameCharacter
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }
    public int CurrentStamina { get; private set; }
    public int MaxStamina { get; private set; }
    public bool RandomStr { get; private set; }

    Random rnd = new Random();

    public GameCharacter(string name, int health, int strength, int stamina, bool rndStr)
    {
        Name = name;
        Health = health;
        Strength = rndStr == true ? rnd.Next(0, 31) : strength;
        CurrentStamina = stamina;
        MaxStamina = stamina;
        RandomStr = rndStr;
    }


    public void Engage(GameCharacter target)
    {
        if (RandomStr) Strength = rnd.Next(0, 31);
        if (CurrentStamina >= 10)
        {
            Fight(target);
            Console.ReadKey(true);
        }
        else
        {
            Recharge();
            Console.ReadKey(true);
        }
    }

    private void Fight(GameCharacter target)
    {
        target.Health -= Strength;
        CurrentStamina -= 10;
        Console.WriteLine($"{Name} gjorde {Strength} skade mot {target.Name}, {target.Name} har nå {target.Health} liv igjen!");
    }

    public void Recharge()
    {
        CurrentStamina = MaxStamina;
        Console.WriteLine($"{Name} er sliten, og tok seg en kaffepause.");

    }
}