using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.Entidades.ViewModel
{
    public class ClienteViewModel
    {
        public int nId { get; set; }
        [Required]
        public string vNombre { get; set; }
        [Required]
        public string vApePaterno { get; set; }
        [Required]
        public string vApeMaterno { get; set; }
        public string vNombreCompleto { get; set; }
        public int? nEdad { get; set; }
        public bool bEstado { get; set; }        
    }
}
