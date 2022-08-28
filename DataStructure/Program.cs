using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            Node node4 = new Node(68);

            Console.WriteLine("Enter the Number");
            Console.WriteLine("case 1 for AddNode");
            Console.WriteLine("case 2: for insertNode");
            Console.WriteLine("case 3: for appened");
            Console.WriteLine("case 4 for Delete");
            int Ans = Convert.ToInt32(Console.ReadLine());

            switch (Ans)
            {
                case 1:
                    linked.AddNode(node1);
                    linked.AddNode(node2);
                    linked.AddNode(node3);
                    linked.AddNode(node4);
                    linked.Display();
                    break;
                case 2:
                    linked.InsertNode(node4, node1); 
                    linked.Display();
                    break;

                //linked.Display();

                case 3:
                    linked.AppendNode(node1);
                    linked.AppendNode(node2);
                    //linked.AppendNodeAtStart(node3);
                    linked.Display();
                    break;
                case 4:
                    linked.DeleteNodeAtLast();
                    linked.DeleteNodeAtFirst();
                    linked.Display();
                    break;
            }

        }
    }
}