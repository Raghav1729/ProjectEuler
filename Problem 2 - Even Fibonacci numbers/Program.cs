using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 2, c;
            int sum = 2;
            while (b < 4000000)
            {
                c = a + b;
                if (c % 2 == 0)
                {
                    sum = sum + c;
                }
                a = b;
                b = c;

            }
            Console.WriteLine("{0}", sum);
        }
    }
}
