// for more information on MultiThreading visit https://www.albahari.com/threading/

//Difference between thread.start() and run()
//Thread.start() method creates a new thread and call the code block written inside run () method
//on newly created thread, while calling run () method does not create a new thread but executes
//the code in run () method on current thread itself like a normal method call. Here is sample and
//output that clearly state difference.

//To handle Synchronisation, we have various methods, divided into 4 categories
//Blocking Methods
//Locking Constructs
//No blocking Synchronization
//Signaling

using System;
using System.Threading; 
public class Program
{
    public static void Main()
    {
        //Creating the WorkerThread with the help of Thread class.    
        Thread ThreadObject1 = new Thread(WorkerThread);
        ThreadObject1.Start(); //Starting the Thread

        /* synchronization join is a blocking mechanism that helps in pausing the calling thread.
        This continues until the thread execution has finished on which the join is called.*/

        //ThreadObject1.Join(); //Using Join to block the current Thread
                              

        Console.WriteLine("1. MainThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> MainThread Executing");
            Thread.Sleep(3000); //Here 5000 is 5000 Milli Seconds means 5 Seconds    
        }
        // We are calling the Name of Current running Thread using CurrentThread    
        Thread Th = Thread.CurrentThread;
        Th.Name = "Main Thread";
        Console.WriteLine("\nGetting the Name of Currently running Thread");
        //Name Property is used to get the name of the current Thread    
        Console.WriteLine($"Current Thread Name is: {Th.Name}");
        //Priority Property is used to display the Priority of current Thread    
        Console.WriteLine($"Current Thread Priority is: {Th.Priority}");

        LockExample1 _locker = new LockExample1();
        Console.WriteLine("Threading with the help of Lock");
        //Calling the Display Method using ThreadStart Delegate which is supplied to Thread constructor.    
        Thread t1 = new Thread(new ThreadStart(_locker.Display));
        Thread t2 = new Thread(new ThreadStart(_locker.Display));
        t1.Start(); //Starting Thread1    
        t2.Start(); //Starting Thread2 
    }
    static void WorkerThread()
    {
        Console.WriteLine("2. WorkerThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> WorkerThread Executing");
            Console.WriteLine("Child Thread Paused");
            //Sleep method is used to pause the Thread for a specific period    
            Thread.Sleep(3000);
            Console.WriteLine("Child Thread Resumed");
        }

    }

}

public class LockExample1
{
    //Creating a normal Method to Display Names    
    public void Display()
    {
        //Lock is used to lock-in the Current Thread    
        lock (this)
        {
            for (int i = 0; i <= 3; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine($"My Name is Abhishek{i}");
            }
        }
    }
}
