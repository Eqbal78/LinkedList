using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class Operation
    {
        /// <summary>
        /// Create Static Method to Add Element
        /// </summary>
        public static void AddElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            //Add Element
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.Display();
        }

        /// <summary>
        /// Create Static Method to Append Element
        /// </summary>
        public static void AppendElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object

            element.append(56);
            element.append(30);
            element.append(70);
            element.Display();
        }

        /// <summary>
        /// Create Static Method to Insert Element in Middle
        /// </summary>
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


        /// <summary>
        /// Create Static Method to Remove First Element
        /// </summary>
        public static void RemoveFirstElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            element.Add(56);
            element.Add(30);
            element.Add(70);
            element.RemoveFirst();
            element.Display();
        }

        /// <summary>
        /// Create Static Method to Remove Last Element
        /// </summary>
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

        /// <summary>
        /// Create Static Method to Search Element
        /// </summary>
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

        /// <summary>
        /// Create Static Method to Insert Element in Any Position
        /// </summary>

        public static void InsertAtPositionElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            element.Add(56);
            element.Add(30);
            element.Add(70);

            Console.WriteLine("The list before inserting 40 is : ");
            element.Display();
            element.InsertAtParticularPosition(3, 40);
            Console.WriteLine("The list after inserting 40 is : ");
            element.Display();
        }

        /// <summary>
        /// Create Static Method to Delete Element in Any Position
        /// </summary>
        public static void DeleteAtPositionElement()
        {
            LinkedList<int> element = new LinkedList<int>();//Create object
            element.Add(56);
            element.Add(30);
            element.Add(40);
            element.Add(70);

            Console.WriteLine("The list before Deleting 40 is : ");
            element.Display();
            element.Delete(40);
            Console.WriteLine("The list after Deleting 40 is : ");
            element.Display();

            Console.WriteLine("After Deleting Size of linked List is:");
            Console.WriteLine(element.Size()); 
            

        }

        public static void SortedElement()
        {
            ShortedLinkedList<int> element = new ShortedLinkedList<int>();
            LinkedList<int> element1 = new LinkedList<int>();//Create object
            Console.WriteLine("The list before Shorting is : \n");
            element1.Add(56);
            element1.Add(30);
            element1.Add(40);
            element1.Add(70);
            
            Console.WriteLine("\nThe list after Shorting is : ");
            element.Add(56);
            element.Add(30);
            element.Add(40);
            element.Add(70);
            element.DisplaySort();
            
        }

    }
}
