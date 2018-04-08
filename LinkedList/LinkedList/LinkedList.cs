using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
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
        private void gotoHead() //将current指向链表head
        {
            current = head;
        }
        private void next() //将current指向current.next
        {
            current = current.next;
        }
        private bool isEnd() //判断current是否已经越过链表tail
        {
            return current == null;
        }
        public bool isEmpty() //检查链表是否为空  
        {
            return head == null;
        }
        private bool Exist(Student newStudent) //检查信息是否已包含在链表中
        {
            gotoHead();
            while (!isEnd())
            {
                if (newStudent.no == current.data.no)
                    return true;
                next();
            }
            return false;
        }
        public Student getvalue() //返回current.data
        {
            return current.data;
        }
        public void append(Student newStudent) //在链表最后追加新节点
        {
            Node newNode = new Node(newStudent);
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
        public void insertInFront(Student newStudent) //在链表头插入新节点
        {
            Node newNode = new Node(newStudent);
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
        public Node searchMaxTotal() //查找包含最高分Node
        {
            Node max = head;
            gotoHead();
            while (!isEnd())
            {
                if (current.data.total > max.data.total)
                    max = current;
                current = current.next;
            }
            return max;
        }
        public bool delete(string no) //删除包含指定学号的节点
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
                current = current.next;
            }
            return false;
        }
        public LinkedList Simplify() //链表去重
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
        public LinkedList reverse() //链表逆序后以新链表返回
        {
            LinkedList ReverseList = new LinkedList();
            gotoHead();
            while (!isEnd())
            {
                ReverseList.insertInFront(current.data);
                next();
            }
            return ReverseList;
        }
        public LinkedList[] division() //将链表按奇偶学号拆分后返回链表数组
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
    }
}
