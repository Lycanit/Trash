using System;
using System.Collections.Generic;


namespace ConsoleApplication.Dijcstra
{
    class Dijcstra
    {

        public static Node Generate()
        {

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.AddNode(n2, 20);
            n1.AddNode(n3, 30);
            n1.AddNode(n4, 33);
            n1.AddNode(n5, 50);

            n2.AddNode(n3, 5);
            n2.AddNode(n4, 5);

            n3.AddNode(n4, 25);
            n3.AddNode(n5, 1);

            n4.AddNode(n3, 2);
            n5.AddNode(n1, 25);
            n5.AddNode(n4, 25);

           

            return n1;
        }

        public static void DoMagic()
        {
            Node n1 = Generate();
            print(n1);
            Console.WriteLine("============");
            int wtf = ResolveSimple(n1, 5);
            Console.WriteLine(wtf);
        }


        public static void print(Node node)
        {
            HashSet<int> hash = new HashSet<int>();
            List<Node> list = new List<Node>();
            list.Add(node);
            while (list.Count > 0)
            {
                Node current = list[0];
                list.RemoveAt(0);
                if (hash.Contains(current.Data))
                {
                    continue;
                }
                hash.Add(current.Data);

                Console.WriteLine($"{current.Data}:");
                for(int i = 0; i < current.List.Count; i++)
                {
                    var childEdge = current.List[i];
                    Console.WriteLine($"    {childEdge.Node.Data} : {childEdge.Weight}");
                    
                    
                    //list.Insert(0, child);
                    list.Add(childEdge.Node);
                }
                Console.WriteLine();
            }
        }

        public static int ResolveSimple(Node start, int end)
        {
            var ret = int.MaxValue;
            Dictionary<int, int> path = new Dictionary<int, int>();
            HashSet<int> hash = new HashSet<int>();
            List<Node> list = new List<Node>();
            list.Add(start);
            while (list.Count > 0)
            {
                Node current = list[0];
                list.RemoveAt(0);
                for (int i = 0; i < current.List.Count; i++)
                {
                    var childEdge = current.List[i];
                    if (!path.ContainsKey(childEdge.Node.Data))
                    {
                        int additional = 0;
                        if (path.ContainsKey(current.Data))
                        {
                            additional = path[current.Data];
                        }
                        path[childEdge.Node.Data] = childEdge.Weight + additional;
                        list.Add(childEdge.Node);
                        continue;
                    }
                    int outRange = childEdge.Weight;
                    int inRange = path[current.Data];
                    int wtf = path[childEdge.Node.Data];
                    if (wtf > inRange + outRange)
                    {
                        path[childEdge.Node.Data] = inRange + outRange;
                        list.Add(childEdge.Node);
                    }
                }
            }
            if (path.ContainsKey(end))
            {
                ret = path[end];
            }
            return ret;

        }


    }
}
