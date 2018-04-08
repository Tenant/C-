using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueTest
{
    public class Node
    {
        private Student data;
        public Node next;

        public Node(Student data)
        {
            this.data = data;
            this.next = null;
        }

        public Node()
        {
            this.data = null;
            this.next = null;
        }

        public Student getValue()
        {
            return this.data;
        }
    }
}
