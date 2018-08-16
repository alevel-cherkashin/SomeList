using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeList
{
    public class MyList : ILinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Add(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

        public void OutputAllNodes()
        {
            Node node = Head;

            while (node != Tail)
            {
                Console.WriteLine("Value = " + node.Value);
                node = node.Next;

                if (node == Tail)
                {
                    Console.WriteLine("Value = " + node.Value);
                }
            }
        }

        public void Remove(int value)
        {
            Node node = Head;
            Node temp = Tail;
            do
            {
                if (node.Value == value)
                {
                    if (node == Head)
                    {
                        Head = node.Next;
                        break;
                    }
                }

                if (node == Tail)
                {

                }
                //if (node.Next.Value == value)
                //{
                //    while (true)
                //    {
                //        if (Tail == node)
                //        {
                //            Tail = node.Next.Next;

                //            break;
                //        }

                //        Tail = Tail.Next;
                //    }
                //        break;

                //}

                node = node.Next;

                if (node.Next == Head)
                {
                    Head = node;
                }
            }
            while (node != Head);

        }
    }
}
