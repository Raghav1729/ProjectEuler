using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long n = 600851475143;
            int maxPrimeFactor = 1;

            if (n%2 == 0)
            {
                maxPrimeFactor = 2;             
            }

            for (int i = 3; i <= n; i = i+2)
            {
                while (n%i == 0)
                {
                    if(maxPrimeFactor < i)
                    {
                        maxPrimeFactor = i;
                    }
                    n = n/i;
                }
            }
            Console.WriteLine("{0}", maxPrimeFactor);
        }
    }
}
