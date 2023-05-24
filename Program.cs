using System;
using System.Diagnostics;

namespace Day6_LogicalProgramning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option \n1) Fibonnaci Series\n2) Perfect Number\n3) Prime Number\n4) Reverse Number \n5) Coupon Numbers\n6) StopWatch Programn");
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

                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.checkReverseNumber();
                    break;

                case 5:
                    CouponNumbers.CheckCouponNumbers();
                    break;

                case 6:
                    int start = Convert.ToInt32(Console.ReadLine());
                    int End = Convert.ToInt32(Console.ReadLine());
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    // ... This takes 10 seconds to finish.
                    for (int i = start; i < End; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                    }

                    // Stop.
                    stopwatch.Stop();

                    // Write hours, minutes and seconds.
                    Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                    break;
            }
        }
    }
}
