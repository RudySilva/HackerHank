﻿using System;
using System.Collections.Generic;
using System.Text;


namespace HackerHank { 
    class Inheritance
    {
        public static void Execute()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int identification, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        public string Calculate() {
            int avarage = 0;
            int[] scores = testScores;
            int sum = 0;

            foreach (int item in scores)
            {
                sum += item;
            }

            avarage = sum / scores.Length;

            string grade = string.Empty;

            if (avarage >= 90 && avarage <= 100)
            {
                grade = "O";
            }
            else if (avarage >= 80 && avarage < 90)
            {
                grade = "E";
            }
            else if (avarage >= 70 && avarage < 80)
            {
                grade = "A";
            }
            else if (avarage >= 55 && avarage < 70)
            {
                grade = "P";
            }
            else if (avarage >= 40 && avarage < 55)
            {
                grade = "D";
            }
            else if (avarage < 40)
            {
                grade = "T";
            }

            return grade;
        }

        // Write your method here
    }


}
