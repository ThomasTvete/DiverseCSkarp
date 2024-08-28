namespace SocialMedia;

public class CurrentUser
{
    public string Name;
    private string _password;
    public List<User> Friends = new List<User>();

    public CurrentUser(string name, string password)
    {
        Name = name;
        _password = password;
    }
}