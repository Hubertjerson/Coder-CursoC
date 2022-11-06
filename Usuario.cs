using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }

        public Usuario (int id, string Nombre, string Apellido, string NombreUsuario, string Contrasenia, string Email)
        {
            this.id = id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.NombreUsuario = NombreUsuario;
            this.Contrasenia = Contrasenia;
            this.Email = Email;
        }
    }
}
