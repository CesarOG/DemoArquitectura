using AutoMapper;
using Dominio.Entidades.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.WebAPI.Controllers
{
    [Route("producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        //construyo negocio y instancio mappe

        private readonly IMapper _mapper;
        private readonly IProductoServicio _productoServicio;

        public ProductoController(IMapper mapper, IProductoServicio productoServicio)
        {
            _mapper = mapper;
            _productoServicio = productoServicio;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        [Route("ListaProductos")]
        public IActionResult ListaProductos()
        {
            
            var Lista = _mapper.Map<List<ProductoViewModel>>(_productoServicio.ListarProductos());

            return Ok(Lista);
        }


    }
}
