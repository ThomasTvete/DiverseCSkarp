namespace SocialMedia;

public class User
{
    public string Name;
    public string Email;
    public string Password;
    public string Bio;


    public User(string name, string email, string password, string bio)
    {
        Name = name;
        Email = email;
        Password = password;
        Bio = bio;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brukernavn: {Name}");
        Console.WriteLine($"Min epost: {Email}");
        Console.WriteLine($"Om meg: {Bio}");
    }

    

    

}