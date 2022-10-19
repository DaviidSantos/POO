using System;
using Exercicio10.Entidade;

namespace Exercicio10
{
    internal class Program
    {
        public static int NUMERO_DE_QUARTOS = 10;
        
        public static void Main(string[] args)
        {
            int numberOfRooms, roomNumber;
            string name, email;

            Console.Write("How many rooms will be rented: ");
            numberOfRooms = Int32.Parse(Console.ReadLine());

            Quarto[] quarto = new Quarto[NUMERO_DE_QUARTOS];

            for (int i = 0; i < numberOfRooms; i++)
            {
                Console.WriteLine($"Rent #{i+1}");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                roomNumber = Int32.Parse(Console.ReadLine());

                quarto[roomNumber] = new Quarto { RentersName = name, Email = email, RoomNumber = roomNumber };
            }
            
            Console.WriteLine("Busy rooms:");
            foreach (Quarto quartoOcupado in quarto)
            {
                Console.WriteLine(quartoOcupado);
            }
        }
    }
}