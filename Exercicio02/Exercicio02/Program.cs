using System;
using Exercicio02.Entidade;

namespace Exercicio02
{
    internal class Program
    {
        public const int NUMERO_DE_FUNCIONARIOS = 2;
        public static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            
            Console.Write("Informe o nome do primeiro funcionário: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Informe o salario do primeiro funcionario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o nome do segundo funcionário: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Informe o salario do segundo funcionario: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            double media = (funcionario1.Salario + funcionario2.Salario) / NUMERO_DE_FUNCIONARIOS;
            
            Console.WriteLine($"A média salarial dos funcionarios é de R$ {media}");
        }
    }
}