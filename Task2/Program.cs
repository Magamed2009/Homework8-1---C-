using System.Net;

var user = new User();
user.FirstName = Console.ReadLine();
user.LastName = Console.ReadLine();
user.UserName = Console.ReadLine();
user.Password = Console.ReadLine();

System.Console.WriteLine(user.Login(Console.ReadLine(),Console.ReadLine()));

System.Console.WriteLine(user.GetFullInfo());

class User
{
    int cnt=0;
    public bool IsLoggedIn = true;
    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;

    public string Login(string username, string password)
    {
        if(username == UserName && password == Password)
        {
            IsLoggedIn = true;
            return $"";
        }
        else 
        {
            IsLoggedIn = false;
            return $"";
        }
    }
    public string GetFullInfo()
    {
        if(IsLoggedIn == true)
        {
            return $"{FirstName} {LastName} - {IsLoggedIn}";
        }
        else 
        {
            return $"Your password or username is incorrect.";
        }
    }
}