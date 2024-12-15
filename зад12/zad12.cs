using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад12
{
    internal class zad12
    {
        static void Main(string[] args)
        {
          int sum = 0;
          int n = 3;
          Console.WriteLine("vuvedete 3 4isla");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("4islo ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 100)
                {
                    sum += num;
                }
            }
          Console.WriteLine("sumata e "+sum);
        }
    }
}
