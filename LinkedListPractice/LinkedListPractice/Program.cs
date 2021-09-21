using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            
            LinkedList<int> element = new LinkedList<int>();//Create object
            //Add Element
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.RemoveLast();
            element.Display();

        }
    }
}
