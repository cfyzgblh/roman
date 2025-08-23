using System.Collections.Specialized;
using System.Text.Json.Serialization;

public class Person
{
    public string Name;
    public string SerName;
    public string Address;
    public string Email;
    public int DateOfBerth;

    public Person (string name, string serName, string address, string email, int dateOfBerth)
    {
        Name = name;
        SerName = serName;
        Address = address;
        Email = email;
        DateOfBerth = dateOfBerth;
    }   
}

public class Prodram
{
    public static void Main()
    {
        Person person = new Person("Рома", "Кузьмин", "40 лет октября 5а", "cU2roma@yandex.ru", 23052005);
        string Json = JsonSeriaizer.Serialize(person);
    }
    
}