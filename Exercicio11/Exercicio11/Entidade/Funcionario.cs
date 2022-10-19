namespace Exercicio11.Entidade
{
    public class Funcionario
    {
        private int _id;
        private string _name;
        private double _salary;

        public Funcionario(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int Id
        {
            get => _id;
            set => _salary = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public void IncreaseSalary(double percentage)
        {
            _salary = _salary * (1 + percentage / 100);
        }

        public override string ToString()
        {
            return $"{_id}, {_name}, {_salary}";
        }
    }
}