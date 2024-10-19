using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4
{
    public class BinaryTree<T> : IEnumerable<T> where T : class, IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(value);
            }
            else
            {
                InsertRec(Root, new TreeNode<T>(value));
            }
        }

        private void InsertRec(TreeNode<T> root, TreeNode<T> newNode)
        {
            if (newNode.Value.CompareTo(root.Value) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertRec(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertRec(root.Right, newNode);
                }
            }
        }

        public TreeNode<T> Find(T value)
        {
            return FindRec(Root, value);
        }

        private TreeNode<T> FindRec(TreeNode<T> root, T value)
        {
            if (root == null || root.Value.Equals(value))
            {
                return root;
            }

            if (value.CompareTo(root.Value) < 0)
            {
                return FindRec(root.Left, value);
            }
            else
            {
                return FindRec(root.Right, value);
            }
        }

        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversalRec(Root, action);
        }

        private void InOrderTraversalRec(TreeNode<T> root, Action<T> action)
        {
            if (root != null)
            {
                InOrderTraversalRec(root.Left, action);
                action(root.Value);
                InOrderTraversalRec(root.Right, action);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new BinaryTreeEnumerator<T>(Root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}