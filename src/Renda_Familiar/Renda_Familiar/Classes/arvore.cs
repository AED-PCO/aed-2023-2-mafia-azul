using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Renda_Familiar.Classes
{
    class TreeNode
    {
        public Decimal Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(Decimal value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    class BinaryTree
    {
        public TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(Decimal value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode root, Decimal value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }

            if (value < root.Value)
            {
                root.Left = InsertRecursive(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRecursive(root.Right, value);
            }

            return root;
        }

        public Decimal achaMenor()
        {
            return achaMenorFuncao(root);
        }

        public Decimal achaMenorFuncao(TreeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node.Value;
        }

        public Decimal achaMaior()
        {
            return achaMaiorFuncao(root);
        }

        public Decimal achaMaiorFuncao(TreeNode node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node.Value;
        }
    }
}
