using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Interface
{
    public interface IGenerico<T> where T : class
    {
        void add(T entity);
        void update(T entity);
        void delete(Guid Id);
        IEnumerable<T> Get();
    }
}
