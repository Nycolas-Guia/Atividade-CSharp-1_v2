using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Ex6
    {
        static void Main(string[] args)
        {
            double ba, al, ar;

            Console.WriteLine("Digite a base do retângulo");
            ba = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo");
            al = Convert.ToDouble(Console.ReadLine());
            ar = ba * al;
            Console.WriteLine("A área é: " + ar);

            Console.ReadKey();

        }
    }
}
