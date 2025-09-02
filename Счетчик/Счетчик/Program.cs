using System.Threading;

internal class Program
{
    
    public static Thread ThreadPlus;
    public static Thread ThreadMinus;

    public static void Main()
    {
        ThreadPlus = new Thread(Counter.CounterPlus);
        ThreadMinus  = new Thread(Counter.CounterMinus);    
        ThreadPlus.Start();
        ThreadMinus.Start();
        ThreadPlus.Join();
        ThreadMinus.Join();           


        //if (Thread.CurrentThread.ManagedThreadId == ThreadPlus.ManagedThreadId)
        //{
        //    while (Counter.CounterUser < 100) { }
            
        //        lock(lockObj)
        //        {
        //            Thread.Sleep(100);
   
        //        }
            
        //}

        //else if (Thread.CurrentThread.ManagedThreadId == ThreadMinus.ManagedThreadId)
        //{
        //    while (Counter.CounterUser > 100) { }
            
        //        lock (lockObj)
        //        { 
                  
        //                Thread.Sleep(100);

                    
        //        }
            
        //}
        //Console.WriteLine(Counter.CounterUser);
    }
}
public static class Counter
{
    public  static int CounterUser = 0;
    public static readonly object lockObj = new object();
    public static void CounterPlus()
    {
        for (int i = 0; i<5; i++)
        {
            lock (lockObj)
            {
                CounterUser++;
                Console.WriteLine(CounterUser.ToString());

            }
        }
        
    }

    public static void CounterMinus()
    {
        for (int i = 5; i  >0; i--)
        {
            lock (lockObj)
            {
                CounterUser--;
                Console.WriteLine(CounterUser.ToString());

            }
        }
    }
}
