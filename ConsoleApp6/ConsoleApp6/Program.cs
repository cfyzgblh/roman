public class User
{
    public int Id;
    public string NickName;
    public string Name;
    public string SerName;
    public string Email;
    public string Password;
    public DateTime DateTimeCreated = DateTime.Now;
    public DateTime DateBerthday;


    public User(int id, string nickName, string name, string serName, string email, string password,
        DateTime dateBerthday)
    {
        Id = id;
        NickName = nickName;
        Name = name;
        SerName = serName;
        Email = email;
        Password = password;
        DateBerthday = dateBerthday;
    }

}

public static class UserRedistor
{
    public static List<User> Users;

    public static bool CheckUser(User userToCheck)
    {
        foreach (User user in Users)
        {
            if (user.NickName == userToCheck.NickName || user.Email == userToCheck.Email)
                return true;
        }
        return false;
    }

    public static void RedisterUser(User newUser)
    {
        if (!CheckUser(newUser))
        {
            Users.Add(newUser);
        }
        else
        {
            Console.WriteLine("Пользователь уже существует");
        }
    }
}
