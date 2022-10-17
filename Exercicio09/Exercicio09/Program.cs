using System;
using Exercicio09.Entidades;

namespace Exercicio09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numeroDaConta;
            string titularDaConta;
            double depositoInicial;
            char haveraDepositoInicial;
            
            Console.Write("Entre o número da conta: ");
            numeroDaConta = Int32.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            titularDaConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial?(s/n): ");
            haveraDepositoInicial = Console.ReadKey().KeyChar;

            if (haveraDepositoInicial == 's')
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                depositoInicial = Double.Parse(Console.ReadLine());

                ContaBancaria conta = new ContaBancaria(numeroDaConta, titularDaConta, depositoInicial);
                Console.WriteLine(conta);
                
                Console.Write("Entre um valor para depósito: ");
                conta.Deposito(Double.Parse(Console.ReadLine()));
                Console.WriteLine(conta);
                
                Console.Write("Entre um valor para saque: ");
                conta.Saque(Double.Parse(Console.ReadLine()));
                Console.WriteLine(conta);
            } 
            else if (haveraDepositoInicial == 'n')
            {
                ContaBancaria conta = new ContaBancaria(numeroDaConta, titularDaConta);
                Console.WriteLine(conta);
                
                Console.Write("Entre um valor para depósito: ");
                conta.Deposito(Double.Parse(Console.ReadLine()));
                Console.WriteLine(conta);
                
                Console.Write("Entre um valor para saque: ");
                conta.Saque(Double.Parse(Console.ReadLine()));
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Informe 's' ou 'n' para depósito inicial!");
            }
        }
    }
}