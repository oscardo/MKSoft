using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public static class Usuario
{
        public static Usuario ObtenerUnUsuario(string User, string Clave)
        {
            return DatosUsuario.Usuario.SingleOrDefault<Usuario>(p => (p.NombreUsuario == User) && (p.Password == Clave));
        }
    
}