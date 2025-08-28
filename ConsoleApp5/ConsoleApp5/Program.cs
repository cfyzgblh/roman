internal class Prodram
{
    public static void Main()
    {
        Car Yaz = new Car("Уаз", "Буханка", "1", "ЗМЗ - 409");
        Car Lada = new Car("Лада", "Приора", "2", "ВАЗ - 211127");
        Thread threadYas = new Thread(Yaz.Go);
        Thread threadLada = new Thread(Lada.Go);
        threadYas.Start();
        threadLada.Start();
        threadYas.Join();
        threadLada.Join();

    }
}
public class Car
{
    public string Brand;
    public string Seria;
    public string Model;
    public string Engine;

    public Car(string brand, string seria, string model, string engine)
    {
        Brand = brand;
        Seria = seria;
        Model = model;
        Engine = engine;
    }

    public void Go()
    {
        for (int i = 0; i < 100; i++)
        { 
            Console.SetCursorPosition(30,i);
            Console.WriteLine($"Дистанция автомобиля {Brand} = {i}")  ;
            Thread.Sleep(1000);
        }
    }
}