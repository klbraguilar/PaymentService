﻿using Payment.Service.Infrastructure.EF.Contexts;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Service.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WriteDBContext _writeDBContext;

        public UnitOfWork(WriteDBContext writeDBContext)
        {
            _writeDBContext = writeDBContext;
        }
        public async Task Commit()
        {
            await _writeDBContext.SaveChangesAsync();
        }
    }
}
