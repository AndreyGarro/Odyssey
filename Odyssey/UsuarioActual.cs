using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey
{
    class UsuarioActual
    {
        public String nombre;
        private static UsuarioActual usuario = null;

        private UsuarioActual() { }

        public static UsuarioActual getInstance()
        {
            if (usuario == null)
            {
                usuario = new UsuarioActual();              
                return usuario;
            }
            else
            {
                return usuario;
            }
        }
    }
}
