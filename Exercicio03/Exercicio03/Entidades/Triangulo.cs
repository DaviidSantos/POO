using System;

namespace Exercicio03.Entidades
{
    public class Triangulo
    {
        private double _ladoA;
        private double _ladoB;
        private double _ladoC;

        public double LadoA
        {
            get => _ladoA;
            set => _ladoA = value;
        }

        public double LadoB
        {
            get => _ladoB;
            set => _ladoB = value;
        }

        public double LadoC
        {
            get => _ladoC;
            set => _ladoC = value;
        }

        public double Area()
        {
            double p = (_ladoA + _ladoB + _ladoC) / 2.0;
            return Math.Sqrt(p * (p - _ladoA) * (p - _ladoB) * (p - _ladoC));

        }
    }
}