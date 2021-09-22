using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class Operation
    {

        public static void AddElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            //Add Element
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.Display();
        }
        public static void AppendElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object

            element.append(56);
            element.append(30);
            element.append(70);
            element.Display();
        }
        public static void InsertElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            element.Add(56);
            element.Add(70);

            Console.WriteLine("The list before inserting 30 is : ");
            element.Display();
            element.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            element.Display();
        }

        public static void RemoveFirstElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.RemoveFirst();
            element.Display();
        }

        public static void RemoveLastElement()
        {

            LinkedList<int> element = new LinkedList<int>();//Create object
            //Add Element
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.RemoveLast();
            element.Display();
        }

        public static void SearchElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            //Add Element
            element.Add(56);
            element.Add(30);
            element.Add(70);
        
            Console.WriteLine("Serach elment");
            element.Search(30);
            element.Display();
        }

    }
}
