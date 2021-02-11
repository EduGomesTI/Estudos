using Aula_142.Entities;
using Aula_142.Entities.Exceptions;
using System;

namespace Aula_142
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number room: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy)");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy)");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();

                Console.Write("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy)");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy)");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
