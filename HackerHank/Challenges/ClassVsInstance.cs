using System;
using System.Collections.Generic;
using System.IO;

class ClassVsInstance
{
    public int age;
    public ClassVsInstance(int initialAge)
    {
        if (initialAge > 0)
            age = initialAge;
        else
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
            
        
        // Add some more code to run some checks on initialAge
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        age += 1;
        // Increment the age of the person in here
    }

    public static void Execute()
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            ClassVsInstance p = new ClassVsInstance(age);
            
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}

    