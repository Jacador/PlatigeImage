using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Interfaces;

namespace PlatigeImage.DataAccess
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IDatabaseEntity
    {
        private readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> RepositoryContext;

        protected BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            RepositoryContext = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return RepositoryContext.AsNoTracking();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        int IBaseRepository<TEntity>.GetCount()
        {
            return RepositoryContext.Count();
        }

        public TEntity? Find(object key)
        {
            return Find(new [] {key});
        }

        public TEntity? Find(object?[]? keys)
        {
            return RepositoryContext.Find(keys);
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return RepositoryContext.Where(expression).AsNoTracking();
        }

        public IQueryable<TEntity> FindByConditionWithTracking(Expression<Func<TEntity, bool>> expression)
        {
            return RepositoryContext.Where(expression);
        }

        public TEntity? Add(TEntity? entity)
        {
            if (entity is null) return default;
            if (Exists(entity)) return entity;

            var entityEntry = RepositoryContext.Add(entity);
            return entityEntry.Entity;
        }

        public List<TEntity> AddMany(List<TEntity> entities)
        {
            _dbContext.BulkInsert(entities, new BulkConfig { SetOutputIdentity = true, IncludeGraph = true});
            return entities;
        }

        public void Update(TEntity? entity)
        {
            if (entity is null) return;
            if (!Exists(entity)) return;

            RepositoryContext.Update(entity);
        }

        public void Delete(TEntity? entity)
        {
            if (entity is null) return;
            if (!Exists(entity)) return;

            RepositoryContext.Remove(entity);
        }

        public void Delete(object key)
        {
            TEntity? entity = Find(new[] {key});
            Delete(entity);
        }

        public bool Exists(TEntity entity)
        {
            return RepositoryContext.Any(k => entity.Id == k.Id);
        }
    }
}
