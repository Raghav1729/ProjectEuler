using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0, n = 1;
            while(count<10001)
            {
                 n += 1;
                if (isPrime(n))
                {  
                    count += 1; 
                }
            }
            Console.WriteLine("{0}", n);
        }

        public static bool isPrime(int num)
        {
           for (int i = 2; i < num; i++) 
           {  
               if (num % i == 0)  
               {  
                   return false;  
               }  
           }
           return true;  
        }
    }
}
