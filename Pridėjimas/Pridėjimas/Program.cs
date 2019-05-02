using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pridėjimas
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 0;

            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a = 254;
            a++;
            Console.WriteLine(a);
            a = (byte)(a+(byte)10);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
