using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            int n = 100;
            long sum = n * (n+1)/ 2;
            long squared = (n * (n + 1) * (2 * n + 1)) / 6;
            long diff = sum*sum - squared;
            Console.WriteLine("{0}", diff);
        }
    }
}
