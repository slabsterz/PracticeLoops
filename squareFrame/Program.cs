using System;
namespace squareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write("+");

            for (int i = 0; i < number-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int row = 0; row < number-2; row++)
            {
                Console.Write("|");
                for (int i = 0; i < number-2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int i = 0; i < number-2; ++i)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }

    }
}