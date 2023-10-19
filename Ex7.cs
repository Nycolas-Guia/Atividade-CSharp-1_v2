using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Ex7
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.WriteLine("Digite o primeiro valor");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            c = Convert.ToDouble(Console.ReadLine());

            delta = (b * b) - 4 * a * c;
            Console.WriteLine("O valor de Delta é: " + delta);

            Console.ReadKey();

        }
    }
}
