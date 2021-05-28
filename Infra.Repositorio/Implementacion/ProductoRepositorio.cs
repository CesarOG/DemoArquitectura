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
    public class ProductoRepositorio : Generico<Producto>, IProductoRepositorio
    {
        //constructor de conexion
        public ProductoRepositorio(string cn) : base(cn)
        {
            //_cn = new TestContext(cn);
        }

        //metodo personalizado

        public IEnumerable<Producto> ListarProductos()
        {
            return _cn.Producto;
        }




    }
}
