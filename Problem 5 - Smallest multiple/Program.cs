using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool numFound = false;
            int n = 0, count;
            while(!numFound)
            {
                n= n+1;
                count = 0;
                 for (int i = 1; i <= 20; i++)
                 {
                     if(n%i==0)
                     {
                         count = count+1;
                     }
                 }
                 if (count == 20)
                 {
                     numFound = true;
                 }                
            }
            Console.WriteLine("{0}", n);
        }
    }
}
