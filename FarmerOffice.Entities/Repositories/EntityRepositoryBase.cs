using FarmerOffice.Entities.Context;
using FarmerOffice.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using FarmerOffice.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace FarmerOffice.Entities.Repositories
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
        public void Add(TContext context, TEntity entity)
        {

            context.Set<TEntity>().Add(entity);
        }

        public void Update(TContext context, TEntity entity)
        {

            context.Set<TEntity>().Update(entity);
        }
        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
        public List<TEntity> ExecuteReader(TEntity entity, string spName, ParameterInfo[] parameterNames, object[] parameterValues)
        {
            FarmerOfficeContext officeContext = new FarmerOfficeContext();
            var response = officeContext.Set<TEntity>().FromSql("Exec " + spName + " " + GenerateParamName(parameterNames), GenerateParam(parameterNames, parameterValues)).ToList();
            return response.ToList();
        }

        public List<TEntity> ExecuteReader(TEntity entity, string spName)
        {
            FarmerOfficeContext officeContext = new FarmerOfficeContext();
            var response = officeContext.Set<TEntity>().FromSql("Exec " + spName).ToList();
            return response.ToList();
        }

        public bool ExecuteNonQuery(TEntity entity, string spName, ParameterInfo[] parameterNames, object[] parameterValues)
        {
            FarmerOfficeContext officeContext = new FarmerOfficeContext();

            try
            {
                officeContext.Set<TEntity>().FromSql("Exec " + spName + " " + GenerateParamName(parameterNames), GenerateParam(parameterNames, parameterValues)).ToList();
                return true;
            }
            catch (Exception)
            {
                //logla
                return false;
            }
        }

        public bool ExecuteNonQuery(TEntity entity, string spName)
        {
            FarmerOfficeContext officeContext = new FarmerOfficeContext();

            try
            {
                officeContext.Set<TEntity>().FromSql("Exec " + spName).ToList();
                return true;
            }
            catch (Exception)
            {
                //logla
                return false;
            }
        }


        public static object[] GenerateParam(ParameterInfo[] parameterNames, params object[] parameterValues)
        {
            int length = parameterNames.Length;
            SqlParameter[] sqlParams = new SqlParameter[length];
            object[] xparams = new object[length];
            for (int i = 0; i < length; i++)
            {
                xparams[i] = new SqlParameter(parameterNames[i].Name, parameterValues[i]);
            }
            return xparams;
        }

        public static string GenerateParamName(ParameterInfo[] parameterNames)
        {
            int length = parameterNames.Length;
            string parameters = "";

            for (int i = 0; i < length; i++)
            {
                parameters += "@" + parameterNames[i].Name + ",";
            }
            parameters = parameters.Substring(0, parameters.Length - 1);
            return parameters;
        }
    }
}
