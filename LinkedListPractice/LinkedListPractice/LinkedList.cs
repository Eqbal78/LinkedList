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

            // Intializing new node as a head 
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                // Create a temprory node
                Node<Gtype> temp = head;
                // Else traverse till the last node //
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            
            Console.WriteLine("{0} insert into linked list ", node.data);
        }

        /// <summary>
        /// Append Element in LinkedList
        /// </summary>
        /// <param name="new_data"></param>
        public void append(Gtype new_data)
        {
            
            // Allocate the Node & Put in the data//
            Node<Gtype> new_node = new Node<Gtype>(new_data);
            
            // If the Linked List is empty, then make the new node as head //
            if (head == null)
            {
                head = new Node<Gtype>(new_data);
                return;
            }

            //This new node is going to be the last node,so make next of it as null //
            new_node.next = null;

            // Else traverse till the last node //
            Node<Gtype> last = head;
            while (last.next != null)
                last = last.next;

            //Change the next of last node //
            last.next = new_node;
            return;
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
            // Else traverse till the last node //
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
        }

       

    }
}
