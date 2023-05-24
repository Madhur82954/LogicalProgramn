using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProgramning
{
    internal class CouponNumbers
    {
        public static void CheckCouponNumbers()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTabcdefghijklmnopqrst1234567890";
            var stringchars = new char[6];
            string[] Couponnumber = new string[6];
            var random = new Random();

            Console.WriteLine("Coupon Numbers Program");

            Console.WriteLine("Enter your 6 digit Coupon Number");
            for (int i = 0; i <= Couponnumber.Length; i++)
            {
                Couponnumber[i] = Console.ReadLine();

            }

            for (int i = 0; i < stringchars.Length; i++)
            {
                stringchars[i] = chars[random.Next(chars.Length)];
            }

            if (Couponnumber.Length == stringchars.Length)
            {
                Console.WriteLine("Entered Coupon Number is Correct");
            }
            else
            {
                Console.WriteLine("Entered Coupon Number is not Correct");
            }
        }
    }
}
