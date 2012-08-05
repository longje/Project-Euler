using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphs;

namespace ProjectEuler
{
    class Problem79: Solution
    {
        string[] numbers = new string[] { "319", "680", "180", "690", "129", "620", "762", "689", "762", "318", "368", "710", "720", "710", "629", "168", "160", "689", "716", "731", "736", "729", "316", "729", "729", "710", "769", "290", "719", "680", "318", "389", "162", "289", "162", "718", "729", "319", "790", "680", "890", "362", "319", "760", "316", "729", "380", "319", "728", "716" };
        List<Edge> edges = new List<Edge>();
        Node[] nodes; 
        Stack<Node> reversePost = new Stack<Node>();

        private Node getNode(char a)
        {
            foreach (var item in nodes)
            {
                item.adjEdges = edges;
                if (item.name.Equals(a.ToString()))
                    return item;
            }
            return null;
        }

        public void GraphSolution()
        {
            nodes = new Node[]
                {
                    new Node("0"),
                    new Node("1"),
                    new Node("2"),
                    new Node("3"),
                    new Node("6"),
                    new Node("7"),
                    new Node("8"),
                    new Node("9"),
                };
            foreach (string x in numbers)
            {
                edges.Add(new Edge(0, getNode(x[0]), getNode(x[1])));
                edges.Add(new Edge(0, getNode(x[1]), getNode(x[2])));
            }

            foreach (var n in nodes)
            {
                Console.WriteLine("DFS Order: {0}", DFS(n, string.Empty));
                foreach (var x in nodes)
                    x.marked = false;

                Console.Write("Reverse Post Order (Topological Sorted): ");
                foreach (Node x in reversePost)
                    Console.Write(x.name);
                Console.WriteLine();
                reversePost = new Stack<Node>();
            }
        }

        public string DFS(Node node, string res)
        {
            node.marked = true;
            string temp = string.Empty;
            foreach (Node n in node.getAdjNodes())
                if (!n.marked)
                    temp += DFS(n, res);
            reversePost.Push(node);
            return node.name + temp;
        }

        public void Solve()
        {
            GraphSolution();
            //var numbers = new string[] { "319", "680", "180", "690", "129", "620", "762", "689", "762", "318", "368", "710", "720", "710", "629", "168", "160", "689", "716", "731", "736", "729", "316", "729", "729", "710", "769", "290", "719", "680", "318", "389", "162", "289", "162", "718", "729", "319", "790", "680", "890", "362", "319", "760", "316", "729", "380", "319", "728", "716" };
            /*
            for (int i = 10000000; ; i++)
            {
                int count = 0;
                foreach (var x in numbers)
                    if (!isNumberFit(x, i.ToString()))
                        break;
                    else
                        count++;

                if (count == numbers.Length)
                {
                    Console.WriteLine("The expected code is: {0} with a count of {1}", i, count);
                    break;
                }
            }
             * */
        }

        private bool isNumberFit (string test, string code)
        {
            int limit = 0;
            for (int i = 0; i < test.Length; i++)
            {
                bool found = false;
                for (int j = limit; j < code.Length; j++)
                {
                    if (test[i] == code[j])
                    {
                        limit = j;
                        found = true;
                    }
                }

                if (!found)
                    return false;
            }
            return true;
        }
    }
}
