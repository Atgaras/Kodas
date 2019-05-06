using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pažymys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite pažymį:");
            Console.WriteLine("[1],[2],[3],[4] - NEPATENKINAMAI, [5] - SILPNAI, [6] - Patenkinamai, [7] - VIDUTINIŠKAI, [8]- GERAI, [9] - LABAI GERAI, [10] - PUIKIAI");
            int pažymys = int.Parse(Console.ReadLine());

            switch (pažymys)
            {
                case 1: //(pažymys <= 4)
                    Console.WriteLine("NEPATENKINAMAI");
                    break;

                case 2: //(pažymys = 5)
                    Console.WriteLine("SILPNAI");
                    break;

                case 3: //(pažymys = 6)
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 4: //(pažymys = 7)
                    Console.WriteLine("VIDUTINIŠKAI");
                    break;
                case 5: //(pažymys = 8)
                    Console.WriteLine("GERAI");
                    break;
                case 6: //(pažymys = 9)
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 7: //(pažymys = 10)
                    Console.WriteLine("PUIKIAI");
                    break;
                default:
                    Console.WriteLine("Nežinomas veiksmas. Spauskite [ENTER], kad uždaryti");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Spauskite [ENTER], kad uždaryti");
            Console.ReadLine();
        }
    }
}
