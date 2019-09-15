using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Operators
    {
        
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double total = 0;
            double tip = 0;
            double tax = 0;

            tip = meal_cost * Convert.ToDouble(tip_percent) / 100;
            tax = meal_cost * Convert.ToDouble(tax_percent) / 100;

            total = meal_cost + tip + tax;

            Console.WriteLine(Math.Round(total, MidpointRounding.AwayFromZero));

        }

        public static void Execute()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
        
    }
}
