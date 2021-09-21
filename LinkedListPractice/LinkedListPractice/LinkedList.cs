using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    /// <summary>
    /// create a linkedList class Generic type
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    class LinkedList<Gtype>
    {
        
        public Node<Gtype> head;
        /// <summary>
        /// Add Node in LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void Add(Gtype data)
        {
            //Create Empty node
            Node<Gtype> node = new Node<Gtype>(data);

            // Intializing head 
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                // Create a temprory node
                Node<Gtype> temp = head;
              
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            
            Console.WriteLine("{0} insert into linked list ", node.data);
        }
        /// <summary>
        /// Display the LinkedList
        /// </summary>
        public void Display()
        {
            //Create temp Node and Intialised as head
            Node<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("the linked list is empty");
                return;
            }
            //add node one by one
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
        }

    }
}
