using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string veiksmas;
            double ats;

            Console.WriteLine("Įveskite skaičių:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite kokį veiksmą norite atlikti ( * , + , / , - ):");
            veiksmas = Console.ReadLine();
            Console.WriteLine("Įveskite antrą skaičių:");
            num2 = double.Parse(Console.ReadLine());

            if (veiksmas == "*")
            {
                ats = num1 * num2;
                Console.WriteLine(ats);
                Console.ReadLine();
            }
            else if (veiksmas == "/")
            {
                ats = num1 / num2;
                Console.WriteLine(ats);
                Console.ReadLine();
            }
            else if (veiksmas == "+")
            {
                ats = num1 + num2;
                Console.WriteLine(ats);
                Console.ReadLine();
            }
            else if (veiksmas == "-")
            {
                ats = num1 - num2;
                Console.WriteLine(ats);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Įvyko klaida. Spauskite [ENTER], kad uždaryti langą");
                Console.ReadLine();
            }
        }
    }
}
