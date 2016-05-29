using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Calculadora01
{
    public class Calculadora
    {
        private readonly double _num1;
        private readonly double _num2;

        // Construtor da Classe
        public Calculadora(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;

        }

        internal string CalculaSoma()
        {
            throw new NotImplementedException();
        }

        public double CalcularSoma()
        {
            return (_num1 + _num2);
        }

        public double CalcularSubtracao()
        {
            return (_num1 - _num2);
        }

        public double CalcularMultiplicacao()
        {
            return (_num1 * _num2);
        }

        public double Calculardivisao()
        {
            return (_num1 / _num2);
        }

    }
}
