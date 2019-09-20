using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{

    public abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();



    }

    class MyBook : Book
    {
        protected int price;

        public MyBook(String title, String author, int price) : base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;

        }

        public  override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + this.price.ToString());
        }

    }

        
    class Abstract
    {
        public static void Execute()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

    }

}
