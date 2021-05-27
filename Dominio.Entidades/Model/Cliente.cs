using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades.Model
{
 public   class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public bool Estado { get; set; }
    }
}
