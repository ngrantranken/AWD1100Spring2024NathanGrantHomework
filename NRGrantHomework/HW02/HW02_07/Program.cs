using System;

namespace HomeSalesTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            double dSales = 0.0;
            double eSales = 0.0;
            double fSales = 0.0;
            double grandTotal = 0.0;
            string[] salespeople = ["Danielle", "Edward", "Francis"];

            while (true)
            {
                Console.Write("Who made the sale?\n");
                char initial = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                
                if (initial == 'z')
                {
                    Console.WriteLine($"{salespeople[0]}: ${dSales}\n{salespeople[1]}: ${eSales}\n{salespeople[2]}: ${fSales}");
                    Console.WriteLine($"Grand Total: ${grandTotal}");
                    double topSales = Math.Max(Math.Max(dSales, eSales), fSales);
                    if (topSales == dSales)
                    {
                        Console.WriteLine($"{salespeople[0]} has the most sales");
                    }
                    else if (topSales == eSales)
                    {
                        Console.WriteLine($"{salespeople[1]} has the most sales");
                    }
                    else if (topSales == fSales)
                    {
                        Console.WriteLine($"{salespeople[2]} has the most sales");
                    }
                    break;
                }
                else if (initial == 'd' || initial == 'e' || initial == 'f')
                {
                    Console.Write($"How much was the sale?\n");
                    double sale = double.Parse(Console.ReadLine());
                    switch (initial)
                    {
                        case 'd':
                            dSales += sale;
                            break;
                        case 'e':
                            eSales += sale;
                            break;
                        case 'f':
                            fSales += sale;
                            break;
                    }
                    grandTotal += sale;
                }
                else
                {
                    Console.WriteLine("Invalid initial.");
                }
            }
        }
    }
}
