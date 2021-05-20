using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingWageMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int monthlyWage = 3000;
            int months = 12;
            double monthlyWageDouble = 4000;
            double monthsDouble = 12;
            int bonus = 33;
            double bonusDouble = 37;
            int yearlyWage = CalculateYearlyWage(monthlyWage, months);
            int yearlyWage2 = CalculateYearlyWage(monthlyWage, months, bonus);
            double yearlyWage3 = CalculateYearlyWage(monthlyWageDouble, monthsDouble, bonusDouble);
            Console.WriteLine($"Yearly wage, from main: {yearlyWage}");
            Console.WriteLine($"Yearly wage, from main, plus bonus: {yearlyWage2}");
            Console.WriteLine($"Yearly wage as a double, from main, plus bonus: {yearlyWage3}");
            Console.ReadLine();
        }
        //overloading a method
        public static int CalculateYearlyWage (int monthlyWage, int numberHoursWorked)
        {
            return monthlyWage * numberHoursWorked;
        }
        //and another parameter
        public static int CalculateYearlyWage(int monthlyWage, int months, int bonus)
        {

            return (monthlyWage * months) + bonus;
        }
        //substitute double for int
        public static double CalculateYearlyWage(double monthlyWageDouble, double monthsDouble, double bonus)
        {

            return (monthlyWageDouble * monthsDouble) + bonus;
        }
    }
}
