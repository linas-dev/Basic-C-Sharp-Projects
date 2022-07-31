using System;

namespace anonymousIncomeComparisonProgram
{
    internal class anonymousIncomeComparisonProgram
    {
        public static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            
            Console.WriteLine("Person 1:");
            Console.WriteLine("");
            
            Console.WriteLine("Hourly rate?");
            string hourlyRatePersonOne = Console.ReadLine();
            byte convertedHourlyRatePersonOne = Convert.ToByte(hourlyRatePersonOne);
            Console.WriteLine("");
            
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeekPersonOne = Console.ReadLine();
            byte convertedHoursWorkedPerWeekPersonOne = Convert.ToByte(hoursWorkedPerWeekPersonOne);
            Console.WriteLine("");
            
            
            Console.WriteLine("Person 2:");
            Console.WriteLine("");
            
            Console.WriteLine("Hourly rate?");
            string hourlyRatePersonTwo = Console.ReadLine();
            byte convertedHourlyRatePersonTwo = Convert.ToByte(hourlyRatePersonTwo);
            Console.WriteLine("");
            
            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeekPersonTwo = Console.ReadLine();
            byte convertedHoursWorkedPerWeekPersonTwo = Convert.ToByte(hoursWorkedPerWeekPersonTwo);
            Console.WriteLine("");


            Console.WriteLine("Annual salary of Person 1");
            int annualSalaryPersonOne = (convertedHourlyRatePersonOne * convertedHoursWorkedPerWeekPersonOne * 4) * 12;
            Console.WriteLine(annualSalaryPersonOne);
            
            Console.WriteLine("Annual salary of Person 2");
            int annualSalaryPersonTwo = (convertedHourlyRatePersonTwo * convertedHoursWorkedPerWeekPersonTwo * 4) * 12;
            Console.WriteLine(annualSalaryPersonTwo);


            if (annualSalaryPersonOne < annualSalaryPersonTwo)
            {
                Console.WriteLine("Person 1 makes more money than Person 2");
                Console.WriteLine(false);
            }

        }
    }
}