using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmH
{
    class Program
    {
        static void Main(string[] args)
        {
            double atstumas;
            double laikas;
            
            Console.WriteLine("Įveskite atstumą metrais: ");
            atstumas = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Įveskite laiką sekundėmis: ");
            laikas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Greitis yra: {0}", atstumas/laikas*1000/3600);
            Console.ReadLine();
        }
    }
}
