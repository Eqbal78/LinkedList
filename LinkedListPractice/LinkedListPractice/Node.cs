using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    /// <summary>
    /// Class Node with Generic type
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    public class Node<Gtype>
    {
        /// <summary>
        /// Declare the Node and Data
        /// </summary>
        public Gtype data;
        public Node<Gtype> next;
        internal Node<Gtype> nextNode;

        /// <summary>
        /// Declare Constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(Gtype value)
        {
            this.data = value;
            
        }
    }
}
