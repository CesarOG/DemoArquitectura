using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;
using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Implementacion;
using Infra.Repositorio.Interface;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio.Implementacion
{
    public class ProductoServicio : IProductoServicio
    {
        //construto la interface  del repositorio

        IProductoRepositorio _productoRepositorio;

        public ProductoServicio(string cn)
        {
            _productoRepositorio = new ProductoRepositorio(cn);

        }


        public void add(Producto entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ListarProductos()
        {
            return _productoRepositorio.ListarProductos();
        }

        public void update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }


}
