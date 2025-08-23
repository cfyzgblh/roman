using System.Globalization;
using System.Runtime.CompilerServices;

DateTime dateTime = DateTime.Now; 
Console.WriteLine(dateTime);
namespace People
{
    public class User
    {
        public string Name;
        public string SerName;
        public float PhoneNumber;
        public int PasportSeries;
        public int PasportNumber;
        public int DateOfBurth;

        public User(string name, string serName, float phoneNumber, int pasportSeries, int pasportNumber, int dateOfBurth)
        {
            Name = name;
            SerName = serName;
            PhoneNumber = phoneNumber;
            PasportSeries = pasportSeries;
            PasportNumber = pasportNumber;
            DateOfBurth = dateOfBurth;
        }

        public static void Main() { }
        public static void CreateUser()
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            var serName = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            var isNumber = float.TryParse(Console.ReadLine(), out var phoneNumber);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = float.TryParse(Console.ReadLine(), out  phoneNumber);

            }

            Console.WriteLine("Введите серию паспорта");
            isNumber = int.TryParse(Console.ReadLine(), out var pasportSeries);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out  pasportSeries);
            }

            Console.WriteLine("Введите номер паспорта");
            isNumber = int.TryParse(Console.ReadLine(), out var pasportNumber);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out  pasportNumber);
            }

            Console.WriteLine("Введите дату рождения");
            isNumber = int.TryParse(Console.ReadLine(), out var dateOfBurth);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out dateOfBurth);
            }

            User user = new User (name,serName,phoneNumber, pasportSeries,pasportNumber,dateOfBurth);

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
        public int DateOfEmployent;
        
        public Manager(string name, string serName, float phoneNumber, int pasportSeries, int pasportNumber, int dateOfBurth, int idManager, int dateOfEmployent)
        {
            Name = name;
            SerName = serName;
            PhoneNumber = phoneNumber;
            PasportSeries = pasportSeries;
            PasportNumber = pasportNumber;
            DateOfBurth = dateOfBurth;
            IdManager = idManager;
            DateOfEmployent = dateOfEmployent;
         
        }

        public void Create()
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            var serName = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            var isNumber = float.TryParse(Console.ReadLine(), out var phoneNumber);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = float.TryParse(Console.ReadLine(), out phoneNumber);

            }

            Console.WriteLine("Введите серию паспорта");
            isNumber = int.TryParse(Console.ReadLine(), out var pasportSeries);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out pasportSeries);
            }

            Console.WriteLine("Введите номер паспорта");
            isNumber = int.TryParse(Console.ReadLine(), out var pasportNumber);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out pasportNumber);
            }

            Console.WriteLine("Введите Id менеджера");
            isNumber = int.TryParse(Console.ReadLine(), out var idManager);

            while(!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out idManager);
            }

            Console.WriteLine("Введите дату рождения");
            isNumber = int.TryParse(Console.ReadLine(), out var dateOfBurth);

            while (!isNumber)
            {
                Console.WriteLine("Ошибка! Ожидалось число");
                isNumber = int.TryParse(Console.ReadLine(), out dateOfBurth);
            }

        }
    }
}

namespace  Bank
{
    public class BankCard
    {
        public float NumberOfCard;
        public int ValidityPeriod;
        public int CVICod;
        public string NameOfOwner;
        public string SerNameOfOWner;

        public BankCard (float numberOfCard, int validityPeriod, int cVICod, string nameOfOwner, string serNameOfOWner)
        {
            NumberOfCard = numberOfCard;
            ValidityPeriod = validityPeriod;
            CVICod = cVICod;
            NameOfOwner = nameOfOwner;
            SerNameOfOWner = serNameOfOWner;
        }
    }

    public class BankAmount
    {
        public float NumberCurentAcount;
        public float NumberCorispodenrAcount;
        public int BankIndificationCod;
        public string NameBank;

        public BankAmount(float numberCurentAcount, float numberCorispodenrAcount, int bankIndificationCod, string nameBank)
        {
            NumberCurentAcount = numberCurentAcount;
            NumberCorispodenrAcount = numberCorispodenrAcount;
            BankIndificationCod = bankIndificationCod;
            NameBank = nameBank;
        }
    }
}