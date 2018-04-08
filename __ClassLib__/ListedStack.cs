using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class ListedStack
    {
        private Node top=null;
		
        public bool isEmpty()
        {
            return top == null;
        }
        public void push(Student newstudent)
        {
            Node newnode = new Node(newstudent);
            newnode.next = top;
            top = newnode; 
        }

        public bool pop(out Student newstudent)
        {
            newstudent=null;
            if (!isEmpty())
            { 
                newstudent = top.getValue();
                top = top.next;
                return true;
            }
            return false;      
        }

    }
}
