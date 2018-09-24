using System;
using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;

namespace BinaryTree
{
 
    public class BinaryTree<T>:IEnumerable<T>
    {
        private IComparer<T> _comparer;
        public Node<T> root;
        public event EventHandler<T> Added;
        public BinaryTree()
        {
            root = null;
            if (typeof(IComparable<T>).IsAssignableFrom(typeof(T)))
            {
                _comparer = Comparer<T>.Default;
            }
            else throw new ArgumentException("Criterion unknown !");
        }

        public BinaryTree(Func<T,T,int>comparis)
        {
            root = null;
            _comparer = new OwnComparer<T>(comparis);
        }

        public BinaryTree(IComparer<T> comparer)
        {
            root = null;
            if (comparer != null)
            {
                _comparer = comparer;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public IComparer<T> CompareR
        {
            get { return _comparer; }
        }
        public virtual void Clear()
        {
            root = null;
        }


        public void Add(T data)
        {

            int result;
            if (Added != null)
            {
                Added(this,data);
            }
            if (root == null)
            {
                root = new Node<T>(data);
                return;
            }
            Node<T> current = root;
            Node<T> parent = null;
            while (current != null)
            {
                result = _comparer.Compare(current.Value,data);
                if (result >=0)
                {
                    parent = current;
                    current = current.LeftNeighbor;
                }
                else if (result == -1)
                {
                    parent = current;
                    current = current.RightNeighbor;
                }
            }

            result = _comparer.Compare(parent.Value, data);
            if (result >= 0)
            {
                Node<T> ob = new Node<T>(data);
                parent.LeftNeighbor = ob;
            }
            else
            {
                Node<T> ob = new Node<T>(data);
                parent.RightNeighbor=ob;
            }

        }


        public IEnumerable<T> BreadthTraversal()
        {
            if (root == null)
                yield break;

            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                yield return node.Value;

                if (node.LeftNeighbor != null)
                    queue.Enqueue(node.LeftNeighbor);
                if (node.RightNeighbor != null)
                    queue.Enqueue(node.RightNeighbor);
            }

        }


        public IEnumerable<T> PreOrderDeapthFirst()  
        {
            if (root == null) yield break;
            var list = new List<Node<T>>();
            list.Add(root);
            while (list.Count > 0)
            {
                var node = list[list.Count-1];
                yield return node.Value;
                if (node.RightNeighbor != null)
                {
                    list.Add(node.RightNeighbor);
                }
                if (node.LeftNeighbor != null)
                {
                    list.Add(node.LeftNeighbor);
                }
                list.Remove(node);
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            if (root == null) yield break;
            Stack<Node<T>> stack = new Stack<Node<T>>();
            Node<T> current = this.root;
            while (current != null)
            {
                while (current.LeftNeighbor != null)
                {
                    stack.Push(current);
                    current = current.LeftNeighbor;
                }
                yield return current.Value;
                while (current.RightNeighbor == null && stack.Count > 0)
                {
                    current = stack.Pop();
                    yield return current.Value;
                }
                current = current.RightNeighbor;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            
            return GetEnumerator();
        }
       
  
    }

    
}
