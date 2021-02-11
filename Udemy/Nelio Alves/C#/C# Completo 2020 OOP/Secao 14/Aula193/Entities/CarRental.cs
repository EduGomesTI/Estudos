using System;

namespace Aula193.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime dateTime, DateTime finish, Vehicle vehicle)
        {
            Start = dateTime;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
