using AutoMapper;
using Dominio.Entidades.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Negocio.Servicio;
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
    public class ProductoController : BaseController
    {
        //construyo negocio y instancio mappe
        public ProductoController(IMapper mapper, IUnitOfWork unitOfWork) : base(unitOfWork, mapper)
        {
        }
        // GET: api/<ProductoController>
        [HttpGet]
        [Route("ListaProductos")]
        public IActionResult ListaProductos()
        {

            var Lista = _mapper.Map<List<ProductoViewModel>>(_unitOfWork.producto.ListarProductos());

            return Ok(Lista);
        }


    }
}
