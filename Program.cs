using System;

namespace PrimeNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;

            for(int i = 1; i <= number; i++)
            {
               
               if(number % i == 0)
               {
                divisors++;
               }
            }

            if(divisors == 2)
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
