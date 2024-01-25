using System;
using static System.Console;

namespace HW01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double KM_PER_MILE = 1.6;

            Write("Please enter # of miles to be converted to kilometers:\t");
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * KM_PER_MILE;
            string outputStr = $"{miles} miles is {kilometers} kilometers";
            Write(outputStr);
        }
    }
}