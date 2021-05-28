using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades.Model
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }

    }
}
