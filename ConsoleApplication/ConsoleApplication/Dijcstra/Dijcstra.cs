﻿using System;
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

            n5.AddNode(n1, 25);
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
                    var child = current.List[i].Node;
                    Console.WriteLine($"    {child.Data}");
                    
                    
                    //list.Insert(0, child);
                    list.Add(child);
                }
                Console.WriteLine();
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
