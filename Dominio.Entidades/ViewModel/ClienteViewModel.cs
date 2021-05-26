using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.Entidades.ViewModel
{
    public class ClienteViewModel
    {
        [Required]        
        public string Nombre { get; set; }
    }
}
