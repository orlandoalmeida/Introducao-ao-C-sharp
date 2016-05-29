using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeFuncionario = "Orlando Almeida", cargo = "Programador", estadoCivil = "Casado";
            decimal salario = 3000.00m;
            DateTime niver = DateTime.Now.Date;

            Console.WriteLine("Nome: " + nomeFuncionario);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Estado Civíl: " + estadoCivil);
            Console.WriteLine("Salário: " + salario);
            Console.WriteLine("Aniverssário: " + niver);

            /*
             * ***como formatar uma string ****
            string meuFormato = string.Format("Nome {0}\nCargo {1}\nEstado Cívil {2} ", nomeFuncionario, cargo, estadoCivil);
            Console.WriteLine("eita\n" + meuFormato);
            */
            Console.ReadKey(); // equivale ao System("pause");
        }
    }
}
