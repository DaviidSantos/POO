using System;
using Exercicio08.Classe;

namespace Exercicio08
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar?: ");
            double cotacao = Double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar?: ");
            double dolares= Double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor a ser pago em reais: R$ {ConversorDeMoeda.converterParaReais(cotacao, dolares)}");
        }
    }
}