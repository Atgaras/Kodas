using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutulio_plotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double diametras;

            Console.WriteLine("Įveskite rutulio diametrą:");
            diametras = double.Parse(Console.ReadLine());

            Console.WriteLine("Rutulio paviršiaus plotas = {0}", 4*3.14*(diametras/2));
            Console.ReadLine();
        }
    }
}
