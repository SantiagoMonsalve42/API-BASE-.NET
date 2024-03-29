﻿using Data.ModelData;
using Microsoft.EntityFrameworkCore;

namespace Data.Common
{
    public interface IRepository<TEntity> where TEntity : class
    {
        SpDbContext spDbContext { get; }
        DbSet<TEntity> Entity { get; }
        Task<TEntity> CreateAsync(TEntity entity);
        void Detached(TEntity entity);
        Task<TEntity> Put(TEntity entity);
        Task<TEntity> Delete(TEntity entity);

        IQueryable<TEntity> AsQueryable();
        Task<int> Save();
        void Dispose();
    }
}
