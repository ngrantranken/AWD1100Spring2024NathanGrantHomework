using System;
using static System.Console;

namespace HW01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter the first grade:\t");
            int grade1 = int.Parse(Console.ReadLine());
            Write("Please enter the second grade:\t");
            int grade2 = int.Parse(Console.ReadLine());
            Write("Please enter the third grade:\t");
            int grade3 = int.Parse(Console.ReadLine());
            Write("Please enter the fourth grade:\t");
            int grade4 = int.Parse(Console.ReadLine());
            int sum = grade1 + grade2 + grade3;
            int average = sum / 3;
            Write("The average of your 4 grades is: " + average);
        }
    }
}