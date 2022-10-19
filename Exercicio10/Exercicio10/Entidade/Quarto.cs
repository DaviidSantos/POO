namespace Exercicio10.Entidade
{
    public class Quarto
    {
        private string _rentersName;
        private string _email;
        private int _roomNumber;

        public string RentersName
        {
            get => _rentersName;
            set => _rentersName = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int RoomNumber
        {
            get => _roomNumber;
            set => _roomNumber = value;
        }

        public override string ToString()
        {
            return $"{_roomNumber}: {_rentersName}, {_email}";
        }
    }
}