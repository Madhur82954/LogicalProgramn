using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProgramning
{
    internal class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            bool is_prime = true;
            Console.WriteLine("------------ Prime Number------------------");
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==0 || n == 1)
            {
                is_prime = false;
            }
            for(int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                    break;
                }
            }
            if (is_prime)
            {
                Console.WriteLine(n + " is a prime Number");
            }
            else
            {
                Console.WriteLine(n + " is not a prime Number");
            }
        }
    }
}
