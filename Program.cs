using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void F1(int[] a,int index)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 1)
                    index = a[i];
            }
        }
        static void F2(int[] a,out int index)
        {
            index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 1)
                    index = a[i];
            }
        }
        static void Main(string[] args)
        {
            int index = 0;
            int[] a = new int[3];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
            F1(a,index);
            Console.WriteLine(index);
            F2(a,out index);
            Console.WriteLine(index);
        }
    }
}
