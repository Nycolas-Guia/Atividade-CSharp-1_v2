using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio4
{
    class Ex8
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digita a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita a primeira nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita a primeira nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

            Console.WriteLine("Média Final: " + media);
            Console.ReadKey();
        }
    }
}
