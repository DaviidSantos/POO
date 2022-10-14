using System;
using Exercicio01.Entidade;

namespace Exercicio01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            
            Console.Write("Informe o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Informe a idade da primeira pessoa: ");
            pessoa1.Idade = Int32.Parse(Console.ReadLine());
            
            Console.Write("Informe o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Informe a idade da segunda pessoa: ");
            pessoa2.Idade = Int32.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa1.Nome}");
            }
            else if(pessoa1.Idade < pessoa2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa2.Nome}");
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade!");
            }
        }
    }
}