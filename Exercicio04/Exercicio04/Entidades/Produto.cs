using System;

namespace Exercicio04.Entidades
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double Preco
        {
            get => _preco;
            set => _preco = value;
        }

        public int Quantidade => _quantidade;

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (_quantidade - quantidade >= 0)
            {
                _quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("ERRO! Não é possível ter uma quantidade negativa em estoque!");
            }
        }
    }
}