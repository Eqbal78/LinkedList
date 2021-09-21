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
            element.RemoveFirst();
            element.Display();

            //Insert the element between two node

            /* Console.WriteLine("The list before inserting 30 is : ");
             element.Display();
             element.InsertAtParticularPosition(2, 30);
             Console.WriteLine("The list after inserting 30 is : ");
             element.Display();*/

        }
    }
}
