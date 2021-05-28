using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Implementacion
{
    public class Generico<T> : IGenerico<T> where T : class
    {
        protected TestContext _cn;
        private readonly DbSet<T> dbSet;
        public Generico(string cn)
        {
            this._cn = new TestContext(cn);
            this.dbSet = _cn.Set<T>();
        }
        public void add(T entity)
        {
            dbSet.Add(entity);
            _cn.SaveChanges();
        }

        public void delete(int id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                _cn.SaveChanges();
            }
        }

        public IEnumerable<T> Get()
        {
            return dbSet;
        }

        public void update(T entity)
        {
            dbSet.Attach(entity);
            _cn.Entry(entity).State = EntityState.Modified;
            _cn.SaveChanges();
        }

        public T findById(int id)
        {
            return dbSet.Find(id);
        }

        public void CreateRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                dbSet.Add(entity);
            }
            _cn.SaveChanges();
        }
    }
}
