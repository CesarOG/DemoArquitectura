using Infra.Repositorio.Implementacion;
using Infra.Repositorio.Interface;
using Negocio.Servicio.Implementacion;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string cnString)
        {
            cliente = new ClienteServicio(cnString);
            producto = new ProductoServicio(cnString);
        }
        public IClienteServicio cliente { get; private set; }
        public IProductoServicio producto { get; private set; }

    }
}
