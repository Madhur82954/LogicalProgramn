using System;

namespace Day6_LogicalProgramning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option \n1) Fibonnaci Series");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonnaciSeries fibonnaci = new FibonnaciSeries();
                    fibonnaci.CheckFibonnaciSeries();
                    break;
            }
        }
    }
}
