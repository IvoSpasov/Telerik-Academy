namespace _01.TreeTraversal
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var nodes = ReadTreeFromConsole();

            // a)
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree has value: " + root.Value);

            // b)
            var leafs = FindLeafs(nodes);
            Console.Write("All leafs values are: ");
            foreach (var leaf in leafs)
            {
                Console.Write(leaf.Value + ", ");
            }
            Console.WriteLine();

            // c)
            var middleNodes = FindMiddleNodes(nodes);
            Console.Write("All middle nodes are: ");
            foreach (var node in middleNodes)
            {
                Console.Write(node.Value + ", ");
            }
            Console.WriteLine();

            // d)
            int maxPath = FindLongestPath(root);
            Console.WriteLine("The longest path ftom the root is: " + maxPath);
        }

        private static Dictionary<int, Node> ReadTreeFromConsole()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < n - 1; i++)
            {
                string row = Console.ReadLine();
                string[] splittedRow = row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int parentValue = int.Parse(splittedRow[0]);
                int childValue = int.Parse(splittedRow[1]);

                Node parentNode;
                Node childNode;

                if (!nodes.ContainsKey(parentValue))
                {
                    parentNode = new Node(parentValue);
                    nodes.Add(parentValue, parentNode);
                }
                else
                {
                    parentNode = nodes[parentValue];
                }

                if (!nodes.ContainsKey(childValue))
                {
                    childNode = new Node(childValue);
                    nodes.Add(childValue, childNode);
                }
                else
                {
                    childNode = nodes[childValue];
                }

                parentNode.AddChild(childNode);
            }

            return nodes;
        }

        private static Node FindRoot(Dictionary<int, Node> allNodes)
        {
            foreach (var item in allNodes)
            {
                if (!item.Value.HasParent)
                {
                    return item.Value;
                }
            }

            return new Node(-1);
        }

        private static List<Node> FindLeafs(Dictionary<int, Node> allNodes)
        {
            List<Node> leafs = new List<Node>();

            foreach (var item in allNodes)
            {
                if (item.Value.ChildrenCount == 0)
                {
                    leafs.Add(item.Value);
                }
            }

            return leafs;
        }

        private static List<Node> FindMiddleNodes(Dictionary<int, Node> allNodes)
        {
            var middleNodes = new List<Node>();

            foreach (var item in allNodes)
            {
                if (item.Value.HasParent && item.Value.ChildrenCount > 0)
                {
                    middleNodes.Add(item.Value);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(Node root)
        {
            if (root.ChildrenCount == 0)
            {
                return 0;
            }

            int maxPath = 0;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(root.GetChild(i)));
            }

            return maxPath + 1;
        }
    }
}