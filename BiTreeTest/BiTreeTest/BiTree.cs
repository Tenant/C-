using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiTreeTest 
{
     public class BiTree //创建有序二叉树并通过两种遍历方式实现正序和逆序输出
    {
        private TreeNode root;
        private List<double> allData=new List<double>(); //class内部是可以定义这个class本身或其他已有class的对象的
        private List<double> result=new List<double>(); //这种class的定义用的是C#自带的实用类，书上找目录，重点我划了

        public BiTree() //构造函数， 对象类数据初始化为null
        {
            root = null;
        }

        public void growBiTree(double newdata) //向有序二叉树内追加新元素
        {
            TreeNode p, q;
                q = new TreeNode(newdata);
                if (root == null)
                {
                    root = q;
                    return;
                }
                p = root;
                while ((p.leftChild != q) && (p.rightChild != q))
                {
                    if (newdata < p.data)
                    {
                        if (p.leftChild != null)
                            p = p.leftChild;
                        else
                            p.leftChild = q;
                    }
                    else
                    {
                        if (p.rightChild != null)
                            p = p.rightChild;
                        else
                            p.rightChild = q;
                    }
                
            }
        }

        private void midOrder(TreeNode t)
        {       
            if (t != null)
            {
                midOrder(t.leftChild);
                result.Add(t.data);
                midOrder(t.rightChild); //递归算法，慢慢理解，不难的
            }
        }

        public List<double> midOrder()  //中序遍历        
        {
            this.result.Clear();
            midOrder(this.root);  
            return this.result;        
        }
        private void revOrder(TreeNode t)
        {       
            if (t != null)
            {
                revOrder(t.rightChild);
                result.Add(t.data);
                revOrder(t.leftChild);
            }
        }

         public List<double> revOrder()  //后序遍历        
         {
             this.result.Clear();
             revOrder(this.root);
             return this.result;
         }

    }
}
