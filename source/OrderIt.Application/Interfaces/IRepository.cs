using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderIt.Application
{
    public interface IRepository
    {
        ValueTask<T> GetByIdAsync<T>(Guid id);

        Task<List<T>> GetAllAsync<T>();

    }
}