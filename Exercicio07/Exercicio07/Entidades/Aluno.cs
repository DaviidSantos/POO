using System;
using System.Dynamic;

namespace Exercicio07.Entidades
{
    public class Aluno
    {
        private const int NOTA_MINIMA = 60;
        private string _nome;
        private double _primeiroTrimestre;
        private double _segundoTrimestre;
        private double _terceiroTrimestre;
        private double _notaFinal;
        private string _conceito;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double PrimeiroTrimestre
        {
            get => _primeiroTrimestre;
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _primeiroTrimestre = value;
                }
                else
                {
                    Console.WriteLine("A nota do primeiro trimestre tem que estar entre 0 e 30");
                }
            }
        }

        public double SegundoTrimestre
        {
            get => _segundoTrimestre;
            set
            {
                if (value >= 0 && value <= 35)
                {
                    _segundoTrimestre = value;
                }
                else
                {
                    Console.WriteLine("A nota do segundo trimestre tem que estar entre 0 e 35");
                }
            } 
        }
        
        public double TerceiroTrimestre
        {
            get => _terceiroTrimestre;
            set
            {
                if (value >= 0 && value <= 35)
                {
                    _terceiroTrimestre = value;
                }
                else
                {
                    Console.WriteLine("A nota do terceiro trimestre tem que estar entre 0 e 35");
                }
            } 
        }
        

        public double NotaFinal()
        {
            _notaFinal = _primeiroTrimestre + _segundoTrimestre + _terceiroTrimestre;
            return _notaFinal;
        }

        public void ConceitoFinal()
        {
            if (_notaFinal >= 60)
            {
                _conceito = "Aprovado";
                Console.WriteLine(_conceito);
            }
            else
            {
                double pontosFaltantes;
                
                _conceito = "Reprovado";
                Console.WriteLine(_conceito);

                pontosFaltantes = NOTA_MINIMA - _notaFinal;
                Console.WriteLine($"Faltaram {pontosFaltantes} pontos!");
            }
        }
    }
}