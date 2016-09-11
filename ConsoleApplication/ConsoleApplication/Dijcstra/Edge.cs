using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Dijcstra
{
    class Edge
    {
        public int Weight;
        public Node Node;

        public Edge ( Node node, int weight)
        {
            this.Weight = weight;
            Node = node;
        }
    }
}
