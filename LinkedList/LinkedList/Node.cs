using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public Student data;
        public Node next;
        public Node(Student data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
