
//internal class Program
//{
//    static void Main()
//    {
//        Task[] tasks = new Task[5];

//         for (int i =0 ; i < tasks.Length; i++)
//        {
//            int taskMumber = i;
//            tasks[i] = Task.Run(() => DoTusk(taskMumber));
//        }


//        Task.WaitAll(tasks);
//    }

//    public static  void DoTusk(int taskNumber)
//    {
//        Console.WriteLine($"Выполняеться задача: {taskNumber}");
//        Task.Delay(2000).Wait();
//        Console.WriteLine($"Задача: {taskNumber} выполнилась");
//    }
//}
//using System.Numerics;

//internal class Program
//{
//     public static void Main()
//    {
//        Task task = new Task(() => Factorial(10));
//        task.Start();
//        task.Wait();
//        Task task2 = new Task(() => Factorial(32));
//        task2.Start();
//        task2.Wait();
//    }

//    public static BigInteger Factorial(int n)
//    {
//        var factorial = new BigInteger(1);
//        for (int i = 1; i <= n; i++)
//            factorial *= i;
//        Console.WriteLine(factorial.ToString());
//        return factorial;
//    }
    
//}