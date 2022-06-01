using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibary_Binary_Search_Tree
{
    public class TreeNode
    {
        public int data;
        public TreeNode left, right, parent;
        private int _size;
        public int Size { get => _size; set { _size = value; } } //Get Set

        public TreeNode(int d)
        {
            this.data = d;
            this._size = 1;
        }

        public void InsertInOrder(int d)
        {
            if (d <= data)
            {
                if (left == null)
                {
                    SetLeftChild(new TreeNode(d));
                }
                else
                {
                    left.InsertInOrder(d);
                }
            }
            else
            {
                if (right == null)
                {
                    SetRightChild(new TreeNode(d));
                }
                else
                {
                    right.InsertInOrder(d);
                }
                
            }
            _size++;
        }

        public TreeNode Find(int d)
        {
            if (d == data)
            {
                return this;
            }
            else if (d <= data)
            {
                return left?.Find(d);
            }
            else if (d > data)
            {
                return right?.Find(d);
            }
            return null;

        }

        public void SetLeftChild(TreeNode left)
        {
            this.left = left;
            if (left != null)
            {
                left.parent = this;
            }
        }

        public void SetRightChild(TreeNode right)
        {
            this.right = right;
            if (right != null)
            {
                right.parent = this;
            }
        }
    }
}
