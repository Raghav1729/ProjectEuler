using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxPal = 0, originalInteger, reversedInteger = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= i; j--)
                {
                    originalInteger = i * j;
                    if (originalInteger > maxPal)
                    {
                        reversedInteger = ReversedNum(originalInteger);

                        if (originalInteger == reversedInteger && originalInteger > maxPal)
                        {
                            maxPal = originalInteger;
                        }
                    }
                }
            }
             Console.WriteLine("{0}", maxPal);
        }

        public static int ReversedNum(int originalInteger)
        {
            int remainder, reversedInteger = 0;
            while (originalInteger != 0)
            {
                remainder = originalInteger % 10;
                reversedInteger = reversedInteger * 10 + remainder;
                originalInteger /= 10;
            }
            return reversedInteger;

        }
    }
}
