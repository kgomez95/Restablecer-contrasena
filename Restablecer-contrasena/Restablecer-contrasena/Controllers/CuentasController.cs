using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restablecer_contrasena.Models;

namespace Restablecer_contrasena.Controllers
{
    public class CuentasController : Controller
    {
        /// <summary>
        /// Retorna la vista de iniciar sesión.
        /// </summary>
        public IActionResult IniciarSesion()
        {
            return View();
        }

        /// <summary>
        /// Inicia sesión en la aplicación.
        /// </summary>
        /// <param name="datosUsuario">Objeto con nombre de usuario y contraseña para poder iniciar sesión.</param>
        /// <returns>Devuelve un objeto DatosRespuesta.</returns>
        [HttpPost]
        public IActionResult Identificarse([FromBody] Usuario datosUsuario)
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Genera un código de seguridad para el correo electrónico especificado (en caso de que exista en la base de datos) y
        /// envía el código de seguridad a dicha dirección.
        /// </summary>
        /// <param name="correoElectronico">Dirección de correo electrónico.</param>
        /// <returns>Devuelve un objeto DatosRespuesta.</returns>
        [HttpPost]
        public IActionResult EnviarCodigoSeguridad([FromBody] string correoElectronico)
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Cambia la contraseña del usuario especificado comprobando el correo electrónico y el código de seguridad.
        /// </summary>
        /// <param name="cambioContrasena">Objeto con el correo electrónico, el código de seguridad y la nueva contraseña.</param>
        /// <returns>Devuelve un objeto DatosRespuesta.</returns>
        [HttpPost]
        public IActionResult CambiarContrasena([FromBody] dynamic cambioContrasena)
        {
            // TODO
            return null;
        }
    }
}