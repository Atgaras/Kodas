using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbo_laikas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite kiek valandų dirbta: ");
            int laikas = int.Parse(Console.ReadLine());

            if (laikas == 160)
            {
                Console.WriteLine("Išdirbtas pilnas etatas");
            }
            else if (laikas < 160)
            {
                int truksta = 160 - laikas;
                Console.WriteLine("Dar reikia išdirbti: {0} valandą(-ų)", truksta);
            }
            else if (laikas > 160)
            {
                int overtime = laikas - 160;
                Console.WriteLine("Dirbta {0} valandų viršvalandžių", overtime);
            }
            else
            {
                Console.WriteLine("Nežinomas veiksmas. Paspauskite [ENTER], kad uždaryti programą");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
