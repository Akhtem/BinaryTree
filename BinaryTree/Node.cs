using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        private T data;
        private Node<T> leftNeighbor=null;
        private Node<T> rightNeighbor = null;

        public Node() { }
        public Node(T data) : this(data, null,null) { }
        public Node(T data, Node<T> left,Node<T>right)
        {
            this.data = data;
            this.LeftNeighbor = left;
            this.RightNeighbor = right;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }


        public Node<T> LeftNeighbor
        {
            get
            {
                return leftNeighbor;
            }
            set
            {
                leftNeighbor = value;
            }
        }
        public Node<T> RightNeighbor
        {
            get
            {
                return rightNeighbor;
            }
            set
            {
                rightNeighbor = value;
            }
        }
    }

    
}

