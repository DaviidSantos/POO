using System;
using Exercicio07.Entidades;

namespace Exercicio07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.PrimeiroTrimestre = Double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo trimestre: ");
            aluno.SegundoTrimestre = Double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do terceiro trimestre: ");
            aluno.TerceiroTrimestre = Double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal()}");
            aluno.ConceitoFinal();
            
        }
    }
}