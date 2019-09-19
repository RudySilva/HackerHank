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
            Console.WriteLine("0 - SimpleArraySum ;");
            Console.WriteLine("1 - DataTypes;" );
            Console.WriteLine("2 - Operators;");
            Console.WriteLine("3 - Conditional;");
            Console.WriteLine("4 - ClassVsInstance;");
            Console.WriteLine("5 - Loops;");
            Console.WriteLine("6 - Review;");
            Console.WriteLine("7 - Arrays;");
            Console.WriteLine("8 - DictonariesMaps;");
            Console.WriteLine("9 - Recursion;");
            Console.WriteLine("10 - Binary Numbers;");
            Console.WriteLine("11 - 2D Arrays;");
            day = Console.ReadLine();

            switch (day)
            {
                case "0":
                    Console.WriteLine("0 - SimpleArraySum - Executing...");
                    SimpleArraySum.Execute();
                    break;

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
                case "6":
                    Console.WriteLine("6 - Review - Executing...");
                    Review.Execute();
                    break;
                case "7":
                    Console.WriteLine("7 - Arrays - Executing...");
                    Arrays.Execute();
                    break;
                case "8":
                    Console.WriteLine("8 - DictonariesMaps - Executing...");
                    DictionariesMaps.Execute();
                    break;
                case "9":
                    Console.WriteLine("9 - Rercursion - Executing...");
                    Recursion.Execute();
                    break;
                case "10":
                    Console.WriteLine("10 - Binary Numbers- Executing...");
                    BinaryNumbers.Execute();
                    break;
                case "11":
                    Console.WriteLine("11 - 2D Arrays- Executing...");
                    _2DArrays.Execute();
                    break;
                default:

                    break;
            }


        }
    }
}
