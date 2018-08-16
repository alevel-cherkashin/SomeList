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
            Node temp = Head;
            Node temp2 = Tail;
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
         
                node = node.Next;

                if (node.Next.Value == value)
                {
                    if (node.Next == Tail)
                    {
                        Tail = node;
                        break;
                    }

                    while (temp != temp2)
                    {
                        if (temp == Head)
                        {
                            Tail = temp;
                        }
                        if (temp == node)
                        {
                            temp = temp.Next;
                        }

                        temp = temp.Next;
                        Tail.Next = temp;
                        Tail = temp;
                    }
                    break;
                }
            }
            while (node != Head);
        }
    }
}
