using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cencosud.DataAccess;
using Cencosud.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cencosud.Repository.Interfaces
{
    public class ClientRepository : IClientRepository
    {
        private readonly IOriginationDbContext IOriginationDbContext;
        public ClientRepository(IOriginationDbContext IOriginationDbContext)
        {
            this.IOriginationDbContext = IOriginationDbContext;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> GetClientInFraudPrevention(int documentType, string documentNumber)
        {
            var obj = IOriginationDbContext.Database.ExecuteSqlCommandAsync("usp_CreateShipper @p0, @p1", parameters: new[] { "hello", "world" });
            return null;
        }

        public Task<ClientEntity> Save(ClientEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> Update(int id, ClientEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
