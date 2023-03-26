using System;

namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string codigoUsuario, string nombre, string constrasena, string correo, DateTime fechaCreacion, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contrasena = constrasena;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }
    }
}
