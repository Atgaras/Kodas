using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kokį veiksmą norite atlikti?");
            Console.WriteLine("[1] - ištrinti vartotoją, [2} - sukurti vartotoją, [3] - redaguoti esamą");

            int veiksmas = int.Parse(Console.ReadLine());

            switch (veiksmas)
            {
            case 1:
                Console.WriteLine("Vartotojas sėkmingai išrtintas");
                break;
            case 2:
                Console.WriteLine("Vartotojas sėkmingai sukurtas");
                break;
            case 3:
                Console.WriteLine("Vartotojo redagavimo rėžimas");
                    break;
            default:
                    Console.WriteLine("Nežinomas veiksmas: Paspauskite [ENTER], kad uždarytumėt langą.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Paspauskite [ENTER], kad uždarytumėt langą");
            Console.ReadLine();            
        }
    }
}
