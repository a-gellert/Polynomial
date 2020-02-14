using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial polyA = new Polynomial(3, 4, 2, 4, 3, 5);
            Polynomial polyB = new Polynomial(3, 6, -5, -8, 2, 1);

            Polynomial polyC = polyA + polyB;

            Console.WriteLine(polyC.Show());

            Polynomial polyD = polyA - polyB;

            Console.WriteLine(polyD.Show());

            Polynomial polyE = polyA * (-3);

            Console.WriteLine(polyE.Show());


            Console.Read();
        }
    }
}
