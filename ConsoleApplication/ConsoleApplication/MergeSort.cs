using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class MergeSort
    {

        private int[] _ar;

        public static void ShowMagic()
        {
            //var ar = Qsort.GetArray(8);
            int nn = 58;
            var ar = GetArray(nn);
            Console.WriteLine(nn);
            int[] newAr = (int[])ar.Clone();


            MergeSort mg = new MergeSort(ar);


            mg.Sort();
 

            Array.Sort(newAr);

            Console.WriteLine(mg);
            Console.WriteLine("====================");
            Console.WriteLine(mg.Test(newAr));

            // var ttt = newAr.ToList();
            //  ttt.Sort();
            // Console.WriteLine(q.Test(ttt.ToArray()));
            // Console.WriteLine(q);
        }
        public MergeSort(int[] ar)
        {
            _ar = ar;
        }

        public void Sort ()
        {
            _ar = Sort(0, _ar.Length - 1, _ar); 
        }
        public int[] Sort(int start, int last, int[] ar)
        {
            if (start == last)
            {
                int[] arr1 = new int[1];
                arr1[0] = ar[start];
                return arr1;
            }
            int mid = (last-start)/2 +start;
            int[] a = Sort(start, mid, ar);
            int[] b = Sort(mid+1, last, ar);

            return MSort(a, b);
        }

        public int[] MSort(int [] a, int []b)
        {
            int[] ret = new int[a.Length + b.Length];
            int aIndex = 0;
            int bIndex = 0;

            for (int i = 0; i < a.Length + b.Length ; i++)
            {

                if (aIndex == a.Length)
                {
                    ret[i] = b[bIndex++];
                    continue;
                }

                if (bIndex == b.Length)
                {
                    ret[i] = a[aIndex++];
                    continue;
                }


                if (a[aIndex] < b[bIndex])
                {
                    ret[i] = a[aIndex];
                    aIndex++;
                }
                else 
                {
                    ret[i] = b[bIndex];
                    bIndex++;
                }

            }

            return ret;

        }


        public bool Test(int[] ar)
        {
            if (_ar.Length != ar.Length)
            {
                return false;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (_ar[i] != ar[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] GetArray(int n)
        {
            Random rnd = new Random();
            int[] ret = new int[n];
            for (int i = 0; i < n; i++)
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
