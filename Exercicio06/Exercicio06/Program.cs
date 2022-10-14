using System;
using Exercicio06.Entidades;

namespace Exercicio06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = Double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(funcionario);
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(Double.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Dados Atualizados: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}");
        }
    }
}