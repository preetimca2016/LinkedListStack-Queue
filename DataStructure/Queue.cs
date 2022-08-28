using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        LinkedList linkedList;
        public Queue()
        {
           linkedList = new LinkedList();
        }
        public void Enqueue(Node node)
        {
            linkedList.AppendNode(node);
        }
        public void DisplayQueue()
        {
            Console.WriteLine("Queue");
            linkedList.Display();
        }
        public void Dequeue()
        {
            linkedList.DeleteNodeAtLast();
        }
    }
}
