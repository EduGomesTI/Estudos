using System;

namespace Exercicio01.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }

        public Contract(int contractNumber, DateTime contractDate)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
        }
    }
}
