using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsijus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite temperatūrą laipsniais Celsijaus: ");
            double cels = double.Parse(Console.ReadLine());
            double farenheitai = (cels * 9) / 5 + 32;
            double kelvin = cels + 273;
            Console.WriteLine("Temperatūra Farenheitais yra {0}", farenheitai);
            Console.WriteLine("Temperatūra Kelvinais yra {0}", kelvin);

            Console.ReadLine();

        }
    }
}
