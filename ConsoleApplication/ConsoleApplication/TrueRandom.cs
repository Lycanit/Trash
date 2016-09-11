using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class TrueRandom
    {
        private readonly Random _rnd1;
        private readonly Random _rnd2;
        private readonly int _elements;
        private readonly int _max;

        public TrueRandom(int trueSeed, int elements, int max)
        {
            _rnd1 = new Random(trueSeed);
            _rnd2 = new Random(trueSeed);
            _elements = elements;
            _max = max;
        }

        public int[] Random1()
        {
            int[] ar = new int[_elements];
            for(int i = 0; i < _elements; i++)
            {
                ar[i] = _rnd1.Next(_max);
            }
            return ar;
        }

        public int[] Random2()
        {
            int[] ar = new int[_elements];
            for (int i = 0; i < _elements; i++)
            {
                ar[i] = _rnd2.Next(_max);
            }
            return ar;
        }



    }
}
