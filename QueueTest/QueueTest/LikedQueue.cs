using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueTest
{
     public class LikedQueue //用链表写的队列哟
    {
        public Node head ;
        public Node tail ;
        public Node current; //属性全部定义为public，只是为了方便
        
         public LikedQueue() //构造函数，一定是public，不能定义返回值类型
        {
            head = null; //对象类型数据，初始化为null
            tail = null;
        }

        public void push(Student s) //向队列中追加新数据
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

        public bool isEmpty() //判断队列是否为空
        {
            return head == null;
        }

        public void gotoHead() //将current（指针）定义为head
        {
            current = head;
        }

        public Student getvalue() //返回current内存储的数据
        {
            return current.getValue();
        }

        public void next() // 将current后移一位
        {
            current = current.next;
        }

        public bool isEnd() //判断current是否越过队列最后，队列遍历结束
        {
            return current == null;
        }

        public bool pop(out Student data) //返回队列最早追加的数据
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
