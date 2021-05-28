using Infra.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio
{
   public interface IUnitOfWork
    {
        IClienteRepositorio cliente { get; }
        IProductoRepositorio producto { get; }
        IProductoRepositorio producto2 { get; }
    }
}
