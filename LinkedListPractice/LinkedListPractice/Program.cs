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
            element.Add(70);

            Console.WriteLine("The list before inserting 30 is : ");
            element.Display();
            element.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            element.Display();
            //obj.append(56);
            //obj.append(30);
            //obj.append(70);
            //obj.Display();
        }
    }
}
