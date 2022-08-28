using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Node
    {
        public int data;
        //here Node is a type of data
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
