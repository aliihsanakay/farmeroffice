using FarmerOffice.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace NetSatis.Entities.Interfaces
{
    public interface IEntityRepository<TContext, TEntity> where TContext : DbContext, new() where TEntity : class, IEntity, new()
    {
        void Add(TContext context, TEntity entity);
        void Update(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        List<TEntity> ExecuteReader(TEntity entity, string spName, ParameterInfo[] parameterNames, object[] parameterValues);
        bool ExecuteNonQuery(TEntity entity, string spName, ParameterInfo[] parameterNames, object[] parameterValues);
        void Save(TContext context);
    }
}
