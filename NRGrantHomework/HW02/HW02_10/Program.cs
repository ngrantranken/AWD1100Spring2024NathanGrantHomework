namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows should the table have?\n");
            int rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many columns should the table have?\n");
            int cols = Int32.Parse(Console.ReadLine());

            Console.Write("    |");

            for (int i = 1; i <= cols; i++) 
            {
                Console.Write($"{i,4}|");
            }

            Console.WriteLine("\n------------------------------------------------------------------");
            
            for (int j = 1; j <= rows; j++)
            {
                Console.Write($"{j,4}|");
                for (int k = 1; k <= cols; k++)
                {
                    Console.Write($"{j * k,4}|");
                }
                Console.WriteLine();
            }
        }
    }
}
