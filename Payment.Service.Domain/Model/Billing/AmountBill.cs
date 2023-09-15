using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Domain.Model.Billing
{
    public record AmountBill : ValueObject
    {
        public decimal Amount { get; init; }

        public AmountBill(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount should be greater than 0");
            }
            Amount = amount;
        }

        public static implicit operator decimal(AmountBill amount) => amount.Amount;

        public static implicit operator AmountBill(decimal amount) => new(amount);
    }
}
