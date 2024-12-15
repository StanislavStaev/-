using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class zad4
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi broi 4isla");
            int n= int .Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min) min = a;
                if (a > max) max = a;
            }
            Console.Write("naj golqmoto e "+ max);
            Console.Write("naj malkot e " + min);
        }
    }
}
