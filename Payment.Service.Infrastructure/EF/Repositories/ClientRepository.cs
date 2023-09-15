using Payment.Service.Domain.Model.Client;
using Payment.Service.Domain.Repositories;
using Payment.Service.Infrastructure.EF.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Infrastructure.EF.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly WriteDBContext _dbContext;

        public ClientRepository(WriteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Client obj)
        {
            await _dbContext.Client.AddAsync(obj);
        }

        public async Task<Client?> FindByIdAsync(Guid id)
        {
            return await _dbContext.Client.FindAsync(id);
        }

        public Task UpdateAsync(Client client)
        {
            _dbContext.Client.Update(client);
            return Task.CompletedTask;
        }
    }
}
