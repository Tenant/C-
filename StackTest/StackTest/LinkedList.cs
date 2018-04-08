using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackTest
{
    public class LinkedList
    {
        private Node head=null;
        private Node tail=null;
        private Node current=null;

        private bool isEnd()
        {
            return current ==null;
        }

        private void goHead()
        {
            current = head;
        }

        private void goNext()
        {
            current = current.next;
        }

        private bool isEmpty()
        {
            goHead();
            if (isEnd())
                return true;
            return false;
        }

        public Node getHead()
        {
            return head;
        }

        public void insertInFront(Student newstudent)
        {
            if (isEmpty())
            {
                head = new Node(newstudent);
                tail=head;
                return;
            }
            Node current = new Node(newstudent);
            current.next = head;
            head = current;
        }

        public void append(Student newstudent)
        {
            Node newnode =new Node(newstudent);
            if (isEmpty())
            {
                head=newnode;
                tail=head;
                return;
            }
            tail.next = newnode;
            tail = newnode;
        }

        public LinkedList Reverse()
        {
            LinkedList RevList=new LinkedList();
            ListedStack MyStack = new ListedStack();
            goHead();
            while (!isEnd())
            {
                MyStack.push(current.getValue());
                goNext();
            }
            while(!MyStack.isEmpty())
            {
                Student newstudent;
                MyStack.pop(out newstudent);
                RevList.append(newstudent);
            }
            return RevList;
        }

    }
}
