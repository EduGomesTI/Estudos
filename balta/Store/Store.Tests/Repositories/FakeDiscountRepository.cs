using System;
using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDiscountRepository : IDiscountRepository
    {
        public Discount Get(string code)
        {
            switch (code)
            {
                case "12345678": return new Discount(10, DateTime.Now.AddDays(5));
                case "11111111": return new Discount(10, DateTime.Now.AddDays(-5));
                default: return null;
            }
        }
    }
}