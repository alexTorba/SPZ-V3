﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Lb7.Model
{
    static class EFGenericRepository
    {
        static readonly DbContext context;

        static EFGenericRepository()
        {
            context = new StudentsDB();
            ((StudentsDB)context).Students.Load();
            ((StudentsDB)context).Subjects.Load();
            ((StudentsDB)context).Marks.Load();

            context.Database.Log = s => Console.WriteLine(s);
        }

        public static void SetDetached<TEntity>(TEntity entity) where TEntity : class
        {
            context.Entry(entity).State = EntityState.Detached;
        }

        public static void SetUnchanged<TEntity>(TEntity entity) where TEntity : class
        {
            context.Entry(entity).State = EntityState.Unchanged;
        }

        public static void Create<TEntity>(TEntity entity) where TEntity : class
        {
            context.Set<TEntity>().Local.Add(entity);
            context.SaveChanges();
        }

        public static void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            context.Set<TEntity>().Local
                .Remove(entity);
            context.SaveChanges();

        }

        public static TEntity FindById<TEntity>(int id) where TEntity : class
        {
            return context.Set<TEntity>().Find(id);
        }

        public static IEnumerable<TEntity> Get<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>().AsEnumerable();
        }

        public static IEnumerable<TEntity> Get<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return context.Set<TEntity>()
                .Where(predicate);
        }

        public static IEnumerable<TEntity> GetForRead<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>()
                .AsNoTracking().AsEnumerable();
        }

        public static IEnumerable<TEntity> GetForRead<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return context.Set<TEntity>()
                .AsNoTracking().Where(predicate);
        }

        public static void Update<TEntity>(TEntity entity) where TEntity : class
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public static void SaveChanges()
        {
            context.SaveChanges();
        }

        public static IEnumerable<TEntity> GetEntitiesWithState<TEntity>(EntityState entityState)
            where TEntity : class
        {
            if (entityState == EntityState.Deleted)
                return context.Set<TEntity>()
                                    .AsEnumerable()
                                    .Where(t => context.Entry(t).State == entityState).ToList();
            else
                return context.Set<TEntity>().Local
                                    .Where(t => context.Entry(t).State == entityState).ToList();
        }

        public static IEnumerable<TEntity> GetEntitiesWithState<TEntity>(
            EntityState entityState, 
            Func<TEntity, bool> predicate) 
            where TEntity : class
        {
            if (entityState == EntityState.Deleted)
                return context.Set<TEntity>()
                                    .AsEnumerable()
                                    .Where(predicate)
                                    .Where(t => context.Entry(t).State == entityState).ToList();
            else
                return context.Set<TEntity>().Local
                                    .Where(predicate)
                                    .Where(t => context.Entry(t).State == entityState).ToList();
        }

        public static IEnumerable<TEntity> GetWithInclude<TEntity>
            (Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
            where TEntity : class
        {
            return Include(includeProperties).Where(predicate);
        }

        public static IEnumerable<TEntity> GetWithInclude<TEntity>
            (params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
        {
            return Include(includeProperties).AsEnumerable();
        }

        private static IQueryable<TEntity> Include<TEntity>
            (params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
        {
            IQueryable<TEntity> query = context.Set<TEntity>().AsQueryable();

            return includeProperties
                .Aggregate(query,
                    (current, includeProperty) => current.Include(includeProperty)
                );
        }

    }
}
