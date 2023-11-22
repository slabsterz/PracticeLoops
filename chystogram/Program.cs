using System;

namespace chystogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumbers = int.Parse(Console.ReadLine());
            int group = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < maxNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());

                switch (group)
                {
                    case var n when input < 200: p1++; break;
                    case var n when input >= 200 && input < 400: p2++; break;
                    case var n when input >= 400 && input < 600: p3++; break;
                    case var n when input >= 600 && input < 800: p4++; break;
                    default: p5++; break;
                }
            }

                double p1percent = (double)p1 / maxNumbers * 100;
                double p2percent = (double)p2 / maxNumbers * 100;
                double p3percent = (double)p3 / maxNumbers * 100;
                double p4percent = (double)p4 / maxNumbers * 100;
                double p5percent = (double)p5 / maxNumbers * 100;

                Console.WriteLine($"{p1percent:f2}%");
                Console.WriteLine($"{p2percent:f2}%");
                Console.WriteLine($"{p3percent:f2}%");
                Console.WriteLine($"{p4percent:f2}%");
                Console.WriteLine($"{p5percent:f2}%");

            }
        }
    }