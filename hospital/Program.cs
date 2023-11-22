using System;
namespace hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialDoctors = 7;
            int days = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreated = 0;
            int countDays = 0;


            for (int i = 0; i < days; i++)
            {
                
                countDays++;

                if (countDays >= 3 && untreated > treatedPatients) 
                {
                    initialDoctors++;
                    countDays = 0;
                }

                
                int patientsForDay = int.Parse(Console.ReadLine());

                if (patientsForDay > initialDoctors)
                {
                    untreated += patientsForDay - initialDoctors;
                    treatedPatients += initialDoctors;
                }
                else
                {
                    treatedPatients += patientsForDay;
                }

                           
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}