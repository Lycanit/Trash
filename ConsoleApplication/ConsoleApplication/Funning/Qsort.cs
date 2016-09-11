using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Funning
{
    class Qsort
    {
        private int[] _ar;

        public static void ShowMagic()
        {
            //var ar = Qsort.GetArray(8);
            var ar = new int[] { 4, 1, 6, 7, 4, 3, 7, 4 };
            var q = new Qsort(ar);
            Console.WriteLine(q);
            Console.WriteLine("====================");
           // q.Sort();
            int[] newAr = (int[])ar.Clone();
            var ttt = newAr.ToList();
            ttt.Sort();
            Console.WriteLine(q.Test(ttt.ToArray()));
            Console.WriteLine(q);
        }

        public Qsort(int[] ar)
        {
            _ar = ar;
        }

        public bool Test(int[] ar)
        {
            if (_ar.Length != ar.Length)
            {
                return false;
            }
            for(int i = 0; i < ar.Length; i++)
            {
                if (_ar[i] != ar[i])
                {
                    return false;
                }
            }
            return true;
        }

        //public void Sort()
        //{
        //    Sort(0, _ar.Length - 1);
        //}

        //private void Sort(int first, int last)
        //{
            
        //    Array.Sort ()
        //    int tempFirst = first;
        //    int tempLast = last;
        //    int pivot = _ar[first];
            
        //    Console.WriteLine("{0} : {1} : {2} : {3}", first, last, pivot, mid);
        //    while (first <= last)
        //    {
        //        //if (_ar[first] > _ar[last])
        //        //{
        //        //    var temp1 = _ar[first];
        //        //    _ar[first] = _ar[last];
        //        //    _ar[last] = temp1;
        //        //    first++;
        //        //    last--;
        //        //    continue;
        //        //}

        //        if (_ar[first] <= mid)
        //        {
        //            first++;
        //            continue;
        //        }
        //        if (_ar[last] >= mid)
        //        {
        //            last--;
        //            continue;
        //        }

        //        var temp = _ar[first];
        //        _ar[first] = _ar[last];
        //        _ar[last] = temp;
        //        //first++;
        //        //last--;
        //    }
        //    Console.WriteLine(this);
        //    Console.WriteLine("");
        //    if (tempFirst + 1 >= tempLast)
        //    {
        //        return;
        //    }

        //    Sort(tempFirst, pivot);
        //    Sort(pivot + 1, tempLast);

        //    //if (tempFirst < tempMid)
        //    //{
                
        //    //}

        //    //if (tempLast > tempMid)
        //    //{
                
        //    //}

        //}

        public static int[] GetArray(int n)
        {
            Random rnd = new Random();
            int[] ret = new int[n];
            for(int i = 0; i < n; i++)
            {
                ret[i] = rnd.Next(n);
            }
            return ret;
        }

        public override string ToString()
        {
            var str = string.Join(", ", _ar);
            return str;
        }


    }
}
