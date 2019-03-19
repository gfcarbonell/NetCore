using Cencosud.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencosud.Repository.Interfaces
{
    public interface IClientRepository: IRepository<ClientEntity>
    {
        Task<ClientEntity> GetClientInFraudPrevention(int documentType, string documentNumber);

    }
}
