using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades.ViewModel
{
   public class ProductoViewModel
    {

        public int IIdproducto { get; set; }

        public string vNombrecodigo { get; set; }
        public string vNombre { get; set; }
        public string vCodigo { get; set; }
        public int iStock { get; set; }
        public bool bEstado { get; set; }
    }
}
