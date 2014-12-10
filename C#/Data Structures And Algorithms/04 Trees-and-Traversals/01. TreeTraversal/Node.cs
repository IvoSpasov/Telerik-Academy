namespace _01.TreeTraversal
{
    using System;
    using System.Collections.Generic;

    public class Node
    {
        private int value;
        private bool hasParent;
        private List<Node> children;

        public Node(int value)
        {
            this.Value = value;
            this.children = new List<Node>();
        }

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null");
                }

                this.value = value;
            }
        }

        public bool HasParent
        {
            get 
            {
                return this.hasParent;            
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(Node child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Value cannot be null");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public Node GetChild(int index)
        {
            return this.children[index];
        }
    }
}
