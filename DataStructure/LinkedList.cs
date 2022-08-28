using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is Empty");
            else
                Console.WriteLine("Linked List:");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                if (temp.next != null)
                    Console.WriteLine("->");
                temp = temp.next;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }           
        }
        public void InsertNode(Node NewNode, Node PreviousNode)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == PreviousNode.data)
                {
                    if (temp == Tail)
                    {
                        Tail = NewNode;
                    }
                    NewNode.next = temp.next;
                    temp.next = NewNode;

                    break;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Node not Found");
            }                
        }
        public void DeleteNodeAtFirst()
        {
            //check list is empty or node
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            //put temp variabe become head in list 
            Node temp = this.Head;
            //change head to next node to delete the previous node 
            this.Head = this.Head.next;

            Console.WriteLine("Remove from linkedlist :"+temp.data);
        }
        public void DeleteNodeAtLast() //56 70 30 40
        {
            //check list is empty or node
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            //temp variable will become head of this list now
            Node temp = this.Head;
            //check until the temp next node's next lpcation is null
            while (temp.next.next != null)
            {
                //for traversing through the list
                temp = temp.next;
            }
            //After getting this node change its location to null
            temp.next = null;
        }

        //check if list is empty then new node become head node
        //public void AddNodeAtStart(Node node)
        //{
        //    if (this.Head == null)
        //    {
        //        this.Head = node;
        //    }
        //    if (this.Tail == null)
        //    {
        //        this.Tail = node;
        //    }
        //    else
        //    {

        //}
        //}
    }
}
