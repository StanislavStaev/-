using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("vuvedi x: ");
            var x = double.Parse(Console.ReadLine());
            double sum = 1; 
            for (int i = 1; i <= n; i++)
            {
                //Много мислих натази задача и си помогнах с чат гпт
                sum += (i) / Math.Pow(x, i); //то направи само това вичко друго е мое
                //sum += (i);
                //sum += (i) / Math.Round(x, i);
            }
            Console.WriteLine("rezultata e " + sum);
        }
    }
}
