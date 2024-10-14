﻿using System.Linq.Expressions;

namespace Domain.Interfaces.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task Delete(T entity);
        Task<T?> GetById(int id);
        Task Update(T entity);
        IList<T> Get();
        Task<IList<T>> GetAsync();
    }
}
