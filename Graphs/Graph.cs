﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    class Graph
    {
        public int numberOfNodes;
        public int numberOfEdges;
        public Edge[] edges;
        public Node[] nodes;

        public Graph(Edge[] edges, Node[] nodes)
        {
            this.edges = edges;
            this.nodes = nodes;
        }
    }
}
