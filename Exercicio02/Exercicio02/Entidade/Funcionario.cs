namespace Exercicio02.Entidade
{
    public class Funcionario
    {
        private string _nome;
        private double _salario;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double Salario
        {
            get => _salario;
            set => _salario = value;
        }
    }
}