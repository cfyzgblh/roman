internal class Program
{
    public static readonly object lockObj = new object();
    public static int posCar1 = 0;
    public static int posCar2 = 0;
    public static Thread? thread1;
    public static Thread? thread2;
    static void Main()
    {
        //ParameterizedThreadStart race = new ParameterizedThreadStart(?Race);
        Car car1 = new("Ламба");
        Car car2 = new("Жигуль");
        //thread1 = new Thread(race);
        //thread2 = new Thread(race);
        thread1 = new Thread(() => Race(car1));
        thread2 = new Thread(() => Race(car2));
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();
        Console.WriteLine("Гонка завершена!");

    }
    public static void Race(Car car)
    { 
        //Car car = (Car)carObject;
        for (int i = 0; i < 20; i++)
        {

           
            
                if (Thread.CurrentThread.ManagedThreadId == thread1.ManagedThreadId)
                {
                    while (posCar1 > posCar2) { }
                    lock (lockObj)
                    {
                        car.Move();
                        posCar1++;
                        Console.SetCursorPosition(0, i);
                        Random random = new Random();
                        Thread.Sleep(random.Next(1, 10));
                        Console.WriteLine($"{car.Name} - {car.Position}");
                    }
                }
                else if (Thread.CurrentThread.ManagedThreadId == thread2.ManagedThreadId)
                {
                    while (posCar2 > posCar1) { }
                    lock (lockObj)
                    {
                        car.Move();
                        posCar2++;
                        Console.SetCursorPosition(20, i);
                        Random random = new Random();
                        Thread.Sleep(random.Next(1, 10));
                        Console.WriteLine($"{car.Name} - {car.Position}");
                    }
                }
            
        }
    }
}

public class Car
{
    public int Position { get; private set; } = 0;
    public string? Name { get; set; }
    public Car(string name)
    {
        Name = name;
    }
    public void Move() => Position++;
}
