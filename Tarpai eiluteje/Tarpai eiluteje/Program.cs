using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpai_eiluteje
{
    class Program
    {
        private static void zenkluSkaicius(string zodis)
        {
            int skaicius = 0;
            for (int i = 0; i < zodis.Length; i++)
            {
                skaicius = skaicius + i;
                Console.WriteLine("{0}", skaicius);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine ("{0}", int.Parse(zenkluSkaicius);
            Console.ReadLine();

        }
    }
}
