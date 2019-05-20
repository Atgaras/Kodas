using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTD_eil_ilgis
{
    class Program
    {
        static void Line(string eilute)
        {
            for (int i = 0; i < eilute.Length; i++)
            {
                Console.WriteLine("Raidžių skaičius: {0}", i +1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite žodį:");
            Line(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
