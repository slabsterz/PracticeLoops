using System;
namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumbers = int.Parse(Console.ReadLine());
            int divided2 = 0;
            int divided3 = 0;
            int divided4 = 0;

            for (int i = 0; i < maxNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());

               if (input % 2 == 0)
                {
                    divided2++;
                }
              if (input % 3 == 0)
                {
                    divided3++;
                }
               if (input % 4 == 0)
                {
                    divided4++;
                }

               

            }
            double percent2 = (double)divided2 / maxNumbers * 100;
            double percent3 = (double)divided3 / maxNumbers * 100;
            double percent4 = (double)divided4 / maxNumbers * 100;

            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
        }
    }
}