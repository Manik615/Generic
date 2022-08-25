// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Main Method Started......");
        
        Method1();
        for(int i = 0; i < 10; i++)
        {
            Task.Delay(1000);
            Console.WriteLine(i);   
        }
        //Method2();
        //var s = Task.Run(() => Method1());
        //var s= Task.Run(() => p);
        
        Console.WriteLine("Main Method End");
        Console.ReadKey();

    }

    public async static void Method1()
    {
        Console.WriteLine("Method1 Started......");
        //Thread.Sleep(TimeSpan.FromSeconds(10));
        Stopwatch sw = new Stopwatch();
        sw.Start();
        await Task.Delay(TimeSpan.FromSeconds(3));
        Console.WriteLine("2nd await starts");
        await Task.Delay(TimeSpan.FromSeconds(2));

        sw.Stop();
        
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.WriteLine("Method1 End");
        
    }

    public async static void Method2()
    {
        Console.WriteLine("Method2 Started......");
        //Thread.Sleep(TimeSpan.FromSeconds(10));
        await Task.Delay(TimeSpan.FromSeconds(2));
        Console.WriteLine("\n");
        Console.WriteLine("Method2 End");
    }
    public async static void method3()
    { 
        Console.WriteLine("Method3 Started......");
        //Thread.Sleep(TimeSpan.FromSeconds(10));
        await Task.Delay(TimeSpan.FromSeconds(3));
        //Console.WriteLine("\n");
        Console.WriteLine("Method3 End");
    }

    public async static void method4()
    {
        Console.WriteLine("Method4 Started......");
        //Thread.Sleep(TimeSpan.FromSeconds(10));
        await Task.Delay(TimeSpan.FromSeconds(2));
        //Console.WriteLine("\n");
        Console.WriteLine("Method3 End");
    }
}