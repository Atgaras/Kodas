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
            double pi = 3.14; 

            Console.WriteLine("Įveskite rutulio diametrą:");
            diametras = double.Parse(Console.ReadLine());
            double spindulys = diametras / 2;

            Console.WriteLine("Rutulio paviršiaus plotas = {0}", 4*pi*spindulys*spindulys);
            Console.WriteLine("Rutulio tūris = {0}",(4.0/3)*pi*spindulys*spindulys*spindulys);
            Console.ReadLine();
        }
    }
}
