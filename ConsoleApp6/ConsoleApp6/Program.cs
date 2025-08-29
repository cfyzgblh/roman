using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class User
{
    public int Id;
    public string NickName;
    public string Name;
    public string SerName;
    public string Password;
    public int SeriaPasport;
    public int NumberPassport;
    public DateTime DateBerthday;
    public DateTime DateTimeCreated;

    public User(int id, string nickName, string name, string serName, string password,
       int seriaPasrort, int numberPassport, DateTime dateBerthday,DateTime dateTimeCreated)
    {
        Id = id;
        NickName = nickName;
        Name = name;
        SerName = serName;
        Password = password;
        SeriaPasport = seriaPasrort;
        NumberPassport = numberPassport;
        DateBerthday = dateBerthday;
        DateTimeCreated = dateTimeCreated;
    }

}

public static class UserRedistor
{
    public static List<User> Users;

    public static bool CheckUser(User userToCheck)
    {
        foreach (User user in Users)
        {
            if (user.NickName == userToCheck.NickName || user.SeriaPasport == userToCheck.NumberPassport
                || user.NumberPassport == userToCheck.NumberPassport || user.SeriaPasport == userToCheck.SeriaPasport)
                return true;
        }
        return false;
    }

    

    public static void RedisterUser(User newUser)
    {
        if (!CheckUser(newUser))
        {
            Users.Add(newUser);
            Console.WriteLine("Пользователь добавлен");
        }
        else
        {
            Console.WriteLine("Пользователь уже существует");
        }
    }
}   
public class Manager
{
   public string Name;
   public string SerName;
   public float PhoneNumber;
   public int PasportSeries;
   public int PasportNumber;
   public int DateOfBurth;
   public int IdManager;
   public string PasswordManader;
   public int DateOfEmployent;


   public Manager(string name, string serName, float phoneNumber, int pasportSeries,
       int pasportNumber, int dateOfBurth, int idManager, int dateOfEmployent,
       string passwordManager)
   {
        Name = name;
        SerName = serName;
        PhoneNumber = phoneNumber;
        PasportSeries = pasportSeries;
        PasportNumber = pasportNumber;
        DateOfBurth = dateOfBurth;
        IdManager = idManager;
        PasswordManader = passwordManager;
        DateOfEmployent = dateOfEmployent;
   }
}

public static class ManagerRegistor
{
    public static List<Manager> Managers;
    
    public static bool CheckManaher(Manager managerFromCheck)
    {
        foreach (Manager manager in Managers)
        {
            if (manager.PhoneNumber == managerFromCheck.PhoneNumber || manager.PasportNumber == managerFromCheck.PasportNumber
                || manager.PasportSeries == managerFromCheck.PasportSeries)
                return true;
        }

        return false;
    }

    public static void RegistorUser(Manager newManager)
    {
        if (!CheckManaher(newManager))
        {
            Managers.Add(newManager);
            Console.WriteLine("Менеджер зарегестрирован");
        }
        else
        {
            Console.WriteLine("Менеджер уже существует");
        }
    }
}
public class BankCard
 {
    public float NumberOfCard;
    public int ValidityPeriod;
    public int CVICod;
    public string NameOfOwner;
    public string SerNameOfOWner;

    public BankCard(float numberOfCard, int validityPeriod, int cVICod, string nameOfOwner, string serNameOfOWner)
    {
       NumberOfCard = numberOfCard;
       ValidityPeriod = validityPeriod;
       CVICod = cVICod;
       NameOfOwner = nameOfOwner;
       SerNameOfOWner = serNameOfOWner;
    }
}
    
public static class BankCardRedistor
{
    public static List<BankCard> bankCards;

    public static bool BankCardCheck (BankCard cardCheck)
    {
        foreach (BankCard bankCard in bankCards)
        {
            if (bankCard.NumberOfCard == cardCheck.NumberOfCard || bankCard.CVICod == cardCheck.CVICod)
                return true;
        }
        
        return false;
    }
}
public class BankAmount
{
     public float NumberCurentAcount;
     public float NumberCorispodenrAcount;
     public int BankIndificationCod;
     public decimal Balance;
     public string NameBank;

     public BankAmount(float numberCurentAcount, float numberCorispodenrAcount, int bankIndificationCod,
        decimal balance, string nameBank)
     {
        NumberCurentAcount = numberCurentAcount;
        NumberCorispodenrAcount = numberCorispodenrAcount;
        BankIndificationCod = bankIndificationCod;
        Balance = balance;
        NameBank = nameBank;
     }
}

