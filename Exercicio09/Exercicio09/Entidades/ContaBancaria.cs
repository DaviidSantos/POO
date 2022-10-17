using System;

namespace Exercicio09.Entidades
{
    public class ContaBancaria
    {
        private const double TAXA_SAQUE = 5.00;
        private int _numeroDaConta;
        private string _titularDaConta;
        private double _saldo;

        public ContaBancaria(int numeroDaConta, string titularDaConta)
        {
            _numeroDaConta = numeroDaConta;
            _titularDaConta = titularDaConta;
        }

        public ContaBancaria(int numeroDaConta, string titularDaConta, double saldo) : this(numeroDaConta, titularDaConta)
        {
            _saldo = saldo;
        }

        public int NumeroDaConta => _numeroDaConta;

        public string TitularDaConta
        {
            get => _titularDaConta;
            set => _titularDaConta = value;
        }

        public double Saldo => _saldo;

        public void Deposito(double valorDoDeposito)
        {
            _saldo += valorDoDeposito;
        }

        public void Saque(double valorDoSaque)
        {
            _saldo -= valorDoSaque + TAXA_SAQUE;
        }

        public override string ToString()
        {
            return $"\nDados da Conta:\nConta {_numeroDaConta}, Titular: {_titularDaConta}, Saldo: $ {_saldo.ToString("N2")}\n";
        }
    }
}