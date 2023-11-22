using System;
namespace backToTheFuture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;
            double spentMoney = 0;

            for (int i = 1800; i <= year; i++)
            {                               
                if (i % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else
                {
                    spentMoney += 12000 + (50 * age);
                }
                age++;
            }
            double diff = Math.Abs(inheritedMoney - spentMoney);
            
            if (inheritedMoney >= spentMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
        }
    }
}