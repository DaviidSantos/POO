namespace Exercicio06.Entidades
{
    public class Funcionario
    {
        private string _nome;
        private double _salarioBruto;
        private double _imposto;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double SalarioBruto
        {
            get => _salarioBruto;
            set => _salarioBruto = value;
        }

        public double Imposto
        {
            get => _imposto;
            set => _imposto = value;
        }

        public double SalarioLiquido()
        {
            return _salarioBruto - _imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            _salarioBruto *= 1 + porcentagem / 100;
        }

        public override string ToString()
        {
            return $"Funcionário = {_nome}, $ {SalarioLiquido()}";
        }
    }
}