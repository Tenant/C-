using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTest
{

    public class LinkedList
    {
        public Node head ;
        public Node tail ;
        public Node newnode;
        public LinkedList()
        {
            head = null;
            tail = null;
            //head = new Node();
            //tail = new Node();
        }

        //在链表最后追加新节点
        public void append(Student s)
        {
            Node newone = new Node(s);
            if (isEmpty())
            {
                head = newone;
                tail = newone;
            }
            else
            {
                tail.next = newone;
                tail = newone;
            }
        }

        //检查链表是否为空
        public bool isEmpty()
        {
            return head == null;
        }

        public void gotoHead()
        {
            newnode = head;
        }

        public Student getvalue()
        {
            return newnode.data;
        }

        public void next()
        {
            newnode = newnode.next;
        }

        public bool isEnd()
        {
            return newnode == null;
        }

        //链表去重
        public LinkedList Simplify()
        {
            LinkedList simList = new LinkedList();
            this.gotoHead();
            while (!this.isEnd())
            {
                if (!simList.Exist(newnode.data))
                    simList.append(newnode.data);
                next();
            }
            return simList;
        }

        //检查信息是否已包含在链表中
        private bool Exist(Student newstudent)
        {
            gotoHead();
            while (!isEnd())
            {
                if (newstudent.no == newnode.data.no)
                    return true;
                next();
            }
            return false;
        }

        //删除包含指定学号的节点
        public bool delete(string no)
        {
            Node front = null;
            gotoHead();
            while (!isEnd())
            {
                if (newnode.data.no == no)
                {
                    if (newnode == head)
                    {
                        head = newnode.next;
                        return true;
                    }
                    front.next = newnode.next;
                    return true;
                }
                  
                front = newnode;
                newnode = newnode.next;
            }
            return false;
        }

        //在链表头插入新节点
        public void insertInFront(Student a)
        {
            Node newNode = new Node(a);
            if (isEmpty())
            {
                head = newNode;
                tail = newNode;
            }

            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        //链表逆序输出
        public LinkedList reverse()
        {
            LinkedList ReverseList = new LinkedList();
            this.gotoHead();
            while (!this.isEnd())
            {
                ReverseList.insertInFront(newnode.data);
                next();

            }
            return ReverseList;
        }

        //拆分链表
        public LinkedList[] division()
        {
            LinkedList even = new LinkedList();
            LinkedList odd = new LinkedList();
            gotoHead();
            while(!isEnd())
            {
                if (double.Parse(newnode.data.no) % 2 == 0)
                    odd.append(newnode.data);
                else
                    even.append(newnode.data);
                next();
            }   
            LinkedList[] divList={even , odd};
            return divList;
        }

        //查找最高分
        public Node search()
        {
            Node max=this.head;
            gotoHead();
            while (!isEnd())
            {
                if (newnode.data.total > max.data.total)
                    max = newnode;
                newnode = newnode.next;
            }
            return max;
        }

    }
}
