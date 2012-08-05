using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public bool marked;
        public string name;
        public int d;
        public String parent;
        public List<Edge> adjEdges;

        public Node(String name)
        {
            this.marked = false;
            this.name = name;
        }

        public Node(String name, List<Edge> adjEdges)
        {
            this.name = name;
            this.adjEdges = adjEdges;
        }

        public List<Node> getAdjNodes()
	    {
            List<Node> nodes = new List<Node>();
            foreach (Edge edge in getAdjEdges())
                nodes.Add(edge.v);
            
            return nodes;
	    }

        public List<Edge> getAdjEdges()
        {
            List<Edge> edges = new List<Edge>();
            foreach(Edge edge in adjEdges)
                if (edge.u == this && edge.v != this)
                    edges.Add(edge);
            return edges;
        
        }
    }
}
