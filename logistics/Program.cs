using System;
namespace logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int busCount = 0;
            int truckCount = 0;
            int trainCount = 0;
            double busPercent = 0;
            double truckPercent = 0;
            double trainPercent = 0;
            double totalPrice = 0;
            int totalWeight = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                totalWeight += weight;

                if (weight <= 3)
                {                   
                    totalPrice += weight * 200;
                    busCount += weight;
                }
                else if (weight > 3 && weight <= 11)
                {
                    totalPrice += weight * 175;
                    truckCount += weight;
                }
                else
                {
                    totalPrice += weight * 120;
                    trainCount += weight;
                }
            }
            busPercent = (double)busCount / totalWeight * 100;
            truckPercent = (double)truckCount / totalWeight * 100;
            trainPercent = (double)trainCount / totalWeight * 100;

            Console.WriteLine($"{totalPrice / totalWeight:f2}");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}