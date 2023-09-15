using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payment.Service.Domain.Model.Billing;
using Payment.Service.Domain.Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Infrastructure.EF.Config
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("bill");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("billId");

            builder.Property(x => x.Period)
            .HasColumnName("period");

            var typeConverter = new ValueConverter<State, string>(
                enumValueType => enumValueType.ToString(),
                type => (State)Enum.Parse(typeof(State), type)
            );

            var amountConverter = new ValueConverter<AmountBill, decimal>(
                amountValue => amountValue.Amount,
                amount => new AmountBill(amount));

            builder.Property(x => x.Amount)
                .HasColumnName("amount")
                .HasConversion(amountConverter);

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);

        }
    }
}
