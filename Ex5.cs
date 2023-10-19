using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Ex5
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Digite um número");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antecessor: " + (a-1));

            Console.ReadKey();
        }
    }
}
