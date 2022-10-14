using System;
using Exercicio03.Entidades;

namespace Exercicio03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            Triangulo triangulo2 = new Triangulo();
            
            Console.Write("Entre com o valor do primeiro lado do primeiro triângulo");
            triangulo1.LadoA = Double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor do segundo lado do primeiro triângulo");
            triangulo1.LadoB = Double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor do terceiro lado do primeiro triângulo");
            triangulo1.LadoC = Double.Parse(Console.ReadLine());
            
            Console.Write("Entre com o valor do primeiro lado do segundo triângulo");
            triangulo2.LadoA = Double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor do segundo lado do segundo triângulo");
            triangulo2.LadoB = Double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor do terceiro lado do segundo triângulo");
            triangulo2.LadoC = Double.Parse(Console.ReadLine());

            double areaPrimeiroTriangulo = triangulo1.Area();
            double areaSegundoTriangulo = triangulo2.Area();
            
            Console.WriteLine($"Área Primeiro Triângulo: {areaPrimeiroTriangulo}");
            Console.WriteLine($"Área Segundo Triângulo: {areaSegundoTriangulo}");

            if (areaPrimeiroTriangulo > areaSegundoTriangulo)
            {
                Console.WriteLine("A área do primeiro triângulo é maior que a do segundo");
            }
            else if (areaPrimeiroTriangulo < areaSegundoTriangulo)
            {
                Console.WriteLine("A área do segundo triâgulo é maior que a do primeiro");
            }
            else
            {
                Console.WriteLine("Ambos triângulos possuem a mesma área!");
            }
        }
    }
}