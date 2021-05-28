using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio.Interface
{
   public interface IProductoServicio
    {
        void add(Producto entity);
        void update(Producto entity);
        void delete(Guid Id);
        IEnumerable<Producto> Get();
        IEnumerable<Producto> ListarProductos();

    }
}
