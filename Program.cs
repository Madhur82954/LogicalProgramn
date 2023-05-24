using System;

namespace Day6_LogicalProgramning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option \n1) Fibonnaci Series\n2) Perfect Number\n3) Prime Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonnaciSeries fibonnaci = new FibonnaciSeries();
                    fibonnaci.CheckFibonnaciSeries();
                    break;

                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.CheckPerfectNumber();
                    break;

                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.CheckPrimeNumber();
                    break;
            }
        }
    }
}
