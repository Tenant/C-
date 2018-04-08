using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiTreeTest
{
    public class TreeNode
    {
        public double data;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode(double newdata)
        {
            data = newdata;
            leftChild = null;
            rightChild = null;
        }
    }
}
