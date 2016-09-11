using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Dijcstra
{
    class Dijcstra
    {



        public static Node generate()
        {

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.AddNode(n2, 20);
            n1.AddNode(n3, 30);
            n1.AddNode(n4, 40);
            n1.AddNode(n5, 50);

            n3.AddNode(n5, 10);


            return n1;
        }

        public static void DoMagic()
        {
            Node n1 = generate();
            print(n1);
        }


        public static void print(Node node)
        {
            List<Node> list = new List<Node>();
            list.Add(node);
            while (list.Count > 0)
            {
                Node n = list[0];
                Console.WriteLine("points {0}", n.Data);
                list.RemoveAt(0);
                for(int i = 0; i < n.List.Count; i++)
                {
                    list.Add(n.List[i].Node);
                }
            }
        }

        public static void ResolveSimple(Node start, Node end)
        {
            

        }


    }
}
