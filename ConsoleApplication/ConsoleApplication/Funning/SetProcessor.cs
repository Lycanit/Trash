using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Funning
{
    class SetProcessor
    {
        public static void Demostrate()
        {
            var s = new SetProcessor();
            HashSet<int> b = s.IsHasUnion(true, new HashSet<int> { 3, 4, 5, 8 }, new HashSet<int> { 6, 7, 8, 7, 10 }, new HashSet<int> { 9, 10, 7, 11, 13 }, new HashSet<int> { 11, 12, 13 });
            print(b);
        }

        public static void print(HashSet<int> h)
        {
            foreach (int i in h)
            {
                Console.WriteLine(i);
            }

        }

        public HashSet<int> IsHasUnion(bool isAll, params HashSet<int>[] sets)
        {
            List<HashSet<int>> list = new List<HashSet<int>>();
            HashSet<int> count = new HashSet<int>();
            for (int i = 0; i < sets.Count(); i++)
            {
                list.Add(sets[i]);
            }

            if (isAll != true)
            {
                return count;
            }

            for (int a = 0; a < list.Count; a++)
            {
                foreach (var i in list[a])
                {
                    foreach (var j in list)
                    {
                        if (j != list[a])
                        {
                            foreach (int d in j)
                            {
                                if (i == d)
                                {
                                    count.Add(i);

                                }
                            }
                        }
                    }
                }
            }


            return count;
        }
    }

}
