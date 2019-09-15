using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Program
    {
        static void Main(String[] args)
        {
            string day;

            Console.WriteLine("Type the number of challenge that you desire to execute:");
            
            Console.WriteLine("1 - DataTypes;" );
            Console.WriteLine("2 - Operators;");
            Console.WriteLine("3 - Conditional;");
            Console.WriteLine("4 - ClassVsInstance;");
            Console.WriteLine("5 - Loops;");

            day = Console.ReadLine();

            switch (day)
            {

                case "1":
                    Console.WriteLine("1 - DataTypes - Executing...");
                    DataTypes.Execute();
                    break;
                case "2":
                    Console.WriteLine("2 - Operators - Executing...");
                    Operators.Execute();
                    break;
                case "3":
                    Console.WriteLine("3 - Conditional - Executing...");
                    Conditional.Execute();
                    break;
                case "4":
                    Console.WriteLine("4 - ClassVsInstance - Executing...");
                    Person.Execute();
                    break;
                case "5":
                    Console.WriteLine("5 - Loops - Executing...");
                    Loops.Execute();
                    break;
                default:
                    break;
            }


        }
    }
}
