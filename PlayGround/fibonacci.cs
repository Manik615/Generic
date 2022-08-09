using System;
public class fibonacci
{
    public void fibo()
    {

        Console.WriteLine("Enter 1 to check wheather fibnacci no. or not \n" +
            "Enter 2 to get fibonacci number at required  location:");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                Console.Write("Please enter no.:");
                isFiboNo(Convert.ToInt32(Console.ReadLine()));
                break;
            case 2:
                Console.Write("Please enter req fibo no. location:");
                fiboNum(Convert.ToInt32(Console.ReadLine()));
                break;
            default:
                Console.WriteLine("Please enter valid number");
                break;
        }

    }
    public void fiboNum(int loc)
    {
        int val;
        int i1 = 1, i2 = 1;
        if (loc == 1 || loc == 2)
            val = 1;
        for (int i = 0; i < loc - 2; i++)
        {

            i2 = i2 + i1;
            i1 = i2 - i1;
        }
        val = i2;
        Console.WriteLine("fibonacci number at {0}th location is {1}", loc, val);
    }
    public void isFiboNo(int n)
    {
        if (n == 1 || n == 2)
            Console.WriteLine("yes");
        int i1 = 1, i2 = 1, c = 2;
        while (n > i2)
        {
            c++;
            i2 = i2 + i1;
            i1 = i2 - i1;

            if (i2 >= n)
                break;
        }
        if (i2 == n)
            Console.WriteLine("yes and location is {0}", c);
        else
        {
            if ((n - i1) < (i2 - n))
                c--;
            Console.WriteLine("no and nearby location is {0}", c);
        }

    }

}
