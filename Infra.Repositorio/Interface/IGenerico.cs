using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Interface
{
    public interface IGenerico<T> where T : class
    {
        void add(T entity);
        void update(T entity);
        void delete(int id);
        IEnumerable<T> Get();
        T findById(int id);
        void CreateRange(IEnumerable<T> entities);
    }
}
