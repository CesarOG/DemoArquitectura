using Infra.Repositorio.Interface;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio
{
   public interface IUnitOfWork
    {
        IClienteServicio cliente { get; }
        IProductoServicio producto { get; }        
    }
}
