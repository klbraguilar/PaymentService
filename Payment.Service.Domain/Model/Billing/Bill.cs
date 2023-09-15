using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Domain.Model.Billing
{
    public class Bill : AggregateRoot
    {
        public string? Period { get; private set; }
        public State State { get; private set; }
        public AmountBill Amount { get; private set; }
        public Guid ClientId { get; private set;}

        public Guid CategoryId { get; private set; }

        public Bill(string period,  decimal amount, Guid clientId, Guid catId)
        {
            Id = Guid.NewGuid();
            Period = period;
            State = State.Pending;
            Amount = amount;
            ClientId = clientId;
            CategoryId = catId;
        }

        private Bill() { }
    }
}
