namespace SocialMedia;

public class Admin
{

    public List<User> Users = new List<User>
    {
        new User("Axoloth", "420@gmail.com", "yoo", "Jeg liker iskrem"),
        new User("Lime", "dumdum@gmail.com", "morelikeslime", "Jeg liker sitron"),
        new User("Kon", "buenosuck@gmail.com", "key69", "Jeg hater egg"),
        new User("Chia", "nottheseed@gmail.com", "mitchi", "Jeg liker pizza"),
    };

    public CurrentUser LoggedInUser;

    public void RunSocialMedia()
    {
        Console.WriteLine("Velkommen til Sosiale Medier");
        Console.WriteLine("1. Logg inn");
        Console.WriteLine("2. Lag Bruker");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                LogIn();
                break;
            case 2:
                SignUp();
                break;
            default:
                Console.WriteLine("Velg et gyldig tall");
                RunSocialMedia();
                break;
        }
    }

    public void SignUp()
    {
        Console.WriteLine("Velg ditt brukernavn");
        string userName = Console.ReadLine();
        Console.WriteLine("Skriv inn din epost");
        string userEmail = Console.ReadLine();
        Console.WriteLine("Velg et passord");
        string userPassword = Console.ReadLine();
        Console.WriteLine("Fortell litt om deg selv");
        string userBio = Console.ReadLine();
        User newUser = new User (userName, userEmail, userPassword, userBio);
        Users.Add (newUser);
        RunSocialMedia();
    }

    public void LogIn()
    {
        Console.WriteLine("Skriv inn ditt brukernavn");
        string userName = Console.ReadLine();
        Console.WriteLine("Skriv inn ditt passord");
        string userPassword = Console.ReadLine();
        bool checkUser = Users.Any(x => x.Name == userName && x.Password == userPassword);
        if (checkUser)
        {
            LoggedInUser = new CurrentUser(userName, userPassword);
            LoggedInMenu();
        }
        else
        {
            Console.WriteLine("Ugyldig brukernavn eller passord");
            Console.ReadKey(true);
            LogIn();
        }
    }

    public void LoggedInMenu()
    {
        Console.WriteLine("Hva vil du gjøre?");
        Console.WriteLine("1. Se brukere");
        Console.WriteLine("2. Se venneliste");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        if (userChoice == 1 || userChoice == 2) ShowUserList(userChoice);
        else
        {
            Console.WriteLine("Velg et gyldig tall");
            LoggedInMenu();
        }
    }

    public void ShowUserList(int chosenList)
    {
        var userList = chosenList == 1 ? Users : LoggedInUser.Friends;
        bool waitingForInput = true;
        foreach (var user in userList)
        {
            Console.WriteLine($"{user.Name}");
        }
        Console.WriteLine();
        Console.WriteLine("Skriv inn hvems profil du vil se");
        while (waitingForInput)
        {
            string input = Console.ReadLine();
            User validInput = Users.Where(x => x.Name == input).FirstOrDefault();
            if (validInput != null)
            {
                ShowUserProfile(validInput);
                waitingForInput = false;
            }
            else
            {
                Console.WriteLine("Skriv inn et gyldig navn");
            }
        }
        
    }

  

    public void ShowUserProfile(User user)
    {
        user.PrintInfo();
        Console.WriteLine();
        Console.WriteLine("1. Tilbake til meny");
        bool checkFriend = LoggedInUser.Friends.Any(x => x.Name == user.Name);
        if (checkFriend)
        {
            Console.WriteLine("2. Fjern fra venneliste");
        }
        else
        {
            Console.WriteLine("2. Legg til som venn");
        }
        int userChoice = Convert.ToInt32(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                LoggedInMenu();
                break;
            case 2:
                if(checkFriend)RemoveFriend(user);
                else AddFriend(user);
                break;
            default:
                LoggedInMenu();
                break;
        }


    }





    public void AddFriend(User user)
    {
        LoggedInUser.Friends.Add(user);
        Console.WriteLine($"Du har lagt til {user.Name} som venn");
        Console.ReadKey(true);
        LoggedInMenu();
    }

    public void RemoveFriend(User user)
    {
        LoggedInUser.Friends.Remove(user);
        Console.WriteLine($"Du har fjernet {user.Name} som venn");
        Console.ReadKey(true);
        LoggedInMenu();
    }
}