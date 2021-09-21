using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class LinkedList<Gtype>
    {
        public Node<Gtype> head;
        public void Add(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} insert into linked list ", node.data);
        }

    }
}
