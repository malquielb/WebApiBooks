using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Books.Application.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        public Task<IReadOnlyCollection<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Add(T entity);
        public Task<T> Update(T entity);
        public Task<T> Delete(T entity);
    }
}
