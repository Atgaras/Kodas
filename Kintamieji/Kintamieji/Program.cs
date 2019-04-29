using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kintamieji
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmasSk;
            int antrasSk;
            Console.WriteLine("Pirmas skaicius");
            pirmasSk = Int32.Parse(Console.ReadLine());
            //parse ir convert konvertuoja "ReadLine" i skaiciu
            Console.WriteLine("Antras skaicius");
            antrasSk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma: {0}",pirmasSk + antrasSk);
            Console.ReadLine();
            
        }
    }
}
