using Infra.Repositorio.Interface;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Negocio.Servicio
{
    public interface IUnitOfWork : IDisposable
    {          
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        int SaveChanges();
        //int SaveChangesAudit(IUser currentUser);
        void CleanContext();
        IClienteServicio cliente { get; }
        IProductoServicio producto { get; }
    }
}
