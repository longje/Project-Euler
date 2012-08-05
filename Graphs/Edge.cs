using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class Edge
    {
        public int weight;
        public Node u;
        public Node v;

        public Edge(int w, Node u, Node v)
        {
            this.weight = w;
            this.u = u;
            this.v = v;
        }
    }
}
