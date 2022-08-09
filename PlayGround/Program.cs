using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        s = s.ToUpper();
        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach(var c in s)
        {
           if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic.Add(c, 1);
            }
        }
       
        int count = 0;
        char ch ='d';
        foreach(var k in dic)
        {
            if (k.Value > count)
            {
                ch = k.Key;
                count = k.Value;
            }
            Console.WriteLine("{0}\t {1}", k.Key.ToString(),k.Value);
        }
        Console.WriteLine("Most repeated character in given string is: {0}",ch.ToString());
        


    }

}
