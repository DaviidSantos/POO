using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Principal;
using Exercicio11.Entidade;

namespace Exercicio11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int quantidadeDeFuncionarios;
            int id = 0;
            double porcentagem;
            
            Console.Write("Quantos funcionários serão cadastrados?: ");
            quantidadeDeFuncionarios = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                string nome;
                double salario;
                
                Console.WriteLine($"Funcionario #{i+1}:");
                Console.Write("Id: ");
                id = Int32.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = Double.Parse(Console.ReadLine());
                
                funcionarios.Add(new Funcionario(id, nome, salario));
            }
            
            Console.Write("Informe o id do funcionario que terá um aumento de salário: ");
            id = Int32.Parse(Console.ReadLine());
            Funcionario acharFuncionario = funcionarios.Find(x => x.Id == id);
            if (acharFuncionario != null)
            {
                Console.Write("Informe a porcentagem: ");
                porcentagem = Double.Parse(Console.ReadLine());
                acharFuncionario.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionario não existe!");
            }
            
            Console.WriteLine("Lista atualizada de funcionarios: ");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}