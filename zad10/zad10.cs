using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    internal class zad10
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int b = 0;
            do
            {
                int c= n% 10;
                b = b*10+c;
                n /=10;
            }
            while (n > 0) ;
            Console.WriteLine("ogledalno    "+b);
        }
    }
}
