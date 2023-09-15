using Microsoft.EntityFrameworkCore;
using Payment.Service.Domain.Model.Billing;
using Payment.Service.Domain.Model.Category;
using Payment.Service.Domain.Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Infrastructure.EF.Contexts
{
    public class ReadDBContext : DbContext
    {
        
        public ReadDBContext(DbContextOptions<ReadDBContext> options) : base(options){ }
        public virtual DbSet<Client> Client { set; get; }
        public virtual DbSet<Category> Category { set; get; }
        public virtual DbSet<Bill> Bill { set; get; }
        public ReadDBContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
