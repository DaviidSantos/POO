using System;
using Exercicio04.Entidades;

namespace Exercicio04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Produto produto = new Produto();
            
            Console.WriteLine("Entre com os dados dos produtos:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = Double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            produto.AdicionarProdutos(Int32.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Dados do Produto: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(Int32.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Dados do Atualizados: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
            
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            produto.RemoverProdutos(Int32.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Dados do Atualizados: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
        }
    }
}