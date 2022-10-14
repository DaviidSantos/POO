using System;
using Exercicio05.Entidades;

namespace Exercicio05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            
            Console.Write("Informe a largura do retangulo: ");
            retangulo.Largura = Double.Parse(Console.ReadLine());
            
            Console.Write("Informe a altura do retangulo: ");
            retangulo.Altura = Double.Parse(Console.ReadLine());
            
            Console.WriteLine($"ÁREA = {retangulo.Area()}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro()}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal()}");
        }
    }
}