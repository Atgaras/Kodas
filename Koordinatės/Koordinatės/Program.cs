using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinatės
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite Y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite X1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite Y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite M");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite N");
            int n = int.Parse(Console.ReadLine());

            bool mTelpa = (m >= x) && (m <= x1);
            bool nTelpa = (n <= y1) && (n <= y1);

            Console.WriteLine((mTelpa == nTelpa) && (mTelpa == true));
            Console.ReadLine();
        }
    }
}
