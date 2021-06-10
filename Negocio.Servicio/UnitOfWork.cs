using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Implementacion;
using Infra.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Negocio.Servicio.Implementacion;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Negocio.Servicio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestContext _context;
        private IDbContextTransaction trans = null;
        private bool disposed = false;
        public UnitOfWork(TestContext context)
        {
            _context = context;
            cliente = new ClienteServicio(context);
            producto = new ProductoServicio(context);
        }
        public IClienteServicio cliente { get; private set; }
        public IProductoServicio producto { get; private set; }


        public void BeginTransaction()
        {
            if (trans == null)
            {
                trans = _context.Database.BeginTransaction();
            }
        }

        public void CleanContext()
        {
            foreach (EntityEntry dbEntityEntry in _context.ChangeTracker.Entries())
            {
                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }

        public void CommitTransaction()
        {
            if (trans != null)
            {
                trans.Commit();
                trans.Dispose();
                trans = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void RollbackTransaction()
        {
            if (trans != null)
            {
                trans.Rollback();
                trans.Dispose();
                trans = null;
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
