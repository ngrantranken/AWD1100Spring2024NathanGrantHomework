using System;
using System.Reflection.Metadata;
using static System.Console;

namespace HW01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PERCENT_RAISE = 0.04;

            Write("Employee 1 Name:\t");
            string employee1Name = Console.ReadLine();
            Write("Employee 1 Salary:\t");
            double employee1Salary1 = double.Parse(Console.ReadLine());
            Write("Employee 2 Name:\t");
            string employee2Name = Console.ReadLine();
            Write("Employee 2 Salary:\t");
            double employee2Salary1 = double.Parse(Console.ReadLine());
            Write("Employee 3 Name:\t");
            string employee3Name = Console.ReadLine();
            Write("Employee 3 Salary:\t");
            double employee3Salary1 = double.Parse(Console.ReadLine());

            double employee1Salary2 = employee1Salary1 + (employee1Salary1 * PERCENT_RAISE);
            double employee2Salary2 = employee2Salary1 + (employee2Salary1 * PERCENT_RAISE);
            double employee3Salary2 = employee3Salary1 + (employee3Salary1 * PERCENT_RAISE);
            double employee1Salary3 = employee1Salary2 + (employee1Salary2 * PERCENT_RAISE);
            double employee2Salary3 = employee2Salary2 + (employee2Salary2 * PERCENT_RAISE);
            double employee3Salary3 = employee3Salary2 + (employee3Salary2 * PERCENT_RAISE);

            Write(String.Format("|{0,10}| {1,10}| {2,10}| {3,10}|\n", "Year", employee1Name, employee2Name, employee3Name));
            Write(String.Format("|{0,10}|${1,10}|${2,10}|${3,10}|\n", "2024", employee1Salary1, employee2Salary1, employee3Salary1));
            Write(String.Format("|{0,10}|${1,10}|${2,10}|${3,10}|\n", "2025", employee1Salary2, employee2Salary2, employee3Salary2));
            Write(String.Format("|{0,10}|${1,10}|${2,10}|${3,10}|\n", "2026", employee1Salary3, employee2Salary3, employee3Salary3));
        }
    }
}