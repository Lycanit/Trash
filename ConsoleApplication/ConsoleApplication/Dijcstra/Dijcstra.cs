using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Dijcstra
{
    class Dijcstra
    {

        private static int _shift = 2;

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

            n3.AddNode(n4, 25);
            n3.AddNode(n5, 15);

            n5.AddNode(n4, 25);
           

            return n1;
        }

        public static void DoMagic()
        {
            Node n1 = generate();
            print(n1);
        }


        public static void print(Node node)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            List<PrintNode> list = new List<PrintNode>();
            PrintNode _pn = new PrintNode()
            {
                Shift = 0,
                FromNode = 0,
                Node = node,
            };
            list.Add(_pn);
            while (list.Count > 0)
            {
                PrintNode pn = list[0];
                var shiftStr = GetShift(pn.Shift);
                Console.WriteLine($"{shiftStr}{pn.FromNode} -> {pn.Node.Data}");

                list.RemoveAt(0);
                for(int i = 0; i < pn.Node.List.Count; i++)
                {
                    if (dic.ContainsKey(pn.Node.Data))
                    {
                        if (dic[pn.Node.Data].Contains(pn.Node.List[i].Node.Data))
                        {
                            continue;
                        }
                        else
                        {
                            dic[pn.Node.Data].Add(pn.Node.List[i].Node.Data);
                        }
                    }
                    else
                    {
                        dic[pn.Node.Data] = new List<int>() { pn.Node.List[i].Node.Data };
                    }
                    PrintNode childPN = new PrintNode()
                    {
                        FromNode = pn.Node.Data,
                        Shift = pn.Shift + 1,
                        Node = pn.Node.List[i].Node,
                    };
                    list.Insert(0, childPN);
                }
            }
        }

        public static string GetShift(int shift)
        {
            string ret = "";
            for(int i = 0; i < shift * _shift; i++)
            {
                ret += " ";
            }
            return ret;
        }

        public static void ResolveSimple(Node start, Node end)
        {
            

        }


    }
}
