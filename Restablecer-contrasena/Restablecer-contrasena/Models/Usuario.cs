using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restablecer_contrasena.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
