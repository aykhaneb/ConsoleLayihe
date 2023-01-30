using System;

namespace ConsoleApp11
{
    public class Zal : Entity
    {
        public string Name { get; set; }
        public int[,] Seats { get; set; }
        public static string[,] Arr()
        {
            string[,] seats = new string[10, 10];
            Console.Write("    ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1,-6}");
            }
            Console.WriteLine();

            for (int row = 0; row < 10; row++)
            {
                Console.Write($"{row + 1,-3} ");
                for (int column = 0; column < 10; column++)
                {
                    Console.Write($"{seats[row, column] = "Empty"} ");
                }
                Console.WriteLine();
            }
            return seats;
        }
        public override string ToString()
        {

            return $" {Name} ";

        }
    }
}