using System;

namespace Exercicio05.Entidades
{
    public class Retangulo
    {
        private double _largura;
        private double _altura;

        public double Largura
        {
            get => _largura;
            set => _largura = value;
        }

        public double Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public double Area()
        {
            return _largura * _altura;
        }

        public double Perimetro()
        {
            return 2 * (_altura + _largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(_altura, 2) + Math.Pow(_largura, 2));
        }
        
    }
}