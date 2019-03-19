using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencosud.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Delete(int id);
        Task<T> Update(int id, T t);
        Task<T> Save(T t);
    }
}
