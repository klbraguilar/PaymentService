using Payment.Service.Domain.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Domain.Factories
{
    public class BillFactory : IBillFactory
    {
        public Bill Create(string period, decimal amount, Guid clientId, Guid catId)
        {
            return new Bill(period, amount, clientId, catId);
        }
    }
}
