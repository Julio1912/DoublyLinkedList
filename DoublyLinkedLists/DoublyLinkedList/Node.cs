using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoublyLinkedList
{
    class Node
    {
        public Node prev { get; set; }
        public Node next { get; set; }
        public int value { get; set; }
        public Node(Node prev,Node next,int value) {
            this.prev = prev;
            this.next = next;
            this.value = value;
        }
    }
}
