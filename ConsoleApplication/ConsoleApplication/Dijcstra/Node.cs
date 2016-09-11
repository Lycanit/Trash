using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Dijcstra
{
    class Node

    {
        public int Data; 

        public List <Edge> List = new List<Edge>();

        public Node (int num)
        {
            Data = num;
        }

        public void  AddNode(Node node, int weight)
        {
            List.Add(new Edge (node, weight) );
        }

        public void DeleteNode(int i)
        {
            for (int t = 0; t < List.Count; t++)
            {
                if (List[t].Node.Data == i)
                    List.RemoveAt(t);
            }
        }
    }



}
