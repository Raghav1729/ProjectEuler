using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int sum = 0;
            List<int> multiple = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                if (i % a == 0)
                {
                    sum  = sum + i;
                }
                else if (i % b == 0)
                {
                   sum  = sum + i;
                }
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
