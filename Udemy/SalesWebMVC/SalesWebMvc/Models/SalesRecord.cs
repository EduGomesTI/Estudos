using System;
using SalesWebMvc.Models.Enuns;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus Status;
        public Seller Seller { get; set; }

        //Construtores
        public SalesRecord() { }
        public SalesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
