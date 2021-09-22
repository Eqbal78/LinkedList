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
        /// Insert the element in middle
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertAtParticularPosition(int position, Gtype data)
        {
            // Allocate the Node & Put in the data//
            Node<Gtype> node = new Node<Gtype>(data);

            //Check the position
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<Gtype> temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        /// <summary>
        /// Delete the first node in LinkList
        /// </summary>
        /// <returns></returns>
        public Node<Gtype> RemoveFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        /// <summary>
        /// Remove last Node in Linkedlist
        /// </summary>
        /// <returns></returns>
        public Node<Gtype> RemoveLast()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            // traverse till the last node //
            Node<Gtype> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;

        }

        /// <summary>
        /// Searching the Element in Node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<Gtype> Search(int value)
        {
            //traverse till the last node //
            while (this.head != null)
            {
                //Check Data is equal to value
                if (this.head.data.Equals(value))
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }



        /// <summary>
        /// Display the LinkedList
        /// </summary>
        public void Display()
        {
            //Create temp Node and Intialised as head//
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

        /// <summary>
        /// Deleting the Node at any position
        /// </summary>
        /// <param name="data"></param>
        public void Delete(int data)
        {
            //Create temp Node and Intialised as head//
            Node<Gtype> temp = head, previous = null;
            if (temp != null && temp.data.Equals(data))
            {
                head = temp.next;
                return;
            }
            // traverse till the last node and also check temperory data to data //
            while (temp != null && !temp.data.Equals(data))
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }

        /// <summary>
        /// After Deleting Calculate the size
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int size = 0;
            Node<Gtype> temp = head;
            // traverse till the last node //
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

    }
}
