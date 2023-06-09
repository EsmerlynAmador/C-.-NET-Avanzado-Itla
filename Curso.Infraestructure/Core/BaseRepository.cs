﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Curso.Infraestructure.Context;

namespace Curso.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : Cursos.Domain.Repository.IBaseRepository<TEntity> where TEntity : class
    {
        private readonly CursosContext context;
        private readonly DbSet<TEntity> myDbSet;
        public BaseRepository(CursosContext context)
        {
            this.context = context;
            this.myDbSet = this.context.Set<TEntity>();
        }
        public async virtual Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await this.myDbSet.AnyAsync(filter);
        }
        public async virtual Task<TEntity> Find(Expression<Func<TEntity, bool>> filter)
        {
            return await this.myDbSet.FindAsync(filter);
        }
        public async virtual Task<IEnumerable<TEntity>> GetAll()
        {
            return await this.myDbSet.ToListAsync();
        }
        public async virtual Task<TEntity> GetEntityById(int Id)
        {
            return await this.myDbSet.FindAsync(Id);
        }
        public async virtual Task Save(TEntity entity)
        {
            await this.myDbSet.AddAsync(entity);
        }
        public async virtual Task Save(params TEntity[] entities)
        {
            await this.myDbSet.AddRangeAsync(entities);
        }
        public async virtual Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
        public async virtual Task Update(TEntity entity)
        {
            this.myDbSet.Update(entity);
        }
        public async virtual Task Update(params TEntity[] entities)
        {
            this.myDbSet.UpdateRange(entities);
        }
    }
}
