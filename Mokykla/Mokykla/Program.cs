using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokykla
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mokykla = "Code Academy";
            string Kursas = ".NET";
            string studentuSk = "5";
            string data = DateTime.Now.ToString();
            DateTime value = new DateTime(2019, 4, 29);
            DateTime value2 = new DateTime(2019, 7, 4);
            double visoDienu = (value - value2).TotalDays;


            Console.WriteLine("Mokykla - {0}", Mokykla);
            Console.WriteLine("Kursas - {0}", Kursas);
            Console.WriteLine("Studentu skaicius - {0}", studentuSk);
            Console.WriteLine("Data - {0}", data);
            Console.WriteLine("Kurso pradzia {0}", value);
            Console.WriteLine("Kurso pabaiga {0}", value2);
            Console.WriteLine("Viso dienu {0}", visoDienu);

            Console.ReadLine();

        }
    }
}
