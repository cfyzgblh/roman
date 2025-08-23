using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata;

public interface IUser
{
    public string Name { get; set; }

    public string Password { get; set; }

    public string Login { get; set; }
}
   public delegate bool Deledate (string Lodin, List<string> LodinUsers);
public class User : IUser
{

    public string Name { get; set; }

    public string Password { get; set; }

    public string Login { get; set; }

    private int _ID = 0;
    public static int Counter = 0;
    public static List<string> LoginUsers = new List<string>();
    public const string FilePah = "users.txt";
    private Deledate _deledate;
    public User(string name, string password, string login)
    {
        Name = name;
        Password = password;
        _deledate = (string login, List<string> LoginUsers) => LoginUsers.Contains(login) ;
        while (_deledate?.Invoke(login, LoginUsers) == true)
        {
            Console.WriteLine("Логин уже существует");
            login = Console.ReadLine();
        }
       
            LoginUsers.Add(login);
            Login = login;
            Counter++;
            _ID = Counter;
            SaveData();
            Drow();
        
    }
    public static void Main()
    {

    }

    public void SaveData()
    {
        File.AppendAllText(FilePah, Name + " " + Login + " " + Password + "\n");
    }

    public void Drow()
    {
        Console.WriteLine(Login + " " + _ID +"\n");
    }


}