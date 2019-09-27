using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class QueuesStacks
    {

        Stack<Char> stack = new Stack<Char>();
        Queue<Char> queue = new Queue<Char>();
        //string stack;
        //string queue;

        void pushCharacter(char c)
        {
            stack.Push(c);
            //stack += c;
            //stack += c;
        }

        void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
            //queue += queue;
            //queue = c + queue;
        }
        char popCharacter()
        {
            return stack.Pop();
            //char c = Convert.ToChar(stack.Substring(stack.Length-1,1));
            //stack = stack.Substring(1, stack.Length - 1);
            //return c;
        }

        char dequeueCharacter()
        {
            return queue.Dequeue();

            //char c = Convert.ToChar(queue.Substring(0, 1));
            //queue = queue.Substring(1, queue.Length -1);
            //return c;
        }

        public static void Execute()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            QueuesStacks obj = new QueuesStacks();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
