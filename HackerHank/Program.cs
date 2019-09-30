using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Program
    {
        static void Menu()
        {
            string day;

            Console.WriteLine("Type the number of challenge that you desire to execute:");
            Console.WriteLine("0 - SimpleArraySum;");
            Console.WriteLine("1 - DataTypes;");
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
            Console.WriteLine("12 - Inheritance;");
            Console.WriteLine("13 - Abstract;");
            Console.WriteLine("14 - Scope;");
            Console.WriteLine("15 - Linked List;");
            Console.WriteLine("16 - Exception - String to Integer;");
            Console.WriteLine("17 - More Exceptions;");
            Console.WriteLine("18 - Queues and Stacks;");
            Console.WriteLine("19 - Interfaces;");
            Console.WriteLine("20 - Sorting;");
            Console.WriteLine("21 - Generics;");
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
                    ClassVsInstance.Execute();
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
                    Console.WriteLine("10 - Binary Numbers - Executing...");
                    BinaryNumbers.Execute();
                    break;
                case "11":
                    Console.WriteLine("11 - 2D Arrays - Executing...");
                    _2DArrays.Execute();
                    break;
                case "12":
                    Console.WriteLine("12 - Inheritance - Executing...");
                    Inheritance.Execute();
                    break;
                case "13":
                    Console.WriteLine("13 - Abstract - Executing...");
                    Abstract.Execute();
                    break;
                case "14":
                    Console.WriteLine("14 - Scope - Executing...");
                    Scope.Execute();
                    break;
                case "15":
                    Console.WriteLine("15 - Linked List - Executing...");
                    LinkedList.Execute();
                    break;
                case "16":
                    Console.WriteLine("16 - Exception - String to Integer - Executing...");
                    ExceptionStringToInt.Execute();
                    break;
                case "17":
                    Console.WriteLine("17 - More Exceptions - Executing...");
                    MoreExceptions.Execute();
                    break;
                case "18":
                    Console.WriteLine("18 - Queues and Stacks - Executing... ");
                    QueuesStacks.Execute();
                    break;
                case "19":
                    Console.WriteLine("19 - Interfaces - Executing... ");
                    Interfaces.Execute();
                    break;
                case "20":
                    Console.WriteLine("20 - Sorting - Executing... ");
                    Sorting.Execute();
                    break;
                case "21":
                    Console.WriteLine("21 - Generics - Executing... ");
                    Generics.Execute();
                    break;
                default:
                    Menu();

                    break;
            }
        }
        static void Main(String[] args)
        {
            Menu();
        }
    }
}
