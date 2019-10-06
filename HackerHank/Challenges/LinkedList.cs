using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{

    class _Node
    {
        public int data;
        public _Node next;
        public _Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class LinkedList
    {
        public static _Node insert(_Node head, int data)
        {
            if (head == null)
                return new _Node(data);
            else if (head.next == null)
                head.next = new _Node(data);
            else
                insert(head.next, data);

            return head;
        }

        public static void display(_Node head)
        {
            _Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Execute()
        {
            _Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
