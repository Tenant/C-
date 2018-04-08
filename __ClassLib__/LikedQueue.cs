using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
     public class LikedQueue
    {
        public Node head ;
        public Node tail ;
        public Node current;
        public LikedQueue()
        {
            head = null;
            tail = null;
        }

        public void push(Student s)
        {
            Node newnode = new Node(s);
            if (isEmpty())
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
            }
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public void gotoHead()
        {
            current = head;
        }

        public Student getvalue()
        {
            return current.getValue();
        }

        public void next()
        {
            current = current.next;
        }

        public bool isEnd()
        {
            return current == null;
        }

        public bool pop(out Student data)
        {
            data = null;
            if (isEmpty())
                return false;
            data = head.getValue();
            head=head.next;
            return true;
        }

    }
}
