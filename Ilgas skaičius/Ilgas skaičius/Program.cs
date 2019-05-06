using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilgas_skaičius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parašykite ilgą skaičių:");
            double num = double.Parse(Console.ReadLine());
            int i = (int)num;
            short s = (short)i;
            byte b = (byte)s;
            Console.WriteLine("Skičus: {0}", num);
            Console.WriteLine("Int: {0}", i);
            Console.WriteLine("Short: {0}", s);
            Console.WriteLine("Byte: {0}", b);
            Console.ReadLine();
        }
    }
}
