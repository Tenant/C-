using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTest2
{
    public class ArrayList
    {
        private Student[] data;
        private int volume;
        private int length;

        public ArrayList(int n)//构造函数，不能定义返回值类型
        {
            length = 0;
            data = new Student[n];
            volume = n;
        }

        public void Clear()//清空顺序表内容
        {
            data = new Student[volume];
            length = 0;
        }

        public bool append(Student newStudent)//向顺序表末尾追加新元素
        {
            if (length < volume)
            {
                data[length++] = newStudent;
                return true;
            }
            return false;
        }

        public void sort()//将无序顺序表升序排列
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (data[i].num.CompareTo(data[j].num) > 0)
                    {
                        Student temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }

        public Student getMax()//返回data最大值
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
        public bool delete(string num)//删除具有指定ID的data
        {
            int position = checkExist(getValue(num));
            if (position == -1) 
                return false;
            else
            {
                for (int j = position; j < length - 1; j++)
                    data[j] = data[j + 1];
                length--;
                return true;
            }
        }

        public int getLength()//返回顺序表长度
        {
            return length;
        }

        public Student getValue(int i)//返回顺序表指定index的数据
        {
            return data[i];
        }

        public Student getValue(string num)//返回顺序表指定ID的数据
        {
            for (int i = 0; i < length; i++)
            {
                if (data[i].num.CompareTo(num) == 0)
                    return getValue(i);
            }
            return null;
        }

        public int checkExist(Student st)//判断指定数据是否已经存在于顺序表中
        {
            for(int i=0;i<length;i++)
            {
                if(data[i].num.CompareTo(st.num)==0)
                    return i;
            }
            return -1;
        }
        
    }

}
