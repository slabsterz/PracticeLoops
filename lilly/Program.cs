namespace lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());   
            int toyPrice = int.Parse(Console.ReadLine());
            const double brotherTax = 1;

            double moneySaved = 0;
            double moneyRaise = 0;
            double toyCount = 0;

            for (int i = 1; i <= age; i++)
            {
               
            if (i % 2 != 0)
                {
                    toyCount++;
                }
            else if (i == 2)
                {
                    moneyRaise += 10;
                    moneySaved += moneyRaise;
                    moneySaved -= brotherTax;
                    continue;
                }
            
            if (i % 2  == 0)
                {
                    moneyRaise += 10;
                    moneySaved += moneyRaise;
                    moneySaved -= brotherTax;                    
                }                

            }
            double soldToys = toyCount * toyPrice;
            double totalMoneySaved = soldToys + moneySaved;
            double diff = Math.Abs(totalMoneySaved - washingMachine);

            if (totalMoneySaved > washingMachine)
            {
                Console.WriteLine($"Yes! {diff:f2}");               
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}