using Dominio.Entidades.Model;
using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infra.Repositorio.Implementacion
{
    public class ProductoRepositorio : IProductoRepositorio
    {

        //conexion

        readonly TestContext _cn;

        //constructor de conexion
        public ProductoRepositorio(string cn)
        {

            _cn = new TestContext(cn);
        }

        //Metodos del contrato de la interfaz generico
        
        
        public void add(Producto entity)
        {
            throw new NotImplementedException();
        }

      public  void delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Producto> IGenerico<Producto>.Get()
        {
            throw new NotImplementedException();
        }

        public void update(Producto entity)
        {
            throw new NotImplementedException();
        }

        //metodo personalizado

        public IEnumerable<Producto> ListarProductos()
        {

            return _cn.Producto;
        }




    }
}
