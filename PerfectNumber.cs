using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProgramning
{
    internal class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("--------- Perfect Number ---------------");
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is a perfect Number");
            }
            else
            {
                Console.WriteLine(n +" is not a perfect Number");
            }

        }
    }
}
