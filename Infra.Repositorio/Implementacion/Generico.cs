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
        protected TestContext _context;
        private readonly DbSet<T> dbSet;
        public Generico(TestContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        public void add(T entity)
        {
            dbSet.Add(entity);
            //_context.SaveChanges();
        }

        public void delete(int id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                //_context.SaveChanges();
            }
        }

        public IEnumerable<T> Get()
        {
            return dbSet;
        }

        public void update(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            //_context.SaveChanges();
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
            //_context.SaveChanges();
        }
    }
}
