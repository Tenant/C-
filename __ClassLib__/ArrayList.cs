using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class ArrayList
    {
        Student[] data;//这里data盛放的数据是Student
        int volume;
        int length;
        public ArrayList(int n)
        {
            length = 0;
            data = new Student[n];
            volume = n;
        }
		public int getLength()
        {
            return length;
        }
        public Student getValue(int i)
        {
            return data[i];
        }
        public bool append(Student newdata)
		//在ArrayList最后追加新元素
        {
            if (length < volume)
            {
                data[length++] = newdata;
                return true;
            }
            return false;
        }
		
        public void sort()
		//将ArrayList元素从小到大排序
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (data[i].no.CompareTo(data[j].no) > 0)
                    {
                        Student temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
		
		public void revsort()
		//将ArrayList元素从大到小排序
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (data[i].no.CompareTo(data[j].no) > 0)
                    {
                        Student temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
		
        public Student getMax()
		//Student特有方法
        {
            double maxTotal = data[0].total;
            int bigIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (maxTotal < data[i].total)
                {
                    maxTotal = data[i].total;
                    bigIndex = i;
                }
            }
            return data[bigIndex];
        }
        public bool delete(string no)
        {
            int i = 0;
            while (i < length && data[i].no != no)
                i++;
            if (i < length)
            {
                for (int j = i; j < length - 1; j++)
                    data[j] = data[j + 1];
                length--;
                return true;
            }
            return false;
        }
        
    }

}
