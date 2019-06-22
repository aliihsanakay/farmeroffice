﻿using FarmerOffice.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace NetSatis.Entities.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity> : IEntityRepository<TContext, TEntity>
          where TContext : DbContext, new() where TEntity : class, IEntity, new() 
    {
        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
        public void AddOrUpdate(TContext context, TEntity entity)
        {
            
                context.Set<TEntity>().Add(entity);
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
