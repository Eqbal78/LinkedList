using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class Node<Gtype>
    {
        public Gtype data;
        public Node<Gtype> next;
        internal Node<Gtype> nextNode;

        public Node(Gtype value)
        {
            this.data = value;
        }
    }
}
