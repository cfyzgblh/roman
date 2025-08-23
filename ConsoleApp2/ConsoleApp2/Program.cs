public class Person
{
    public string Name;

     public Person (string name)
    {
        Name = name;
    } 
}
public class Resaut
{
    int Value = 0;
    Dictionary<Person, int> keyValues = new Dictionary<Person, int>();

    public Resaut(int value, Dictionary<Person, int> keyValues)
    {
        Value = value;
        this.keyValues = keyValues;
    }

    public void Add(Person person, int Value)
    {
        keyValues.Add(person, Value);
    }

   
}