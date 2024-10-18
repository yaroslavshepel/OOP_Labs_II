using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4
{
    public class BinaryTreeEnumerator<T> : IEnumerator<T> where T : class
    {
        private readonly Stack<TreeNode<T>> _stack = new Stack<TreeNode<T>>();
        private TreeNode<T> _current;

        public BinaryTreeEnumerator(TreeNode<T> root)
        {
            if (root != null)
            {
                _stack.Push(root);
            }
        }

        public T Current => _current?.Value;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }

            _current = _stack.Pop();

            if (_current.Right != null)
            {
                _stack.Push(_current.Right);
            }

            if (_current.Left != null)
            {
                _stack.Push(_current.Left);
            }

            return true;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
            // No resources to dispose
        }
    }
}