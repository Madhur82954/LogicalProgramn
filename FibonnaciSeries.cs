using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProgramning
{
    internal class FibonnaciSeries
    {
        public void CheckFibonnaciSeries()
        {
            int p1 = 0, p2 = 1, p3;
            Console.Write("Enter number = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write(p1 + " " + p2);
            for (int i = 2; i < n; i++)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
