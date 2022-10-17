using System;

namespace Exercicio08.Classe
{
    public class ConversorDeMoeda
    {
        private const double IOF = 6.0;

        public static double converterParaReais(double cotacao, double dolares)
        {
            return (dolares * (1 + IOF / 100)) * cotacao;
        }
    }
}