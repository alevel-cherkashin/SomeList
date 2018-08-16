using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeList
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList myList = new MyList();

            myList.Add(new Node() { Value = 10 });
            myList.Add(new Node() { Value = 20 });
            myList.Add(new Node() { Value = 30 });
            myList.Add(new Node() { Value = 40 });
            myList.Add(new Node() { Value = 50 });
            myList.Add(new Node() { Value = 60 });
            myList.Add(new Node() { Value = 70 });
            myList.Add(new Node() { Value = 90 });
            myList.Add(new Node() { Value = 100 });

            myList.OutputAllNodes();

            myList.Remove(10);
            Console.WriteLine();
            myList.OutputAllNodes();

            myList.Remove(100);
            Console.WriteLine();
            myList.OutputAllNodes();

            myList.Remove(50);
            Console.WriteLine();
            myList.OutputAllNodes();

            myList.Add(new Node() { Value = 111 });
            Console.WriteLine();
            myList.OutputAllNodes();

            Console.ReadKey();
        }
    }
}
