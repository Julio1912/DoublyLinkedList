using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(null,null,1);
            DoublyLinkedList d = new DoublyLinkedList();
            Console.WriteLine("INSERTION AT THE BEGINNING DOUBLY ");
            n=d.insertbegdoubly(n,2);
            d.GetElement(n);
            Console.WriteLine("INSERTION AT THE END DOUBLY");
            n = d.Insertenddoubly(n, 0);
            d.GetElement(n);
            Console.ReadLine();
        }
    }
}
