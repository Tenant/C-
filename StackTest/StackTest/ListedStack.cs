using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackTest
{
    public class ListedStack //用链表写的堆栈哟
    {
        private Node top=null; //对象类型数据，初始化为null

        public bool isEmpty() //判断stack是否为空
        {
            return top == null;
        }

        public void push(Student newstudent) //返回堆栈最后追加的数据并从堆栈中清除该数据
        {
            Node newnode = new Node(newstudent);
                newnode.next = top;
                top = newnode;
            
        }

        public bool pop(out Student newstudent) //向堆栈中追加数据
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
