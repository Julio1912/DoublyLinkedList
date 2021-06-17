using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        public Node insertbegdoubly(Node first,int value) {
            Node ptr = first;
            Node temp = new Node(null,ptr,value);
            ptr.prev = temp;
            first = temp;
            return first;
        }

        public Node Insertenddoubly(Node first,int value) {
            Node ptr = first;
            while( ptr.next!=null){
                ptr = ptr.next;
            }
            Node temp = new Node(ptr,null,value);
            ptr.next = temp;
            return first ;
        }

        public void GetElement(Node first) {
            Node ptr = first;
            while(ptr!=null){
                Console.Write(ptr.value+" ");
                ptr = ptr.next;
            }
            Console.WriteLine();
        }
    }
}
