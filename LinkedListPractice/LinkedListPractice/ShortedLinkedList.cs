using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class ShortedLinkedList<Gtype> where Gtype : IComparable
    {
        internal Node<Gtype> head;
        
        /// <summary>
        /// This Method give Shorted Element 
        /// </summary>
        /// <param name="data"></param>
        public void Add(Gtype data)
        {
            //Create Empty node
            Node<Gtype> node = new Node<Gtype>(data);
            //Create current Node is Head
            Node<Gtype> current = head, previous = null;
            // traverse till the last node and check smallest element //
            while (current != null && current.data.CompareTo(node.data)<0)
            {
                //Swap the element
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;

        }

        /// <summary>
        /// Display the Sorted Element
        /// </summary>
        internal void DisplaySort()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node<Gtype> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
