using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад13
{
    internal class зад13
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int n = int.Parse(Console.ReadLine());
            if (n > 3 && n < 102)
            {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("sumate e " +sum);
            }
        }
    }
}
