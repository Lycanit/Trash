using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class PipiskoMerstvo 
    {

        private static TrueRandom _tr;
        private static int _tries;

        public static void Run(int trueSeed, int elements, int max, int tries)
        {
            _tr = new TrueRandom(trueSeed, elements, max);
            _tries = tries;
            Thread tr1 = new Thread(x => Runner2());
            Thread tr2 = new Thread(x => Runner2());
            tr1.Start();
            tr2.Start();
        }

        private static void Runner1()
        {
            Console.WriteLine("MergeSort started");
            var sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < _tries; i++)
            {
                var ms = new MergeSort(_tr.Random1());
                ms.Sort();
            }
            Console.WriteLine("MergeSort finished time = " + sw.ElapsedMilliseconds);
        }

        private static void Runner2()
        {
            Console.WriteLine("Microsoft started");
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < _tries; i++)
            {
                var ar = _tr.Random2();
                Array.Sort(ar);
            }
            Console.WriteLine("Microsoft finished time = " + sw.ElapsedMilliseconds);
        }

    }
}
