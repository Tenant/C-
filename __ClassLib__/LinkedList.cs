using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{

    public class LinkedList
    {
        public Node head ;
        public Node tail ;
        public Node current;
        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void gotoHead()
        {
            current = head;
        }

        public Student getvalue(Node newNode)
        {
            return newNode.data;
        }

        public void next()
        {
            current = current.next;
        }

        public bool isEnd()
        {
            return newnode == null;
        }
		
		public bool isEmpty()
		//检查链表是否为空
        {
            return head == null;
        }
		
		private bool Exist(Student newstudent)
		//检查信息是否已包含在链表中
        {
            gotoHead();
            while (!isEnd())
            {
                if (newstudent.no == current.data.no)
                    return true;
                next();
            }
            return false;
        }
		
		public void append(Student s)
		//在链表最后追加新节点
        {
            Node newNode = new Node(s);
            if (isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public LinkedList Simplify()
		//链表去重
        {
            LinkedList simList = new LinkedList();
            this.gotoHead();
            while (!this.isEnd())
            {
                if (!simList.Exist(current.data))
                    simList.append(current.data);
                next();
            }
            return simList;
        }

        public bool delete(string no)
		//删除包含指定学号的节点
        {
            Node front = null;
            gotoHead();
            while (!isEnd())
            {
                if (current.data.no == no)
                {
                    if (current == head)
                    {
                        head = current.next;
                        return true;
                    }
                    front.next = current.next;
                    return true;
                }
                  
                front = current;
                next();
            }
            return false;
        }

        public void insertInFront(Student newstudent)
		//在链表头插入新节点
        {
            Node newNode = new Node(newstudent);
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

        public LinkedList reverse()
		//链表逆序输出
        {
            LinkedList RevList = new LinkedList();
            gotoHead();
            while (!isEnd())
            {
                RevList.insertInFront(current.data);
                next();
            }
            return ReverseList;
        }

        
        public LinkedList[] division()
		//根据学号奇偶性拆分链表
        {
            LinkedList even = new LinkedList();
            LinkedList odd = new LinkedList();
            gotoHead();
            while(!isEnd())
            {
                if (double.Parse(current.data.no) % 2 == 0)
                    odd.append(current.data);
                else
                    even.append(current.data);
                next();
            }   
            LinkedList[] divList={even , odd};
            return divList;
        }

        //查找最高分
        public Node search()
        {
            gotoHead();
			Node max=current;
            while (!isEnd())
            {
                if (newnode.data.total > max.data.total)
                    max = current;
                next();
            }
            return max;
        }

    }
}
