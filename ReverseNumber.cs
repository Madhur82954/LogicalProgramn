using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProgramning
{
    internal class ReverseNumber
    {
        public void checkReverseNumber()
        {
            int ans=0;
            Console.WriteLine("------------ Reverse Number -----------");
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
                int digit = n % 10;
                ans = ans*10 + digit;
                n = n / 10;
            }
            Console.WriteLine("Number is = " + ans);
        }
    }
}
