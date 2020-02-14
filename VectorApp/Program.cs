using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vA = new Vector { X = 5, Y = 3, Z = 4 };
            Vector vB = new Vector { X = 2, Y = 12, Z = 4 };

            var vC = vA + vB;
            Console.WriteLine(vC.ToString());

            var vD = vB + 12;
            Console.WriteLine(vD.ToString());

            var vE = 2 * vA;
            Console.WriteLine(vE.ToString());

            Vector vF = new Vector { X = 5, Y = 3, Z = 4 };
            bool equal = vA == vF;

            Console.WriteLine($"VectorA({vA.ToString()}) = VectorB({vF.ToString()}) - {equal}");
            Console.ReadLine();
        }
    }
}
