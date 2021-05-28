using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dominio.Entidades.Model;

namespace Infra.Repositorio.Interface
{
    public interface IProductoRepositorio :IGenerico<Producto>  
    {

        IEnumerable<Producto> ListarProductos();

    }

   
}
