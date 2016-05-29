using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    class Class1
    {
        static void Main(string[] args)
        {
            var num1 = 10;
            var num2 = 20;

            var calculadora = new Calculadora(num1, num2);
            Console.WriteLine("Soma: " + calculadora.CalculaSoma());
            Console.ReadKey();
        }
    }
}
