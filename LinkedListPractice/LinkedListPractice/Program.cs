using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            
            LinkedList<int> obj = new LinkedList<int>();//Create object
            //Add Element
            obj.Add(56);
            obj.Add(30);
            obj.Add(70);
            obj.Display();
        }
    }
}
