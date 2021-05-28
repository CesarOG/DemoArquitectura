using Infra.Repositorio.Implementacion;
using Infra.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string cnString)
        {
            cliente = new ClienteRepositorio(cnString);
            producto = new ProductoRepositorio(cnString);
            producto2 = new ProductoRepositorio(cnString);
        }
        public IClienteRepositorio cliente { get; private set; }
        public IProductoRepositorio producto { get; private set; }
        public IProductoRepositorio producto2 { get; private set; }
    }
}
