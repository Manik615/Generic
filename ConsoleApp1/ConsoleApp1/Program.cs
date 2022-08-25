// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class Program
{
	public static void Main()
	{
		//Stopwatch sw = new Stopwatch();
		//sw.Start();
		string s = "cbbd";
		string r = "";
		foreach(var i in s)
        {
			r = i + r;
        }
		for(int i=0; i< s.Length -1; i++)
        {
			if (isPalindromeString(s.Substring(i)))
            {
				Console.WriteLine(s.Substring(i));
				break;
			}
			if (isPalindromeString(r.Substring(i)))
			{
				Console.WriteLine(r.Substring(i));
				break;
			}
			//if (isPalindromeString(r.Substring(i, r.Length - i)))
			//{
			//	//Console.WriteLine(r.Substring(i));

			//	Console.WriteLine(r.Substring(i, r.Length - i));
			//	break;
			//}
		}
		for(int i =0; i < s.Length/2; i++)
        {
			if (isPalindromeString(s.Substring(i,s.Length-2*i)))
			{
				Console.WriteLine(s.Substring(i, s.Length - 2 * i));
				break;
			}
		}


		//if (isPalindromeString("asdff"))
		//	Console.WriteLine("yes its palindrome");
		//else
		//	Console.WriteLine("its not a palindrome");


		//sw.Stop();
		//Console.WriteLine(sw.ElapsedMilliseconds);

	}

    public static void display(List<int> l, int i1, int i2)
    {
		for(int i=i1; i <= i2; i++)
        {
            Console.Write("{0} ",l[i]);
        }
		Console.WriteLine("\n");
    }

	public static void subArrayswithSum()
    {
		List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		int c;
		Boolean flag = false; ;

		Console.Write("Plese provide req sum value: ");
		int s =  Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < l.Count; i++)
		{
			c = 0;
			for (int j = i; j < l.Count; j++)
			{
				c += l[j];
				if (c == s)
				{
					display(l, i, j);
					flag = true;
                    //return;
                    break;
                }
			}
		}

		if (!flag)
		{
			Console.WriteLine("req sub array elements doesnt exist");
		}
	}

	public static void subArraywithSum()
    {

    }

	public static void reftypes()
    {
		A a = new A();
		a.display();

		//object o = new A();
		//o.display();

		B b = new B();
		b.display();

		A c = new B();
		c.display();

		//B d = new A(); got type casting error for this , Cannot implicitly convert type 'A' to 'B'. An explicit conversion exists (are you missing a cast?)
		//d.display();

		A e = new B();
		e.dispA();

		//A f = new B();//'A' does not contain a definition for 'dispB' and no extension method 'dispB' accepting a first argument of type 'A' 
		//f.dispB();//could be found (are you missing a using directive or an assembly reference?)

		//B g = new A();
		//g.dispB();  //Compilation error (line 25, col 9): Cannot implicitly convert type 'A' to 'B'. An explicit conversion exists (are you missing a cast?)

	}

	public static bool isPalindromeString(string s)
    {
		string r = "";
		foreach (var i in s)
		{
			r = i + r;
		}

		if (r == s)
			return true;
		else
			return false;
	}
}

public class A
{
	public virtual void display()
	{
		Console.WriteLine("you are in class A");
	}

	public void dispA()
	{

		Console.WriteLine("you are in class A specific method");
	}
}

public class B : A
{
	public override void display()
	{
		Console.WriteLine("you are in class B");
	}

	public void dispB()
	{

		Console.WriteLine("you are in class B specific method");
	}
}
